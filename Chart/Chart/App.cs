using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chart
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new Pie.PiePage());
        }
    }
}
