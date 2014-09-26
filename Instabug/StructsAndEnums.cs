using System;

namespace MonoTouch.Instabug
{
	public enum InstabugFeedbackEvent {
		None,
		Shake,
		Screenshot,
		TwoFingersSwipeLeft,
		RightEdgePan,
		FloatingButton
	}

	public enum InstabugCaptureSource {
		UIKit,
		OpenGL
	}

	public enum InstabugColorTheme {
		Black,
		Grey,
		Orange,
		Red,
		Navy,
		Green,
		Cyan,
		Blue,
		FlatWhite,
		FlatGrey,
		FlatBlack,
		FlatBlue,
		FlatRed,
		FlatGreen
	}

}

