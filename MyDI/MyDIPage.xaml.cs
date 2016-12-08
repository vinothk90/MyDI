using Xamarin.Forms;

namespace MyDI
{
	public partial class MyDIPage : ContentPage
	{
		
		public MyDIPage()
		{
			InitializeComponent();
			BindingContext = new DIViewModel();

		}


	}
}

