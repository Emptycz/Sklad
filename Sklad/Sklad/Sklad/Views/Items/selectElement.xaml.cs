using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad.Views;
using Sklad.Database;
using Sklad.Constructors;

namespace Sklad.Views.Items
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class selectElement : ContentPage
    {
        ItemC item2 = new ItemC("", "", true, "");
        public selectElement(ItemC item)
        {
            InitializeComponent();

            item2 = item;
            List<Elements> ElementsCount = App.Database.GetElementsAsync().Result;
            foreach (Elements elementy in ElementsCount) {

                int ElementCount = ElementsCount.Count;
                for (int i = 0; i == ElementCount; i++)
                {
                    Label label = new Label();
                    label.Text = elementy.Name;

                    Switch switcherino = new Switch();
              

                }

            }
        }

        private void continue_Clicked(object sender, EventArgs e)
        {

           // Navigation.PushAsync(new Sklad.Views.addItem(item2, multiPage), false);
        }
    }
}
