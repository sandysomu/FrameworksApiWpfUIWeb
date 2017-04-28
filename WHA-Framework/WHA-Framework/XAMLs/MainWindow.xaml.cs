using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WHA_Framework.Annotations;
using WHA_Framework.Common.StepLibrary;
using WHA_Framework.DataMappings;
using WHA_Framework.DBUtilities;
using WHA_Framework.DBUtilities.DTOs;
using WHA_Framework.DBUtilities.SqliteDB;

namespace WHA_Framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window//, INotifyPropertyChanged
    {
        private IDataMapper _dataMapper;

        public MainWindow()
        {
            InitializeComponent();
            _dataMapper = new DataMapper();
        }


        public void FinanceListComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();

            using (var db = new FrameworkDBEntities())
            {
                var comboBox = sender as ComboBox;
                data = (from g in db.tblBanks select g.BankName).ToList();
                comboBox.ItemsSource = data;
                comboBox.SelectedIndex = 0;
                db.Dispose();
            }

        }

        private void TransTypeComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            using (var db = new FrameworkDBEntities())
            {
                var comboBox = sender as ComboBox;
                data = (from g in db.tblTransactionTypes select g.TransactionTypeName).ToList();
                comboBox.ItemsSource = data;
                comboBox.SelectedIndex = 0;
                db.Dispose();
            }
        }



        private void AccountNameCombo_OnLoaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            using (var db = new FrameworkDBEntities())
            {
                var comboBox = sender as ComboBox;
                data = (from g in db.tblAccountNames select g.ACname).ToList();
                comboBox.ItemsSource = data;
                comboBox.SelectedIndex = 0;
                db.Dispose();
            }

        }

        public void TransButton_Click(object sender, RoutedEventArgs e)
        {
            //var tab = new tblTransaction() {};

            var tsy = new Transactions()
                .GetBankName(FinanceListComboBox.SelectedItem.ToString())
                .GetTransactionType(TransTypeComboBox.SelectedItem.ToString())
                .getTransDesc(TransReasonTextBox.Text)
                .getAcName(AccountNameCombo.SelectedItem.ToString())
                .getAmount(Convert.ToDouble(AmountTextBox.Text))
                .getDate(DateTime.Now);

            //  _dataMapper.Map<Transactions, tblTransaction>(tsy);

            TableChanges.updateTblTransactions(tsy);
        }


























        private void CommonWealthButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }









    //public event PropertyChangedEventHandler PropertyChanged;

    //[NotifyPropertyChangedInvocator]
    //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}

    //private Visibility _balancePageVisible = Visibility.Collapsed;
    //public Visibility BalancePageVisible
    //{
    //    get { return _balancePageVisible; }
    //    set
    //    {
    //        _balancePageVisible = value;
    //        OnPropertyChanged();
    //    }
    //}

    //private void CommonWealthButton_Click(object sender, RoutedEventArgs e)
    //{
    //    BalancePageVisible = Visibility.Visible;
    //}

    //private void Button_Click(object sender, RoutedEventArgs e)
    //{
    //    BalancePageVisible = Visibility.Collapsed;
    //}
}



