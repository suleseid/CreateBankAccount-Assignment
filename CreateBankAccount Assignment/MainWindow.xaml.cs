using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
namespace CreateBankAccount_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int year = 3000;
        ObservableCollection<Account> accounts = new ObservableCollection<Account>();
        private Account account;
        private string lName;
        private decimal amount;
        private decimal overdraftFee;
        private readonly string fName;

        public decimal interest { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            lbYear.Content = year.ToString();

            lbAccount.ItemsSource = accounts;
            accounts.Add(new Account(fName, lName, amount));
            Preload();
        }

        private void Preload()
        {
            accounts.Add(new Account(fName, lName, amount));
            accounts.Add(new SavingsAccount(fName, lName, amount, interest));
            accounts.Add(new CheckingAccount(fName, lName, amount, overdraftFee));
         
        }

        //Lets add a new account to our account 
        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtBoxfName.Text;
            string lName = txtBoxlName.Text;
            decimal amount = ValidateMoney(txtBoxBalance.Text);

            //Account account = new Account(fName, lName, amount);//
          /*  CheckingAccount acccount = new checkingAccount (fName, lName, amount);
            accounts.Add(account);*/
        }

        private decimal ValidateMoney(string text)
        {
            throw new NotImplementedException();
        }

        private void btnDeposit_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = ValidateMoney(txtAmount.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = ValidateMoney(txtAmount.Text);
        }

        private void btnAdvanceYear_Click(object sender, RoutedEventArgs e)
        {
            lbYear.Content = year++ + "";
        }

        private void btnWithdrow_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = ValidateMoney(txtAmount.Text);
            //Validated if account is sellected
            if(lbAccount.SelectedIndex != -1)
            {
                int index = lbAccount.SelectedIndex;
                Account Id = accounts[index];

                Id.Withdrow(amount);
                MessageBox.Show(accounts.Id.ToString());

            }
        }
    }
}
