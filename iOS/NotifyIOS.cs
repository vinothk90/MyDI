using System;
using UIKit;
using Xamarin.Forms;

namespace MyDI.iOS
{
	public class NotifyIOS : NotificationInterface
	{
		public NotifyIOS()
		{
			
		}

		public void Alertmsg(DIModel tm)
		{
			UIAlertView alert = new UIAlertView()
			{
				Title = tm.title,
				Message = tm.message
			};
			alert.AddButton("OK");
			alert.Show();
		}
}
}


