using System;
using System.Windows;

using WpfApp.Properties;

namespace WpfApp.View
{
    using System.Windows.Input;
    public partial class DetailsDialog : Window
    {
        #region 0.Global Variable
        public Decimal Revenue { get; set; }
        public Decimal CGOS { get; set; }
        public Decimal Percent { get; set; }
        #endregion

        #region 1.Load
        public DetailsDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(Object sender, RoutedEventArgs e)
        {
            Revenue = Convert.ToDecimal(tbRevenue.Text);
            CGOS = Convert.ToDecimal(tbCGOS.Text);
            Percent = Convert.ToDecimal(tbPercent.Text);
            DialogResult = true;
            Close();
        }

        private void CommandBinding_CanExecute(Object Sender, CanExecuteRoutedEventArgs E)
        {
            E.CanExecute = true;
        }

        private void CommandBinding_Executed(Object Sender, ExecutedRoutedEventArgs E)
        {
            DialogResult = false;
            Close();
        }
        #endregion

    }
}
