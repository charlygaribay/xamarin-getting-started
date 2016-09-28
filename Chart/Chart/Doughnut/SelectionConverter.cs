using Chart.Models;
using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chart.Doughnut
{
    public class SelectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var args = (ChartSelectionEventArgs)value;
            var accounts = args.SelectedSeries.ItemsSource.GetEnumerator();

            for (int i = 0; i < args.SelectedDataPointIndex; i++)
                accounts.MoveNext();

            return (Account)accounts.Current;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
