using LiveCharts;
using LiveCharts.Wpf;
using Moneyfly_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Moneyfly_WPF.Views
{
    public partial class PieChartView : UserControl
    {
        private PieChartViewModel mainViewModel;

        public PieChartView(PieChartView mainViewModel)
        {
            InitializeComponent();
        }

        

        private void SilverwareForkKnife_btn(object sender, RoutedEventArgs e)
        {
            
        }

        private void Expence_Btn(object sender, RoutedEventArgs e)
        {

        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
