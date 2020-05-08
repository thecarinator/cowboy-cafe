/* Author: Cari Miller
 * Class: TransactionControl.xaml.cs
 * Purpose: Transaction window
 */
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
using System.Windows.Automation.Peers;

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
        public IEnumerable<IOrderItem> Items { get; set; }
        public uint OrderNumber { get; set; }
        private double change;
        public double Change { get { return Math.Abs(change); } set { change = value; } }
        public TransactionControl(CashDrawer dc, OrderControl co)
        {
            DataContext = this;
            InitializeComponent();
            cd = dc;
            oc = co;
            ord = oc.DataContext as Order;
            Subtotal = ord.Subtotal;
            Tax = ord.Tax;
            Total = ord.Total;
            CashPay.IsEnabled = false;
            LeftToPay = Total;
            Items = ord.Items;
            OrderNumber = ord.OrderNumber;
            foreach (IOrderItem i in Items)
            {
                OrderList.Items.Add(i.ToString());
                PriceBox.Items.Add(i.Price.ToString("C2"));
                foreach (string s in i.SpecialInstructions)
                {
                    OrderList.Items.Add(s);
                    PriceBox.Items.Add("");
                }
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LeftToPay"));

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
                    CardTerminal ct = new CardTerminal();
                    ResultCode r = ct.ProcessTransaction(Total);
                    switch (r)
                    {
                        case ResultCode.Success:
                            Paid = Total;
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Paid"));
                            Receipt(1);
                            break;
                        case ResultCode.InsufficentFunds:
                            MessageBox.Show("Error: Card has insufficient funds\n\nTry different card or pay with cash.");
                            Error.Text = "Error: Card has insufficient";
                            ExtError.Text = "funds";
                            break;
                        case ResultCode.CancelledCard:
                            MessageBox.Show("Error: Card cancelled\n\nTry different card or pay with cash.");
                            Error.Text = "Error: Card cancelled";
                            ExtError.Text = "";
                            break;
                        case ResultCode.ReadError:
                            MessageBox.Show("Error: Bad swipe\n\nPlease try swiping again.");
                            Error.Text = "Error: Bad swipe";
                            ExtError.Text = "";
                            break;
                        case ResultCode.UnknownErrror:
                            MessageBox.Show("Error: Unknown error\n\n Please try swiping again.");
                            Error.Text = "Error: Unknown error";
                            ExtError.Text = "";
                            break;
                    }
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
                            Bills j = i;
                            switch (j)
                            {
                                case Bills.One:
                                    bi = cd.Ones;
                                    v = 1;
                                    break;
                                case Bills.Two:
                                    bi = cd.Twos;
                                    v = 2;
                                    if (bi == 0)
                                    {
                                        j--;
                                        goto case Bills.One;
                                    }
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
                                if (bi == 0) BreakBills(j);
                                ch -= v;
                                cd.RemoveBill(j, 1);
                                changeB.Add(j);
                                bi--;
                            }
                        }
                        foreach(Coins i in c)
                        {
                            Coins j = i;
                            switch (j)
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
                                    if (bi == 0)
                                    {
                                        j--;
                                        goto case Coins.Quarter;
                                    }
                                    break;
                                case Coins.Dollar:
                                    bi = cd.Dollars;
                                    v = 1.00;
                                    if (bi == 0)
                                    {
                                        j--;
                                        goto case Coins.HalfDollar;
                                    }
                                    break;
                            }
                            while (ch - v >= 0)
                            {
                                if (bi == 0)
                                {
                                    int be = 0;
                                    Coins co = j + 1;
                                    switch (co)
                                    {
                                        case Coins.Nickel:
                                            be = cd.Nickels;
                                            if (be == 0)
                                            {
                                                co++;
                                                goto case Coins.Dime;
                                            }
                                            break;
                                        case Coins.Dime:
                                            be = cd.Dimes;
                                            if (be == 0)
                                            {
                                                co++;
                                                goto case Coins.Quarter;
                                            }
                                            break;
                                        case Coins.Quarter:
                                            be = cd.Quarters;
                                            if (be == 0)
                                            {
                                                co++;
                                                goto case Coins.HalfDollar;
                                            }
                                            break;
                                        case Coins.HalfDollar:
                                            be = cd.HalfDollars;
                                            if (be == 0)
                                            {
                                                co++;
                                                goto case Coins.Dollar;
                                            }
                                            break;
                                        case Coins.Dollar:
                                            be = cd.Dollars;
                                            if (be == 0)
                                            {
                                                if (cd.Ones > 0)
                                                {
                                                    cd.RemoveBill(Bills.One, 1);
                                                    cd.AddCoin(Coins.Dollar, 1);
                                                }
                                                else
                                                {
                                                    BreakBills(Bills.One);
                                                    goto case Coins.Dollar;
                                                }
                                            }
                                            break;
                                        default:
                                            new NotImplementedException();
                                            break;
                                    }
                                    switch (co)
                                    {
                                        case Coins.Nickel:
                                            cd.RemoveCoin(Coins.Nickel, 1);
                                            cd.AddCoin(Coins.Penny, 5);
                                            break;
                                        case Coins.Dime:
                                            cd.RemoveCoin(Coins.Dime, 1);
                                            cd.AddCoin(Coins.Nickel, 2);
                                            if (j == Coins.Nickel) break;
                                            else goto case Coins.Nickel;
                                        case Coins.Quarter:
                                            cd.RemoveCoin(Coins.Quarter, 1);
                                            cd.AddCoin(Coins.Dime, 2);
                                            cd.AddCoin(Coins.Nickel, 1);
                                            if (j == Coins.Dime) break;
                                            else goto case Coins.Dime;
                                        case Coins.HalfDollar:
                                            cd.RemoveCoin(Coins.HalfDollar, 1);
                                            cd.AddCoin(Coins.Quarter, 2);
                                            if (j == Coins.Quarter) break;
                                            else goto case Coins.Quarter;
                                        case Coins.Dollar:
                                            cd.RemoveCoin(Coins.Dollar, 1);
                                            cd.AddCoin(Coins.Quarter, 4);
                                            if (j == Coins.Quarter) break;
                                            else goto case Coins.Quarter;
                                        default:
                                            new NotImplementedException();
                                            break;
                                    }
                                }
                                ch -= v;
                                cd.RemoveCoin(j, 1);
                                changeC.Add(j);
                                bi--;
                            }
                            
                        }
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Change to give back:\n\t");
                        foreach(Bills bill in changeB)
                        {
                            sb.Append(bill.ToString() + "\n\t");
                        }
                        foreach(Coins coin in changeC)
                        {
                            sb.Append(coin.ToString() +"\n\t");
                        }
                        MessageBox.Show(sb.ToString());
                    }
                    while (cd.Pennies >= 105)
                    {
                        cd.RemoveCoin(Coins.Penny, 5);
                        cd.AddCoin(Coins.Nickel, 1);
                    }
                    while (cd.Nickels >= 82)
                    {
                        cd.RemoveCoin(Coins.Nickel, 2);
                        cd.AddCoin(Coins.Dime, 1);
                    }
                    while (cd.Dimes >= 105)
                    {
                        cd.RemoveCoin(Coins.Dime, 5);
                        cd.AddCoin(Coins.Quarter, 2);
                    }
                    while (cd.Quarters >= 44)
                    {
                        cd.RemoveCoin(Coins.Quarter, 4);
                        cd.AddBill(Bills.One, 1);
                    }
                    while (cd.HalfDollars >= 2)
                    {
                        cd.RemoveCoin(Coins.HalfDollar, 2);
                        cd.AddBill(Bills.One, 1);
                    }
                    while (cd.Dollars >= 5)
                    {
                        cd.RemoveCoin(Coins.Dollar, 5);
                        cd.AddBill(Bills.Five, 1);
                    }
                    while (cd.Ones >= 80)
                    {
                        cd.RemoveBill(Bills.One, 5);
                        cd.AddBill(Bills.Five, 1);
                    }
                    while (cd.Twos >= 5)
                    {
                        cd.RemoveBill(Bills.Two, 5);
                        cd.AddBill(Bills.Ten, 1);
                    }
                    while (cd.Fives >= 8)
                    {
                        cd.RemoveBill(Bills.Five, 2);
                        cd.AddBill(Bills.Ten, 1);
                    }
                    while (cd.Tens >= 4)
                    {
                        cd.RemoveBill(Bills.Ten, 2);
                        cd.AddBill(Bills.Twenty, 1);
                    }
                    while (cd.Twenties >= 5)
                    {
                        cd.RemoveBill(Bills.Twenty, 5);
                        cd.AddBill(Bills.Hundred, 1);
                    }
                    while (cd.Fifties >= 2)
                    {
                        cd.RemoveBill(Bills.Fifty, 2);
                        cd.AddBill(Bills.Hundred, 1);
                    }
                    Receipt(0);
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

        private void Receipt(int pay)
        {
            ReceiptPrinter r = new ReceiptPrinter();
            StringBuilder sb = new StringBuilder();
           
            sb.Append("\t                   Cowboy Cafe\n    _________________________________________\n\nOrder #" + OrderNumber.ToString() + "\t\t\t" + DateTime.Now + "\n\n");
            foreach(IOrderItem i in Items)
            {
                sb.Append(i.ToString() + "\t\t " + i.Price.ToString("C2"));
                foreach(string st in i.SpecialInstructions)
                {
                    sb.Append("\n\t" + st);
                }
                sb.Append("\n");
            }
            sb.Append("\nSubtotal: " + Subtotal.ToString("C2") + "\nTax: \t " + Tax.ToString("C2") + "\nTotal:  \t " + Total.ToString("C2") + "\n");
            if (pay == 0)
            {
                sb.Append("\nPaid: \t" + Paid.ToString("C2"));
            }
            else sb.Append("\nCredit: \t " + Paid.ToString("C2"));
            sb.Append("\nChange: \t " + Change.ToString("C2"));
            string s = sb.ToString();
            MessageBox.Show(s);
            r.Print(s);
            s = "Contents of the Cash Drawer\n\n____________________________\n            Coins\n____________________________\n\nPennies: " + cd.Pennies + "\nNickels: " + cd.Nickels + "\nDimes: " + cd.Dimes + "\nQuarters: " + cd.Quarters + "\nHalf Dollars: " + cd.HalfDollars + "\nDollars: " + cd.Dollars + "\n\n____________________________\n             Bills\n____________________________\n\nOnes: " + cd.Ones + "\nTwos: " + cd.Twos + "\nFives: " + cd.Fives + "\nTens: " + cd.Tens + "\nTwenties: " + cd.Twenties + "\nFifties: " + cd.Fifties + "\nHundreds: " + cd.Hundreds + "\n\n____________________________\nCash Drawer Total: " + cd.TotalValue.ToString("C2") + "\n____________________________\n";
            MessageBox.Show(s);
            NewOrder();
        }

        private void BreakBills(Bills b)
        {
            int bi = 0;
            Bills ba = b + 1;
            switch (ba)
            {
                case Bills.Two:
                    bi = cd.Twos;
                    if (bi == 0)
                    {
                        ba++;
                        goto case Bills.Five;
                    }
                    break;
                case Bills.Five:
                    bi = cd.Fives;
                    if (bi == 0)
                    {
                        ba++;
                        goto case Bills.Ten;
                    }
                    break;
                case Bills.Ten:
                    bi = cd.Tens;
                    if (bi == 0)
                    {
                        ba++;
                        goto case Bills.Twenty;
                    }
                    break;
                case Bills.Twenty:
                    bi = cd.Twenties;
                    if (bi == 0)
                    {
                        ba++;
                        goto case Bills.Fifty;
                    }
                    break;
                case Bills.Fifty:
                    bi = cd.Fifties;
                    if (bi == 0)
                    {
                        ba++;
                        goto case Bills.Hundred;
                    }
                    break;
                case Bills.Hundred:
                    bi = cd.Hundreds;
                    if (bi == 0) goto default;
                    break;
                default:
                    new NotImplementedException();
                    break;
            }
            switch (ba)
            {
                case Bills.Two:
                    cd.RemoveBill(Bills.Two, 1);
                    cd.AddBill(Bills.One, 2);
                    break;
                case Bills.Five:
                    cd.RemoveBill(Bills.Five, 1);
                    cd.AddBill(Bills.One, 5);
                    break;
                case Bills.Ten:
                    cd.RemoveBill(Bills.Ten, 1);
                    cd.AddBill(Bills.Five, 2);
                    if (b == Bills.Five) break;
                    else goto case Bills.Five;
                case Bills.Twenty:
                    cd.RemoveBill(Bills.Twenty, 1);
                    cd.AddBill(Bills.Ten, 2);
                    if (b == Bills.Ten) break;
                    else goto case Bills.Ten;
                case Bills.Fifty:
                    cd.RemoveBill(Bills.Fifty, 1);
                    cd.AddBill(Bills.Twenty, 2);
                    cd.AddBill(Bills.Ten, 1);
                    if (b == Bills.Twenty) break;
                    else goto case Bills.Twenty;
                case Bills.Hundred:
                    cd.RemoveBill(Bills.Hundred, 1);
                    cd.AddBill(Bills.Fifty, 2);
                    if (b == Bills.Fifty) break;
                    else goto case Bills.Fifty;
                default:
                    new NotImplementedException();
                    break;
            }
        }
    }
}

