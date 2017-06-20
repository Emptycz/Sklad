using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad.Constructors;
using Sklad.Database;
using SQLite;
using Sklad;


namespace Sklad.Views
{
 //   [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addElement : ContentPage
    {
        private ElementC to_write = new ElementC("", "");
        public addElement(ElementC to_write)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            ItemDatabase ItemDatabase = App.Database;
            Elements final_item = new Elements();
            final_item.Name = to_write.Name;
            final_item.Description = to_write.Description;
            
            App.Database.SaveElementsAsync(final_item);
        }
        private void RedirectHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sklad.MainPage(), false);
        }
    }
}