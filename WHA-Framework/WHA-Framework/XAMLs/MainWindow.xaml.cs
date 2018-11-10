using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Autofac;
using EntityDatabase.Common;
using EntityDatabase.DataModel;
using WpfApplication.Conversion;
using WpfApplication.IoC;
using WpfApplication.Services;
using Transaction = EntityDatabase.DTOs.Transaction;

namespace WpfApplication.XAMLs
{

    public partial class MainWindow : Window
    {

        private readonly IBankingService _bankingService;
        private readonly IUpdateDbTables _tblUpdate;
        private readonly ITransactionService _transactionService;
        private readonly ObjectConversions _objectConversions;
        private readonly InitiateDataUpdate _initiateDataUpdate;



        public MainWindow()
        {
            InitializeComponent();
            _bankingService = IocConfiguration.Initialize().Resolve<IBankingService>();
            _tblUpdate = IocConfiguration.Initialize().Resolve<IUpdateDbTables>();
            _transactionService = IocConfiguration.Initialize().Resolve<ITransactionService>();
            _objectConversions = IocConfiguration.Initialize().Resolve<ObjectConversions>();
            _initiateDataUpdate = IocConfiguration.Initialize().Resolve<InitiateDataUpdate>();
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
            var transaction = new Transaction
            {
                BankId = _bankingService.GetBankingInfo(FinanceListComboBox.SelectedItem.ToString()).BankId,
                ACnameID = _bankingService.GetAcNameInfo(AccountNameCombo.SelectedItem.ToString()).ACnameID,
                TranstionTypeId = _bankingService.GetTransTypeInfo(TransTypeComboBox.SelectedItem.ToString())
                    .TransactionTypeId,
                Amount = (Convert.ToDouble(AmountTextBox.Text)),
                TransDesc = TransReasonTextBox.Text,
                Date = DateTime.Now
            };

            _initiateDataUpdate.UpdateTblTransaction(transaction);
            _initiateDataUpdate.UpdateTblEntity(_objectConversions.ConvertTransactionToEachEntityTran(transaction));
        }

        private void CommonWealthButton_Click(object sender, RoutedEventArgs e)
        {
            EntityDetails.ItemsSource = _transactionService.GetTransactionforEachEntity("Commonwealth");
        }

        private void HSBCButton_Click(object sender, RoutedEventArgs e)
        {
            EntityDetails.ItemsSource = _transactionService.GetTransactionforEachEntity("HSBC");
        }

        private void CitiButton_Click(object sender, RoutedEventArgs e)
        {
            EntityDetails.ItemsSource = _transactionService.GetTransactionforEachEntity("City Bank");
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            EntityDetails.ItemsSource = _transactionService.GetTransactionforEachEntity("Select Union");
        }

        private void AllBankButton_Click(object sender, RoutedEventArgs e)
        {
            EntityDetails.ItemsSource = _transactionService.GetAllTransaction();
        }
    }
}



