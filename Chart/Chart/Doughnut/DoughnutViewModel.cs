using Chart.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Chart.Doughnut
{
    public class DoughnutViewModel : INotifyPropertyChanged
    {
        #region Chart
        private int Chart_selectionIndex;
        public int Chart_SelectionIndex
        {
            get
            {
                return Chart_selectionIndex;
            }
            set
            {
                Chart_selectionIndex = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region List
        private Account List_selectedItem;
        public Account List_SelectedItem
        {
            get
            {
                return List_selectedItem;
            }
            set
            {
                List_selectedItem = value;

                var index = Accounts.IndexOf(value);
                Chart_SelectionIndex = index;

                OnPropertyChanged();
            }
        }
        #endregion

        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        #endregion

        public ObservableCollection<Account> Accounts { get; set; }

        public List<Color> Colors { get; set; }

        public DoughnutViewModel()
        {
            Accounts = new ObservableCollection<Account>();
            Accounts.Add(new Account { Description = "Checking 1", Amount = 1000 });
            Accounts.Add(new Account { Description = "Checking 2", Amount = 2000 });
            Accounts.Add(new Account { Description = "Checking 3", Amount = 3000 });
            Accounts.Add(new Account { Description = "Checking 5", Amount = 5000 });
            Accounts.Add(new Account { Description = "Checking 8", Amount = 8000 });
            Accounts.Add(new Account { Description = "Checking 13", Amount = 13000 });

            Colors = new List<Color>();
            Colors.Add(Color.FromHex("#D2D4D7"));
        }
    }
}