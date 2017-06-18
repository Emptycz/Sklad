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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class editItem : ContentPage
    {
        private static List<int> contains = new List<int>();
        private ItemC item_update = new ItemC(1, "", "", false, "", true);
        public editItem(Item item)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            List<Item> ItemsSource = App.Database.GetItemsAsync().Result;
            foreach (Item i in ItemsSource)
            {
              /*  Name.Text = i.Name;
                Description.Text = i.Description;*/
            }
        }
        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            //    NameText = Name.Text;
           // event2.name = Name.Text;
        }

        private void Description_TextChanged(object sender, TextChangedEventArgs e)
        {
            //    DescriptionText = Description.Text;
            //event2.description = Description.Text;
        }


        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (sender is DatePicker)
            {
             /*   DatePicker datePicker = (DatePicker)sender;
                event2.cas = datePicker.Date;*/
            }

        }

        private void TimePicker_PropertyChanged(object sender, EventArgs e)
        {
            if (sender is TimePicker)
            {
                TimePicker timePicker = (TimePicker)sender;
                TimeSpan time = timePicker.Time;
              //  event2.cas = event2.cas + time;
            }
        }

        private void join_Toggled(object sender, ToggledEventArgs e)
        {
          //  event2.ucast = join.IsToggled;
        }

        private void Continue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sklad.Views.addItem(item_update), false);
        }
    }
}