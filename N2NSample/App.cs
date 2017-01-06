using Microsoft.WindowsAzure.MobileServices;
using N2NSample.Views;
using System;

using Xamarin.Forms;

namespace N2NSample
{
	public class App : Application
	{
        public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new StudentsPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

