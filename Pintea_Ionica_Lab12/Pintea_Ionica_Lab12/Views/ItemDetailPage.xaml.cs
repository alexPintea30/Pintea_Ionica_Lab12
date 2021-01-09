using System.ComponentModel;
using Xamarin.Forms;
using Pintea_Ionica_Lab12.ViewModels;

namespace Pintea_Ionica_Lab12.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}