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
    public class SurfBoardsViewModel : BaseViewModel
    {
        public IDataStore<Surfboard> DataStore => DependencyService.Get<IDataStore<Surfboard>>();
        public ObservableCollection<Surfboard> Quiver { get; set; }
        public Command LoadItemsCommand { get; set; }

        public SurfBoardsViewModel()
        {
            Title = "Surfboards";
            Quiver = new ObservableCollection<Surfboard>
            {
                new Surfboard()                
                {
                    Name="EarthBoard"
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