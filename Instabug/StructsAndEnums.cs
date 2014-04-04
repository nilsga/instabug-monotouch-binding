using System;

namespace Instabug
{
	public enum InstabugFeedbackEvent {
		Shake,
		Screenshot,
		ThreeFingersSwipe,
		None,
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

