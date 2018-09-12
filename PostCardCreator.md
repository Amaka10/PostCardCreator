# PostCard Creator

Created by Uka Chukwuogor

 PostCard Creator is a web application that takes image input from the user (e.g. drag and drop, file upload, and
web camera), modifies the image by adding text, and sends it as an email to a specified recipient.

This application was choosen, because it appears to be challenging and the idea of working with webcams and email API is very interesting.

# Use/Test
  This is application can be debugged using visual studio or visual studio code.
  It can also be used by deploying it.
  To get the email to be sent correctly
  - change/update the smtp setting in web.config 
  - It looks like this : <add key="smtp" value="" />

# Operating systems and frameworks required for debugging: 
  -Windows operating system
  -.Net Framework 4.6.1+
# External Libraries
- getUserMedia.js
  -   Version: v1.00
  -   Purpose:  a cross-browser shim for the getUserMedia() API (a part of WebRTC) that supports accessing a local camera device from inside the browser. Where WebRTC support is detected, it will use the browser's native getUserMedia() implementation, otherwise a Flash fallback will be loaded instead.
  -   License: Licensed under the MIT license
  -   Website: https://github.com/addyosmani/getUserMedia.js/



