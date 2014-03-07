using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace PhoneApp9Patch.UI9Patch.UI
{
    public partial class TextBox9Patch : UserControl
    {
        private BitmapImage imageSource;

        public TextBox9Patch()
        {
            InitializeComponent();
        }

        private String _source;
        public String Source
        {
            get { return _source; }
            set
            {
                _source = value;

                imageSource = new BitmapImage(new Uri(_source, UriKind.Relative));
                imageSource.CreateOptions = BitmapCreateOptions.None;
                imageSource.ImageFailed += new EventHandler<ExceptionRoutedEventArgs>(bi_ImageFailed);
                imageSource.ImageOpened += new EventHandler<RoutedEventArgs>(bi_ImageOpened);
            }
        }

        void bi_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            throw e.ErrorException;
        }

        void bi_ImageOpened(object sender, RoutedEventArgs e)
        {
            NinePatch mNinePath = new NinePatch((BitmapImage)sender, (int)this.ActualWidth, (int)this.ActualHeight);
            ImageBrush mBruch = new ImageBrush();
            mBruch.ImageSource = mNinePath.getBitmap9Patch();
            TextBox.Background = mBruch;
            TextBox.Padding = mNinePath.getPadding();
            TextBox.Text = "Test blablablabla";
        }
    }
}
