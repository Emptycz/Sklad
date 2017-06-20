using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sklad;
using Sklad.Constructors;
using Sklad.Views;
using Sklad.Database;

namespace Sklad.Views
{
  //  [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseElements : ContentPage
    {
        private ItemC itemc = new ItemC("", "",true, "");
        private ElementC element = new ElementC("", "");
        private int pom;
        public ChooseElements(ItemC item)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            itemc = item;
            /*element.Name = el.Name;
            element.Description = el.Description;*/

        }
            SelectMultipleBasePage<CheckItem> multiPage;
        async void OnClick(object sender, EventArgs ea)
        {
            var items = new List<CheckItem>();
            List<Elements> itemsFromDb = App.Database.GetCountElements().Result;
            int listcount = itemsFromDb.Count;

            for (int i = 0; i == listcount; i++ ) {
                items.Add(new CheckItem { Name = element.Name});
            }
                if (multiPage == null)
                    multiPage = new SelectMultipleBasePage<CheckItem>(items) { Title = "Check all that apply" };

                await Navigation.PushAsync(multiPage);
                
        }

        private List<CheckItem> answers;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (multiPage != null)
            {
                results.Text = "";
                answers = multiPage.GetSelection();
                foreach (var a in answers)
                {
                    Navigation.PushAsync(new addItem(itemc, answers), false);
                }
            }
            else
            {
                //
            }
        } 

    }
}