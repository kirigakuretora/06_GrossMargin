using System;
using System.Windows;
using WpfApp.View;
using WpfApp.Library.Models;

namespace WpfApp
{
    using System.Windows.Input;

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
                Result.Text= String.Format("{0}", AC.GrossMargin(Convert.ToDecimal(Details.Revenue), Convert.ToDecimal(Details.CGOS), Convert.ToDecimal(Details.Percent)));
            }
        }

        private void CommandBinding_CanExecute(Object Sender, CanExecuteRoutedEventArgs E)
        {
            E.CanExecute = true;
        }

        private void CommandBinding_Executed(Object Sender, ExecutedRoutedEventArgs E)
        {
            Close();
        }

        #endregion

    }
}
