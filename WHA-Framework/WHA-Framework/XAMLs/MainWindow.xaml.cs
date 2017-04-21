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

namespace WHA_Framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void FinanceListComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            // List<string> data = new List<string>();

            //using (var db = new WHAprojectDBEntities())
            //{
            //    var comboBox = sender as ComboBox;
            //    data = (from g in db.tblBankLists select g.BankName).ToList();
            //    comboBox.ItemsSource = data;
            //    comboBox.SelectedIndex = 0;
            //    db.Dispose();
            //}

        }

        private void TransTypeComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            //List<string> data = new List<string>();
            //using (var db = new WHAprojectDBEntities())
            //{
            //    var comboBox = sender as ComboBox;
            //    data = (from g in db.tblTransactionTypes select g.TransactionTypeName).ToList();
            //    comboBox.ItemsSource = data;
            //    comboBox.SelectedIndex = 0;
            //    db.Dispose();
            //}
        }



        private void AccountNameCombo_OnLoaded(object sender, RoutedEventArgs e)
        {
            //List<string> data = new List<string>();
            //using (var db = new WHAprojectDBEntities())
            //{
            //    var comboBox = sender as ComboBox;
            //    data = (from g in db.tblAccountNames select g.AccountName).ToList();
            //    comboBox.ItemsSource = data;
            //    comboBox.SelectedIndex = 0;
            //    db.Dispose();
            //}

        }



        public void TransButton_Click(object sender, RoutedEventArgs e)
        {






            //var tsy = new Transactions()
            //    .GetBankName(FinanceListComboBox.SelectedItem.ToString())
            //    .GetTransactionType(TransTypeComboBox.SelectedItem.ToString())
            //    .GetTransactionDescription(TransReasonTextBox.Text)
            //    .GetAccountName(AccountNameCombo.SelectedItem.ToString())
            //    .GetAmount(Convert.ToInt32(AmountTextBox.Text));
        }

        private void AmountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
