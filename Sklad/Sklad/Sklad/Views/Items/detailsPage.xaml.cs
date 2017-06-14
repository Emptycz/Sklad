using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad.Database;
using Sklad.Views;
using Sklad;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sklad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detailsPage : ContentPage
    {
        private string ucast;
        public detailsPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private Item ToDelete = new Item();

        public detailsPage(Item item)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            if (item.Available == true)
            {
                ucast = "Item is available!";
            }
            else
            {
                ucast = "Item is not available!";
            }

            nameL.Text = item.Name;
            BrenchL.Text = item.Brench;
            AvailableL.Text = ucast;
            DescriptionL.Text = item.Description;
            TimeCL.Text = item.TimeStamp.Day.ToString() + "." + item.TimeStamp.Month.ToString() + "." + item.TimeStamp.Year.ToString() + " " + item.TimeStamp.Hour.ToString() + ":" + item.TimeStamp.Minute.ToString();
            //ContainsL.Text = item.Contains;
            ToDelete = item;
        }

        private void DeleteObject_Clicked(object sender, EventArgs e)
        {
            OnAlertYesNoClicked(sender, e);
        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("", "Do you really want to delete this event?", "Yes", "No");
            if (answer)
            {
                DeleteMe(ToDelete);
            }

        }

        private void DeleteMe(Item ToDelete)
        {
            App.Database.DeleteItemAsync(ToDelete);
            Navigation.PushAsync(new Sklad.MainPage(), false);
        }

        private void RedirectHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sklad.MainPage(), false);
        }
    }
}