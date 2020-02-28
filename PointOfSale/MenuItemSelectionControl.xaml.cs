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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderSummaryControl ds;
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            ds = new OrderSummaryControl();
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
        /// <summary>
        /// Listener for the click event of the Cowpoke Chili Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButton_Clicked(object sender, RoutedEventArgs e)
        {
           
            ds.OrderList.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Listener for the click event of the Angry Chicken Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// Listener for the click event of the Dakota Double Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
           ds.OrderList.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Listener for the click event of the Pecos Pulled Pork Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Listener for the click event of the Rustler's Ribs Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Listener for the click event of the Texas Triple Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Listener for the click event of the Trail Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Listener for the click event of the Baked Beans Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Listener for the click event of the Chili Cheese Fries Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Listener for the click event of the Corn Dodgers Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Listener for the click event of the Pan de Campo Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Listener for the click event of the Cowboy Coffee Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Listener for the click event of the Jerked Soda Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Listener for the click event of the Texas Tea Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Listener for the click event of the Water Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButton_Clicked(object sender, RoutedEventArgs e)
        {
            ds.OrderList.Items.Add(new Water());
        }
    }
}
