using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chart.Models;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chart.Doughnut
{
    public class DoughnutViewModel : INotifyPropertyChanged
    {
        private ICommand onSelectionChangedCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Account> Accounts { get; set; }

        public List<Color> Colors { get; set; }

        public string AccountName { get; set; }

        public ICommand OnSelectionChangedCommand
        {
            get
            {
                return onSelectionChangedCommand;
            }

            set
            {
                onSelectionChangedCommand = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string property = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        public DoughnutViewModel()
        {
            OnSelectionChangedCommand = new Command<Account>(OnSelectionChanged);

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

        private void OnSelectionChanged(Account account)
        {
            AccountName = account.Description;
        }
    }
}