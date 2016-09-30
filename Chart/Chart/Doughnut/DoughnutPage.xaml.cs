using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Chart.Doughnut
{
    public partial class DoughnutPage : ContentPage
    {
        private DoughnutViewModel viewModel;

        public DoughnutPage()
        {
            InitializeComponent();

            viewModel = new DoughnutViewModel();
            BindingContext = viewModel;
        }

        private void OnSelectionChanged(object sender, ChartSelectionEventArgs args)
        {

        }
    }
}
