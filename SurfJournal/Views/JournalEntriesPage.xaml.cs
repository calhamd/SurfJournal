using SurfJournal.Models;
using SurfJournal.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SurfJournal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JournalEntriesPage : ContentPage
    {
        JournalEntriesViewModel viewModel;        

        public JournalEntriesPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new JournalEntriesViewModel();                                   
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
