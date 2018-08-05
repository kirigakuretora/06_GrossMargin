using System;
using System.Windows;
using WpfApp.View;
using WpfApp.Library.Models;

namespace WpfApp
{

    public partial class MainWindow : Window
    {
        #region 0.Global Variable
        Accountant AC = new Accountant();
        #endregion

        #region 1.Load
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewDetailsDialog_Click(Object sender, RoutedEventArgs e)
        {
            var Details = new DetailsDialog();
            if (Details.ShowDialog()==true)
            {
                Revenue.Text = String.Format("{0}", Details.Revenue);
                CGOS.Text = String.Format("{0}", Details.CGOS);
                Percent.Text =String.Format("{0}",Details.Percent);
                Result.Text= String.Format("{0}", AC.GrossMargin(Details.Revenue, Details.CGOS, Details.Percent));
            }
        }

        private void Exit_Click(Object sender, RoutedEventArgs e)
        {
            Close();
        }
        #endregion
    }
}
