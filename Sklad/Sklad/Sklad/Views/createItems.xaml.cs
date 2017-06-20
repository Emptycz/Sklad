using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad.Views;
using Sklad;
using Sklad.Database;
using Sklad.Constructors;

namespace Sklad.Views
{
    //  [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class createItems : ContentPage
    {
        private ItemC to_write = new ItemC("", "", false, "");

        public createItems()
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

        private void Brench_TextChanged(object sender, TextChangedEventArgs e)
        {
            to_write.Brench = Brench.Text;
        }

        private void Available_Toggled(object sender, ToggledEventArgs e)
        {
            to_write.Available = Available.IsToggled;
        }


        private void Continue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sklad.Views.ChooseElements(to_write), false);
        }

    }
}