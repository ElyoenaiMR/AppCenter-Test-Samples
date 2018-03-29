XCUITest notes.

- https://docs.microsoft.com/en-us/appcenter/test-cloud/preparing-for-upload/xcuitest#objective-c

Which files are these calls supposed to go in? Are they supposed to be done before or after installing something? Which methods within the files should contain those calls?


- https://docs.microsoft.com/en-us/appcenter/test-cloud/preparing-for-upload/xcuitest#usage
"Be sure that you launch your app with the 'ACTLaunch' API"

> What does this mean? Is that what was shown in the snippets above, or is it something else?


- https://docs.microsoft.com/en-us/appcenter/test-cloud/preparing-for-upload/xcuitest#adding-the-appcenterxcuitestextensions-to-an-xcode-project

> 1, 2 & 3 options make it look like this is a sequence of steps to be taken, rather than "either or" choices to choose from. 


- https://docs.microsoft.com/en-us/appcenter/test-cloud/preparing-for-upload/xcuitest#a-namecarthage--carthage

"Follow the Carthage Instructions[link] for installing frameworks from a Cartfile."

> It would be simpler just to say "create a file named 'Cartfile' in [relative location for your project]" and then "run 'carthage update'" from that folder.


"Remember that the AppCenterXUITestExtensions.framework needs to be linked with the XCUITest target and not the iOS application."

> Instead of just saying "remember to do _____" it would be helpful to say "this is how you do ___" and provide directions. 

