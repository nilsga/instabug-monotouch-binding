using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Instabug {

	public delegate void PreSendingCallback();

	[BaseType (typeof (NSObject))]
	public partial interface Instabug {

		[Static, Export ("KickOffWithToken:CaptureSource:FeedbackEvent:IsTrackingLocation:")]
		void KickOffWithToken (string token, InstabugCaptureSource captureSource, InstabugFeedbackEvent feedbackEvent, bool isTrackingLocation);

		[Static, Export ("ShowFeedbackForm")]
		void ShowFeedbackForm ();

		[Static, Export ("ShowFeedbackFormWithScreenshot:")]
		void ShowFeedbackFormWithScreenshot (bool withScreenshot);

		[Static, Export ("disableSDK")]
		void DisableSDK ();

		[Static, Export ("enableSDK")]
		void EnableSDK ();

		[Static, Export ("appIntrospection")]
		bool AppIntrospection { set; }

		[Static, Export ("userDataString")]
		string UserDataString { set; }

		[Static, Export ("showScreenshot")]
		bool ShowScreenshot { set; }

		[Static, Export ("showEmail")]
		bool ShowEmail { set; }

		[Static, Export ("email")]
		string Email { set; }

		[Static, Export ("emailPlaceholder")]
		string EmailPlaceholder { set; }

		[Static, Export ("commentPlaceholder")]
		string CommentPlaceholder { set; }

		[Static, Export ("iPhoneShakingThreshold")]
		double iPhoneShakingThreshold { set; }

		[Static, Export ("iPadShakingThreshold")]
		double iPadShakingThreshold { set; }

		[Static, Export ("preSendingBlock")]
		void setPreSendingCallback (PreSendingCallback callback);

		[Static, Export ("attachFileAtLocation:")]
		void AttachFileAtLocation (string fileLocation);

		[Static, Export ("emailIsRequired")]
		bool EmailIsRequired { set; }

		[Static, Export ("emailInvalidText")]
		string EmailInvalidText { set; }

		[Static, Export ("commentIsRequired")]
		bool CommentIsRequired { set; }

		[Static, Export ("commentInvalidText")]
		string CommentInvalidText { set; }

		[Static, Export ("showStartAlert")]
		bool ShowStartAlert { set; }

		[Static, Export ("startAlertText")]
		string StartAlertText { set; }

		[Static, Export ("showThankYouAlert")]
		bool ShowThankYouAlert { set; }

		[Static, Export ("thankYouAlertText")]
		string ThankYouAlertText { set; }

		[Static, Export ("alertsTitle")]
		string AlertsTitle { set; }

		[Static, Export ("colorTheme")]
		InstabugColorTheme ColorTheme { set; }

		[Static, Export ("headerColor")]
		UIColor HeaderColor { set; }

		[Static, Export ("headerFontColor")]
		UIColor HeaderFontColor { set; }

		[Static, Export ("buttonsColor")]
		UIColor ButtonsColor { set; }

		[Static, Export ("buttonsFontColor")]
		UIColor ButtonsFontColor { set; }

		[Static, Export ("textBackgroundColor")]
		UIColor TextBackgroundColor { set; }

		[Static, Export ("textFontColor")]
		UIColor TextFontColor { set; }

		[Static, Export ("floatingButtonForeColor")]
		UIColor FloatingButtonForeColor { set; }

		[Static, Export ("floatingButtonBackColor")]
		UIColor FloatingButtonBackColor { set; }
	}
}
