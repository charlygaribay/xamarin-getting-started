using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chart.Models;
using Xamarin.Forms;

namespace Chart.Doughnut
{
    public class DoughnutViewModel
    {
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