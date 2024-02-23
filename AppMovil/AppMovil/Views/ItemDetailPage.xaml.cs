using AppMovil.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppMovil.Views
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