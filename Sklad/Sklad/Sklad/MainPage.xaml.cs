using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad.Database;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad.Views;
using Sklad;

namespace Sklad
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        private void selectedItemMethod(object sender, ItemTappedEventArgs e)
        {
            // Grab ListView Item as Person object and send it as parameter to constructor of InfoPage
            Navigation.PushAsync(new Sklad.Views.detailsPage(e.Item as Item));
        }

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            redirection.Clicked += (s, e) => {
                Navigation.PushAsync(new Sklad.Views.createItems(), true);
            };
            
            
            var itemsFromDb = App.Database.GetItemsBy().Result;
            mainList.ItemsSource = itemsFromDb;

            mainList.ItemsSource = App.Database.GetItemsAsync().Result;
            mainList.ItemTapped += (s, e) =>
            {
                Navigation.PushAsync(new Sklad.Views.detailsPage(e.Item as Item), true);
            };
        }

        private void EditItem_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
          /*  var pom = ((e.SelectedItem) as Item);
            mainList.ItemsSource = App.Database.GetItemsAsync().Result;
            //mainList.ItemTapped += (s, e) =>
            //{
            Navigation.PushAsync(new Sklad.Views.editItem(pom), true);
            //};*/
        }

        private void DeleteItem_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
          /*  
            var pom = ((e.SelectedItem) as Item);
            OnAlertYesNoClicked(sender, e, pom);
            mainList.ItemsSource = App.Database.GetItemsAsync().Result;
              mainList.ItemsSource = App.Database.GetItemsAsync().Result;
              mainList.ItemTapped += (s, e) =>
              {
                  Navigation.PushAsync(new Sklad.Views.Items.deletePage(pom), false);
             // };*/
        }
        /* async void OnAlertYesNoClicked(object sender, EventArgs e, Item pom)
{
    var answer = await DisplayAlert("", "Do you really want to delete this event?", "Yes", "No");
    if (answer)
    {
        await Navigation.PushAsync(new Sklad.Views.Items.deletePage(pom), true);
    }

}
*/
    }
}