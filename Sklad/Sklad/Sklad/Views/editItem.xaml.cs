using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad.Database;
using Sklad;
using Sklad.Views;
using Sklad.Constructors;
using SQLite;

namespace Sklad.Views
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class editItem : ContentPage
    {
        private string NameText;
        private string DescriptionText;
        private ItemC item_update = new ItemC(1, "", "", false, "", true);
        public editItem(ItemC item)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            item_update.ID = item.ID;
            List<Item> ItemsSource = App.Database.GetItemsAsync().Result;
            foreach (Item i in ItemsSource)
            {
                Name.Placeholder = i.Name;
                Description.Placeholder = i.Description;
                Available.IsEnabled = i.Available;
            }
        }
        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            NameText = Name.Text;
            item_update.Name = Name.Text;
        }

        private void Description_TextChanged(object sender, TextChangedEventArgs e)
        {
            DescriptionText = Description.Text;
            item_update.Description = Description.Text;
        }

        private void join_Toggled(object sender, ToggledEventArgs e)
        {
            item_update.Available = Available.IsToggled;
        }

        private void Continue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sklad.Views.ChooseElements(item_update), false);
        }
    }
}