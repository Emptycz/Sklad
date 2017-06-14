using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklad.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sklad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detailsPage : ContentPage
    {
        public detailsPage(Item item)
        {
            InitializeComponent();
        }
    }
}