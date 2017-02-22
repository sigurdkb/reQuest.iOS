using System;
using CoreGraphics;
using Foundation;
using UIKit;
using WebKit;

namespace reQuest.iOS
{
	public partial class ViewController : UIViewController, IWKNavigationDelegate, IWKScriptMessageHandler
	{

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

			var config = new WKWebViewConfiguration();
			config.UserContentController.AddScriptMessageHandler(this, "native");

			//WKWebView webView = new WKWebView(new CGRect(0, 20, View.Frame.Width, View.Frame.Height - 20), config);
			UIWebView webView = new UIWebView(new CGRect(0, 20, View.Frame.Width, View.Frame.Height - 20));
			View.AddSubview(webView);

			var url = new NSUrl("http://agder-ikt85.uia.no");
			var request = new NSUrlRequest(url);
			//webView.NavigationDelegate = this;
			//webView.AllowsBackForwardNavigationGestures = true;
			webView.ScalesPageToFit = true;
			webView.LoadRequest(request);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		public void DidReceiveScriptMessage(WKUserContentController userContentController, WKScriptMessage message)
		{
			throw new NotImplementedException();
		}
	}
}
