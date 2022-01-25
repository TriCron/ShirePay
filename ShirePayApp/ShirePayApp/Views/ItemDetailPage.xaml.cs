using ShirePayApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShirePayApp.Views
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