using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libInstabug.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, 
	ForceLoad = true, 
	LinkerFlags = "-lc++",
	Frameworks = "CoreMotion MobileCoreServices CoreTelephony CoreLocation AVFoundation AudioToolbox QuartzCore SystemConfiguration MessageUI OpenGLES GLKit UIKit CoreGraphics CoreFoundation Foundation")]

