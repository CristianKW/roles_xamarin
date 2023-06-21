using roles.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace roles.Views
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