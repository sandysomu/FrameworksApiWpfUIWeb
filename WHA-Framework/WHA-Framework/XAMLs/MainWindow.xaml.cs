using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using Autofac;
using NUnit.Framework;
using WHA.Framework.Database.Common;
using WHA.Framework.Database.DataMappings;
using WHA.Framework.Database.DataModel;
using WHA_Framework.Conversion;
using WHA_Framework.IoC;
using WHA_Framework.Services;
using WHA_Framework.Utilities;
using Transaction = WHA.Framework.Database.DTOs.Transaction;

namespace WHA_Framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataMapper _dataMapper;
        private readonly IBankingService _bankingService;
        private readonly IUpdateDbTables _tblUpdate;
        private readonly ITransactionService _transactionService;
        private readonly UpdateModel _updateModel;

        public MainWindow()
        {
            InitializeComponent();
            _dataMapper = IocConfiguration.Initialize().Resolve<IDataMapper>();
            _bankingService = IocConfiguration.Initialize().Resolve<IBankingService>(); 
            _tblUpdate = IocConfiguration.Initialize().Resolve<IUpdateDbTables>(); 
            _transactionService = IocConfiguration.Initialize().Resolve<ITransactionService>(); 
            _updateModel = IocConfiguration.Initialize().Resolve<UpdateModel>();
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
            var trans = new Transaction
            {
                BankId = _bankingService.GetBankingInfo(FinanceListComboBox.SelectedItem.ToString()).BankId,
                ACnameID = _bankingService.GetAcNameInfo(AccountNameCombo.SelectedItem.ToString()).ACnameID,
                TranstionTypeId = _bankingService.GetTransTypeInfo(TransTypeComboBox.SelectedItem.ToString())
                    .TransactionTypeId,
                Amount = (Convert.ToDouble(AmountTextBox.Text)),
                TransDesc = TransReasonTextBox.Text,
                Date = DateTime.Now
            };
            _tblUpdate.UpdateTblEntity(_updateModel.test(trans));
            _tblUpdate.UpdateTblTransaction(trans);

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



