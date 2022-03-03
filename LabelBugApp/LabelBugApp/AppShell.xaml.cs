using LabelBugApp.ViewModels;
using LabelBugApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LabelBugApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
