using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using CowboyCafe.Data;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private CashDrawer cd;
        private OrderControl oc;
        private Order ord;
        public double Subtotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public TransactionControl(CashDrawer dc, OrderControl co)
        {
            DataContext = this;
            InitializeComponent();
            cd = dc;
            oc = co;
            ord = oc.DataContext as Order;
            Subtotal = ord.Subtotal;
            Tax = Math.Round(ord.Tax, 2);
            Total = Math.Round(ord.Total, 2);
            CashPay.IsEnabled = false;
            LeftToPay = Total;
            foreach(IOrderItem i in ord.Items)
            {
                OrderList.Items.Add(i.ToString());
                PriceBox.Items.Add(i.Price.ToString("C2"));
                foreach(string s in i.SpecialInstructions)
                {
                    OrderList.Items.Add(s);
                    PriceBox.Items.Add("");
                }
            }
            OrderNum.Text = "Order# " + ord.OrderNumber.ToString();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
 
        public int Pennies { get; set; }
        public int Nickels { get; set; }
        public int Dimes { get; set; }
        public int Quarters { get; set; }
        public int HalfDollars { get; set; }
        public int Dollars { get; set; }
        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Fives { get; set; }
        public int Tens { get; set; }
        public int Twenties { get; set; }
        public int Fifties { get; set; }
        public int Hundreds { get; set; }
        public double Paid { get; set; }
        public double LeftToPay { get; set; }

        private void ChangeOfProperty(string propertyName)
        {
            switch (propertyName)
            {
                case "Pennies":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
                    break;
                case "Nickels":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
                    break;
                case "Dimes":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
                    break;
                case "Quarters":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
                    break;
                case "HalfDollars":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
                    break;
                case "Dollars":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                    break;
                case "Ones":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                    break;
                case "Twos":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
                    break;
                case "Fives":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
                    break;
                case "Tens":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
                    break;
                case "Twenties":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
                    break;
                case "Fifties":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
                    break;
                case "Hundreds":
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
                    break;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LeftToPay"));
        }
        private void ButtClick(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            switch (((Button)sender).Name)
            {
                case "IncreasePennies":
                    Pennies++;
                    Paid += 0.01;
                    LeftToPay -= 0.01;
                    ChangeOfProperty("Pennies");
                    break;
                case "IncreaseNickels":
                    Nickels++;
                    Paid += 0.05;
                    LeftToPay -= 0.05;
                    ChangeOfProperty("Nickels");
                    break;
                case "IncreaseDimes":
                    Dimes++;
                    Paid += 0.10;
                    LeftToPay -= 0.10;
                    ChangeOfProperty("Dimes");
                    break;
                case "IncreaseQuarters":
                    Quarters++;
                    Paid += 0.25;
                    LeftToPay -= 0.25;
                    ChangeOfProperty("Quarters");
                    break;
                case "IncreaseHalfDollars":
                    HalfDollars++;
                    Paid += 0.50;
                    LeftToPay -= 0.50;
                    ChangeOfProperty("HalfDollars");
                    break;
                case "IncreaseDollars":
                    Dollars++;
                    Paid += 1.00;
                    LeftToPay -= 1.00;
                    ChangeOfProperty("Dollars");
                    break;
                case "IncreaseOnes":
                    Ones++;
                    Paid += 1.00;
                    LeftToPay -= 1.00;
                    ChangeOfProperty("Ones");
                    break;
                case "IncreaseTwos":
                    Twos++;
                    Paid += 2;
                    LeftToPay -= 2;
                    ChangeOfProperty("Twos");
                    break;
                case "IncreaseFives":
                    Fives++;
                    Paid += 5;
                    LeftToPay -= 5;
                    ChangeOfProperty("Fives");
                    break;
                case "IncreaseTens":
                    Tens++;
                    Paid += 10;
                    LeftToPay -= 10;
                    ChangeOfProperty("Tens");
                    break;
                case "IncreaseTwenties":
                    Twenties++;
                    Paid += 20;
                    LeftToPay -= 20;
                    ChangeOfProperty("Twenties");
                    break;
                case "IncreaseFifties":
                    Fifties++;
                    Paid += 50;
                    LeftToPay -= 50;
                    ChangeOfProperty("Fifties");
                    break;
                case "IncreaseHundreds":
                    Hundreds++;
                    Paid += 100;
                    LeftToPay -= 100;
                    ChangeOfProperty("Hundreds");
                    break;
                case "DecreasePennies":
                    if (Pennies != 0)
                    {
                        Pennies--;
                        Paid -= 0.01;
                        LeftToPay += 0.01;
                        ChangeOfProperty("Pennies");
                    }
                    break;
                case "DecreaseNickels":
                    if (Nickels != 0)
                    {
                        Nickels--;
                        Paid -= 0.05;
                        LeftToPay += 0.05;
                        ChangeOfProperty("Nickels");
                    }
                    break;
                case "DecreaseDimes":
                    if (Dimes != 0)
                    {
                        Dimes--;
                        Paid -= 0.10;
                        LeftToPay += 0.10;
                        ChangeOfProperty("Dimes");
                    }
                    break;
                case "DecreaseQuarters":
                    if (Quarters != 0)
                    {
                        Quarters--;
                        Paid -= 0.25;
                        LeftToPay += 0.25;
                        ChangeOfProperty("Quarters");
                    }
                    break;
                case "DecreaseHalfDollars":
                    if (HalfDollars != 0)
                    {
                        HalfDollars--;
                        Paid -= 0.50;
                        LeftToPay += 0.50;
                        ChangeOfProperty("HalfDollars");
                    }
                    break;
                case "DecreaseDollars":
                    if (Dollars != 0)
                    {
                        Dollars--;
                        Paid -= 1;
                        LeftToPay += 1;
                        ChangeOfProperty("Dollars");
                    }
                    break;
                case "DecreaseOnes":
                    if (Ones != 0)
                    {
                        Ones--;
                        Paid -= 1;
                        LeftToPay += 1;
                        ChangeOfProperty("Ones");
                    }
                    break;
                case "DecreaseTwos":
                    if (Twos != 0)
                    {
                        Twos--;
                        Paid -= 2;
                        LeftToPay += 2;
                        ChangeOfProperty("Twos");
                    }
                    break;
                case "DecreaseFives":
                    if (Fives != 0)
                    {
                        Fives--;
                        Paid -= 5;
                        LeftToPay += 5;
                        ChangeOfProperty("Fives");
                    }
                    break;
                case "DecreaseTens":
                    if (Tens != 0)
                    {
                        Tens--;
                        Paid -= 10;
                        LeftToPay += 10;
                        ChangeOfProperty("Tens");
                    }
                    break;
                case "DecreaseTwenties":
                    if (Twenties != 0)
                    {
                        Twenties--;
                        Paid -= 20;
                        LeftToPay += 20;
                        ChangeOfProperty("Twenties");
                    }
                    break;
                case "DecreaseFifties":
                    if (Fifties != 0)
                    {
                        Fifties--;
                        Paid -= 50;
                        LeftToPay += 50;
                        ChangeOfProperty("Fifties");
                    }
                    break;
                case "DecreaseHundreds":
                    if (Hundreds != 0)
                    {
                        Hundreds--;
                        Paid -= 100;
                        LeftToPay += 100;
                        ChangeOfProperty("Hundreds");
                    }
                    break;
                case "CancelPay":
                    NewOrder();
                    break;
                case "CardPay":
                    NewOrder();
                    break;
                case "CashPay":
                    foreach(Coins c in Enum.GetValues(typeof(Coins)) as Coins[])
                    {
                        int n = 0;
                        switch (c)
                        {
                            case Coins.Penny:
                                n = Pennies;
                                break;
                            case Coins.Nickel:
                                n = Nickels;
                                break;
                            case Coins.Dime:
                                n = Dimes;
                                break;
                            case Coins.Quarter:
                                n = Quarters;
                                break;
                            case Coins.HalfDollar:
                                n = HalfDollars;
                                break;
                            case Coins.Dollar:
                                n = Dollars;
                                break;
                        }
                        cd.AddCoin(c, n);
                    }
                    foreach (Bills c in Enum.GetValues(typeof(Bills)) as Bills[])
                    {
                        int n = 0;
                        switch (c)
                        {
                            case Bills.One:
                                n = Ones;
                                break;
                            case Bills.Two:
                                n = Twos;
                                break;
                            case Bills.Five:
                                n = Fives;
                                break;
                            case Bills.Ten:
                                n = Tens;
                                break;
                            case Bills.Twenty:
                                n = Twenties;
                                break;
                            case Bills.Fifty:
                                n = Fifties;
                                break;
                            case Bills.Hundred:
                                n = Hundreds;
                                break;
                        }
                        cd.AddBill(c, n);
                    }
                    if (LeftToPay < 0)
                    {

                    }
                    NewOrder();
                    break;
            }
            if (LeftToPay <= 0) CashPay.IsEnabled = true;
            else CashPay.IsEnabled = false;
            if (Paid != 0) CardPay.IsEnabled = false;
            else CardPay.IsEnabled = true;
        }

        private void NewOrder()
        {
            var main = this.FindAncestor<MainWindow>();
            oc.DataContext = new Order();
            oc.Container.Child = new MenuItemSelectionControl();
            main.Container.Child = oc;
        }
    }
}
