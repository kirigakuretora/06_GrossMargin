using System;
using System.Windows;

namespace WpfApp.View
{
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

        private void Close_Click(Object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        #endregion
    }
}
