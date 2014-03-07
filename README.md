WindowsPhone_NinePatch
======================

With this lib you can use an image.9.png (9Patch) into a project WP7 and WP8.

For this project I'm using the lib "WriteableBitmapEx"

!!!!This project is still in progress so it can have some bugs. !!!!

How it's working by code:

NinePatch mNinePath = new NinePatch(YOUR_9_PATH_BITMAP_IMAGE, VIEW_WIDTH, VIEW_HEIGHT);

WriteableBitmap yourImageSctartchForYourView = mNinePath.getBitmap9Patch();

