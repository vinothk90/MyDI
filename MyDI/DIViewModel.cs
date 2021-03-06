﻿using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyDI
{
	public class DIViewModel: INotifyPropertyChanged
	{
		NotificationInterface notificationInterface;

		public event PropertyChangedEventHandler PropertyChanged;
		public ICommand Onclickbtn { get; private set; }

		public DIViewModel()
		{
			notificationInterface = DependencyService.Get<NotificationInterface>();
			Onclickbtn = new Command(OnBtnClick);
		}


		void OnBtnClick()
		{
			DIModel dim = new DIModel();
			dim.title = "Halo";
			dim.message = "Hi I am from MyDIPage";
			notificationInterface.Alertmsg(dim);
		}
	}
}


