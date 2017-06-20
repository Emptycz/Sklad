using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad;
using Sklad.Views;
using SQLite;
using Sklad.Database;
using Sklad.Constructors;

namespace Sklad.Views
{
    //   [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class deletePage : ContentPage
    {
        public deletePage(Item item)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            DeleteMe(item);
        }

        private void DeleteMe(Item ToDelete)
        {
            App.Database.DeleteItemAsync(ToDelete);
            Navigation.PushAsync(new Sklad.MainPage(), false);
        }
    }
}