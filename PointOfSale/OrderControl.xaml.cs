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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButton_Clicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButton_Clicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButton_Clicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButton_Clicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButton_Clicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButton_Clicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButton_Clicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButton_Clicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButton_Clicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButton_Clicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButton_Clicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButton_Clicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButton_Clicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButton_Clicked;
            AddWaterButton.Click += OnAddWaterButton_Clicked;
        }


        void OnAddCowpokeChiliButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }


        void OnAddAngryChickenButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }


        void OnAddDakotaDoubleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }


        void OnAddPecosPulledPorkButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }


        void OnAddRustlersRibsButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }


        void OnAddTexasTripleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }


        void OnAddTrailBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }


        void OnAddBakedBeansButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }


        void OnAddChiliCheeseFriesButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }


        void OnAddCornDodgersButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }


        void OnAddPanDeCampoButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }


        void OnAddCowboyCoffeeButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }


        void OnAddJerkedSodaButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }


        void OnAddTexasTeaButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }


        void OnAddWaterButton_Clicked(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new Water());
        }
    }
}
