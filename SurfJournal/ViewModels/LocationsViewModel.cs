using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using SurfJournal.Models;
using SurfJournal.Views;
using SurfJournal.Services;

namespace SurfJournal.ViewModels
{
    public class LocationsViewModel : BaseViewModel
    {
        public IDataStore<SurfLocation> DataStore => DependencyService.Get<IDataStore<SurfLocation>>();
        public ObservableCollection<SurfLocation> Locations { get; set; }
        public Command LoadItemsCommand { get; set; }

        public LocationsViewModel()
        {
            Title = "Locations";
            Locations = new ObservableCollection<SurfLocation>
            {
                new SurfLocation()
                {
                    Name="Baldy"
                }
            };
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());           
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                /*Locations.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Locations.Add(item);
                }*/
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}