﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad.Database;
using Sklad.Constructors;
using Sklad.Views;
using Sklad;
using SQLite;
using Application = Xamarin.Forms.Application;
using Debug = System.Diagnostics.Debug;
using Sklad.Views.Items;

namespace Sklad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addItem : ContentPage
    {
        private static List<int> contains = new List<int>();
        private ItemC final_item = new ItemC("", "", false, "");
        private ItemC event_edit = new ItemC(1,"", "", false, "", false);

        private int event_ID;
        public addItem(ItemC to_write, SelectMultipleBasePage<CheckItem> multiPage)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            if (to_write.Edit == false)
            {
                final_item.Brench = to_write.Brench;
                final_item.Name = to_write.Name;
                final_item.Description = to_write.Description;
                final_item.Available = to_write.Available;

                if (final_item.Name == "")
                {
                    final_item.Name = "Nebyl zadán název";
                }

                if (final_item.Description == "")
                {
                    final_item.Description = "Nebyl zadán žádný popisek";
                }

                var dbConnection = App.Database;

                ItemDatabase ItemDatabase = App.Database;
                Item item = new Item();
                item.Name = final_item.Name;
                item.Available = final_item.Available;
                item.Description = final_item.Description;
                App.Database.SaveItemAsync(item);
            }
            else
            {
                final_item.ID = to_write.ID;
                final_item.Name = to_write.Name;
                final_item.Description = to_write.Description;
                final_item.Available = to_write.Available;

                ItemDatabase ItemDatabase = App.Database;
                Item item = new Item();

                item.ID = final_item.ID;
                item.Name = final_item.Name;
                item.Available = final_item.Available;
                item.Description = final_item.Description;
                App.Database.SaveItemAsync(item);
            }
        }

  /*      private void ShowNotifi(DateTime date)
        {

            List<Item> itemsFromDb = App.Database.GetLastID().Result;
            foreach (Item i in itemsFromDb)
            {
                int uID = i.ID;
                Debug.WriteLine(date);
                CrossLocalNotifications.Current.Show(final_item.Name, final_item.Description, uID, final_item.TimeC);
            }
        }
        */


        private void RedirectHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sklad.MainPage(), false);
        }
    }
}