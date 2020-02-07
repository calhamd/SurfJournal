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
    public class JournalEntriesViewModel : BaseViewModel
    {
        public IDataStore<JournalEntry> DataStore => DependencyService.Get<IDataStore<JournalEntry>>();
        public ObservableCollection<JournalEntry> JournalEntries { get; set; }
        public Command LoadItemsCommand { get; set; }

        public JournalEntriesViewModel()
        {
            Title = "Journal Entries";
            JournalEntries = new ObservableCollection<JournalEntry>
            {
                new JournalEntry()
                {
                    Name="First Surf"
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