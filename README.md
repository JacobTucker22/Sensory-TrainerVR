# Sensory-TrainerVR
CS484/684 Virtual Reality Final Project. Sensory training virtual experience for those with sensory issues
Group 10: Cole Atkinson, Johanna Cohen, and Jacob Tucker
Made with Unity 2019.4.20f1
Target device is android mobile with VR mobile headset

This app is designed to give the user a virtual setting of a crowded movie theater. 
This allows those with sensory issues to practice experiencing a crowded and noisy setting in a controlled virtual environment.

INTERACTION
Download the app to you phone (directions below), open the app and place the phone in a mobile VR headset, such as Google Cardboard or similar.
The first screen shows some information about the purpose of the app and contributors. 
If the phone is not oriented when the app starts, the information may not be directly in front. Please look left and right for it.
Pressing the button on your device will load the main menu.
Within the main menu, you can look at the settings, they will turn red when they are looked at.
While looking at a setting, press the button and it will turn green, showing that it is selected.
Then you may look at 'Start' and press the button to load the theater scene with the selected intensity.
You may also look at 'Quit' and press the button to close the app.
Within each theater scene, press the button to return to the main menu.

The intention of the app is to allow someone with sensory overload to gradually experience more visual and auditory stimulus.
This may help reduce sensory overloading in real life scenarios through desensitization using a controlled virtual experience.

DOWNLOADING THE APP
Here are two ways to get the app on an android device. 
Both require the android device to be in developer mode and enable USB debugging.

Put the android device into developer mode, you may have to google for your specific device.
For my device, I navigate through settings and find the model number, and then tap the model number seven times.
Within developer options, enable USB debugging.

The first one is by using Unity's build settings.
With the app open in Unity, go to build settings.
Make sure mobile build is selected, and that your android device has USB debugging enabled
In the build settings, select your device for target device.
Then click 'Build and Run'. 
Once Unity has built the project, it will download the apk file to your phone and run the app.
Now you can place the device in the VR headset and interact with the app.

The second method is to download the apk file directly.
Enable developer mode on your device, and enable USB debugging. 
Also enable file transfer, again you may have to google this option for your specific device.
With file transfer enabled, you will be able to see the contents of your phone in the PC.
Then you can drag the apk file to a convenient folder in the mobile device.
When it is done downloading, disable file transfer.
Navigate to the folder you placed the apk file, and tap on the app.

Either method works, I find it simpler to use Unity, but this does require building the app, which may take a few minutes.

KNOWN ISSUES
The view may not be facing the content if the phone was not oriented when the app starts.
Some of the graphics further away from the camera do not render correctly.
Occasionaly a button tap will register twice, making selections that were not intended.
