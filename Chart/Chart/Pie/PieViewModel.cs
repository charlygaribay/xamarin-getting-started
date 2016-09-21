using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chart.Models;
using Xamarin.Forms;

namespace Chart.Pie
{
    public class PieViewModel
    {
        public ObservableCollection<Account> Accounts { get; set; }

        public List<Color> Colors { get; set; }

        public PieViewModel()
        {
            Accounts = new ObservableCollection<Account>();
            Accounts.Add(new Account { Description = "Checking 1", Amount = 1000 });
            Accounts.Add(new Account { Description = "Checking 2", Amount = 2000 });
            Accounts.Add(new Account { Description = "Checking 3", Amount = 3000 });
            Accounts.Add(new Account { Description = "Checking 5", Amount = 5000 });
            Accounts.Add(new Account { Description = "Checking 8", Amount = 8000 });
            Accounts.Add(new Account { Description = "Checking 13", Amount = 13000 });

            Colors = new List<Color>();
            Colors.Add(Color.FromHex("#a3e1d4"));
            Colors.Add(Color.FromHex("#dedede"));
            Colors.Add(Color.FromHex("#b5b8cf"));
        }
    }
}