using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libInstabug.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks = "OpenGLES CoreLocation SystemConfiguration CFNetwork CoreTelephony AudioToolbox")]

