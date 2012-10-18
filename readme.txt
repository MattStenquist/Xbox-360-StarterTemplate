This is a Starter Template for anyone looking to dive into XNA - Xbox 360 programming. 
All that is included is a backbuffer function called configureScreen(), that aligns
up the _background.png image on your television screen. You can also run this code
on Windows.

Just create a new Project in Visual C#, add the Xbox XNA template,
copy past the Game1.CS code, and nothing else. 

Then duplicate your Xbox Game Project into a Windows Version
Right Click and Debug. 

All you should see is an image that shows up on screen.

That's it. 

You will also have to edit the directory of where the image lies in the content
references. Just edit the "BG\\" and enter your desired director path. 

Hopefully this gets you up and running! :) 

All you should see is just an image load up on screen with the Texture2D and
Rectangle being drawn via the spriteBatch.Draw() and spriteBatch.End(); 

Replace image with your own and start making games!

Also the image is sized at HD size. 1920 x 1080.
