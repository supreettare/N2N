using Microsoft.WindowsAzure.MobileServices;
using System;

using Xamarin.Forms;

namespace N2NSample
{
	public class App : Application
	{
        //MobileServiceClient client = new MobileServiceClient(Constants.ApplicationURL);
        MobileServiceClient client = new MobileServiceClient(Constants.ApplicationURL);

        public App ()
		{
			// The root page of your application
			MainPage = new TodoList();
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

