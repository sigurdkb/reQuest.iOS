using System;
using Foundation;
using UIKit;

namespace reQuest.iOS
{
	public partial class ViewController : UIViewController
	{
		//UIWebView webView;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			Title = "reQuest";
			View.BackgroundColor = UIColor.Black;

			//webView = new UIWebView(View.Bounds);
			//View.AddSubview(webView);

			var url = "http://agder-ikt85.uia.no"; // NOTE: https required for iOS 9 ATS (overidden in info.plist)
			webView.LoadRequest(new NSUrlRequest(new NSUrl(url)));

			// if this is false, page will be 'zoomed in' to normal size
			webView.ScalesPageToFit = true;

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
