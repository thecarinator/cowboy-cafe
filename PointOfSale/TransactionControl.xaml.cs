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
        private double change;
        public double Change { get { return Math.Round(change, 2); } set { change = Math.Abs(value); } }
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
            foreach (IOrderItem i in ord.Items)
            {
                OrderList.Items.Add(i.ToString());
                PriceBox.Items.Add(i.Price.ToString("C2"));
                foreach (string s in i.SpecialInstructions)
                {
                    OrderList.Items.Add(s);
                    PriceBox.Items.Add("");
                }
            }
            OrderNum.Text = "Order# " + ord.OrderNumber.ToString();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
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

        private void ChangeOfProperty(string propertyName, int inOrDe, double amount)
        {
            switch (propertyName)
            {
                case "Pennies":
                    if (inOrDe == 0) Pennies++;
                    else Pennies--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
                    break;
                case "Nickels":
                    if (inOrDe == 0) Nickels++;
                    else Nickels--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
                    break;
                case "Dimes":
                    if (inOrDe == 0) Dimes++;
                    else Dimes--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
                    break;
                case "Quarters":
                    if (inOrDe == 0) Nickels++;
                    else Nickels--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
                    break;
                case "HalfDollars":
                    if (inOrDe == 0) HalfDollars++;
                    else HalfDollars--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
                    break;
                case "Dollars":
                    if (inOrDe == 0) Dollars++;
                    else Dollars--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                    break;
                case "Ones":
                    if (inOrDe == 0) Ones++;
                    else Ones--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                    break;
                case "Twos":
                    if (inOrDe == 0) Twos++;
                    else Twos--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
                    break;
                case "Fives":
                    if (inOrDe == 0) Fives++;
                    else Fives--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
                    break;
                case "Tens":
                    if (inOrDe == 0) Tens++;
                    else Tens--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
                    break;
                case "Twenties":
                    if (inOrDe == 0) Twenties++;
                    else Twenties--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
                    break;
                case "Fifties":
                    if (inOrDe == 0) Fifties++;
                    else Fifties--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
                    break;
                case "Hundreds":
                    if (inOrDe == 0) Hundreds++;
                    else Hundreds--;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
                    break;
            }
            if (inOrDe == 0)
            {
                Paid += amount;
                LeftToPay -= amount;
            }
            else
            {
                Paid -= amount;
                LeftToPay += amount;
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
                    ChangeOfProperty("Pennies", 0, .01);
                    break;
                case "IncreaseNickels":
                    ChangeOfProperty("Nickels", 0, .05);
                    break;
                case "IncreaseDimes":
                    ChangeOfProperty("Dimes", 0, .1);
                    break;
                case "IncreaseQuarters":
                    ChangeOfProperty("Quarters", 0, .25);
                    break;
                case "IncreaseHalfDollars":
                    ChangeOfProperty("HalfDollars", 0, .5);
                    break;
                case "IncreaseDollars":
                    ChangeOfProperty("Dollars", 0, 1);
                    break;
                case "IncreaseOnes":
                    ChangeOfProperty("Ones", 0, 1);
                    break;
                case "IncreaseTwos":
                    ChangeOfProperty("Twos", 0, 2);
                    break;
                case "IncreaseFives":
                    ChangeOfProperty("Fives", 0, 5);
                    break;
                case "IncreaseTens":
                    ChangeOfProperty("Tens", 0, 10);
                    break;
                case "IncreaseTwenties":
                    ChangeOfProperty("Twenties", 0, 20);
                    break;
                case "IncreaseFifties":
                    ChangeOfProperty("Fifties", 0, 50);
                    break;
                case "IncreaseHundreds":
                    ChangeOfProperty("Hundreds", 0 , 100);
                    break;
                case "DecreasePennies":
                    if (Pennies != 0) ChangeOfProperty("Pennies", 1, .01);
                    break;
                case "DecreaseNickels":
                    if (Nickels != 0) ChangeOfProperty("Nickels", 1, .05);
                    break;
                case "DecreaseDimes":
                    if (Dimes != 0) ChangeOfProperty("Dimes", 1, .1);
                    break;
                case "DecreaseQuarters":
                    if (Quarters != 0) ChangeOfProperty("Quarters", 1, .25);
                    break;
                case "DecreaseHalfDollars":
                    if (HalfDollars != 0) ChangeOfProperty("HalfDollars", 1, .5);
                    break;
                case "DecreaseDollars":
                    if (Dollars != 0) ChangeOfProperty("Dollars", 1, 1);
                    break;
                case "DecreaseOnes":
                    if (Ones != 0) ChangeOfProperty("Ones", 1, 1);
                    break;
                case "DecreaseTwos":
                    if (Twos != 0) ChangeOfProperty("Twos", 1, 2);
                    break;
                case "DecreaseFives":
                    if (Fives != 0) ChangeOfProperty("Fives", 1, 5);
                    break;
                case "DecreaseTens":
                    if (Tens != 0) ChangeOfProperty("Tens", 1, 10);
                    break;
                case "DecreaseTwenties":
                    if (Twenties != 0) ChangeOfProperty("Twenties", 1, 20);
                    break;
                case "DecreaseFifties":
                    if (Fifties != 0) ChangeOfProperty("Fifties", 1, 50);
                    break;
                case "DecreaseHundreds":
                    if (Hundreds != 0) ChangeOfProperty("Hundreds", 1, 100);
                    break;
                case "CancelPay":
                    NewOrder();
                    break;
                case "CardPay":
                    NewOrder();
                    break;
                case "CashPay":
                    foreach (Coins c in Enum.GetValues(typeof(Coins)) as Coins[])
                    {
                        switch (c)
                        {
                            case Coins.Penny:
                                cd.AddCoin(c, Pennies);
                                break;
                            case Coins.Nickel:
                                cd.AddCoin(c, Nickels);
                                break;
                            case Coins.Dime:
                                cd.AddCoin(c, Dimes);
                                break;
                            case Coins.Quarter:
                                cd.AddCoin(c, Quarters);
                                break;
                            case Coins.HalfDollar:
                                cd.AddCoin(c, HalfDollars);
                                break;
                            case Coins.Dollar:
                                cd.AddCoin(c, Dollars);
                                break;
                        }
                    }
                    foreach (Bills c in Enum.GetValues(typeof(Bills)) as Bills[])
                    {
                        switch (c)
                        {
                            case Bills.One:
                                cd.AddBill(c, Ones);
                                break;
                            case Bills.Two:
                                cd.AddBill(c, Twos);
                                break;
                            case Bills.Five:
                                cd.AddBill(c, Fives);
                                break;
                            case Bills.Ten:
                                cd.AddBill(c, Tens);
                                break;
                            case Bills.Twenty:
                                cd.AddBill(c, Twenties);
                                break;
                            case Bills.Fifty:
                                cd.AddBill(c, Fifties);
                                break;
                            case Bills.Hundred:
                                cd.AddBill(c, Hundreds);
                                break;
                        }
                    }
                    if (LeftToPay < 0)
                    {
                        Change = LeftToPay;
                        double ch = Change;
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Change"));
                        var changeC = new List<Coins>();
                        var changeB = new List<Bills>();
                        var c = Enum.GetValues(typeof(Coins)) as Coins[];
                        var b = Enum.GetValues(typeof(Bills)) as Bills[];
                        Array.Reverse(c);
                        Array.Reverse(b);
                        int bi = 0;
                        double v = Math.Round(0.0, 2);
                        foreach (Bills i in b)
                        {
                            
                            switch (i)
                            {
                                case Bills.One:
                                    bi = cd.Ones;
                                    v = 1;
                                    break;
                                case Bills.Two:
                                    bi = cd.Twos;
                                    v = 2;
                                    break;
                                case Bills.Five:
                                    bi = cd.Fives;
                                    v = 5;
                                    break;
                                case Bills.Ten:
                                    bi = cd.Tens;
                                    v = 10;
                                    break;
                                case Bills.Twenty:
                                    bi = cd.Twenties;
                                    v = 20;
                                    break;
                                case Bills.Fifty:
                                    bi = cd.Fifties;
                                    v = 50;
                                    break;
                                case Bills.Hundred:
                                    bi = cd.Hundreds;
                                    v = 100;
                                    break;
                            }
                            while (ch - v >= 0)
                            {
                                if (bi == 0)
                                {

                                }
                                ch -= v;
                                cd.RemoveBill(i, 1);
                                changeB.Add(i);
                                bi -= 1;
                            }
                        }
                        foreach(Coins i in c)
                        {
                            switch (i)
                            {
                                case Coins.Penny:
                                    bi = cd.Pennies;
                                    v = 0.01;
                                    break;
                                case Coins.Nickel:
                                    bi = cd.Nickels;
                                    v = 0.05;
                                    break;
                                case Coins.Dime:
                                    bi = cd.Dimes;
                                    v = 0.10;
                                    break;
                                case Coins.Quarter:
                                    bi = cd.Quarters;
                                    v = 0.25;
                                    break;
                                case Coins.HalfDollar:
                                    bi = cd.HalfDollars;
                                    v = 0.50;
                                    break;
                                case Coins.Dollar:
                                    bi = cd.Dollars;
                                    v = 1.00;
                                    break;
                            }
                            while (ch - v >= 0)
                            {
                                if (bi == 0)
                                {

                                }
                                ch -= v;
                                cd.RemoveCoin(i, 1);
                                changeC.Add(i);
                                bi -= 1;
                            }
                        }
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

