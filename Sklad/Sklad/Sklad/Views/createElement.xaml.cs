using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad.Constructors;
using Sklad;
using Sklad.Views;
using Sklad.Views;

namespace Sklad.Views
{
   // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class createElement : ContentPage
    {
        ElementC to_write = new ElementC("", "");
        public createElement()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            //    NameText = Name.Text;
            to_write.Name = Name.Text;
        }

        private void Description_TextChanged(object sender, TextChangedEventArgs e)
        {
            //    DescriptionText = Description.Text;
            to_write.Description = Description.Text;
        }

        private void Continue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sklad.Views.addElement(to_write), false);
        }
    }
}