﻿/* Author: Cari Miller
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose:
 */
using System.Windows;
using System.Windows.Controls;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;
        public MenuItemSelectionControl()
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
        /// <summary>
        /// Listener for the click event of the Cowpoke Chili Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButton_Clicked(object sender, RoutedEventArgs e)
        {
            
            CowpokeChili c = new CowpokeChili();
            var screen = new CustomizeCowpokeChili();
            
            AddItemAndOpenCustomizationScreen(c, screen);
            
        }

        /// <summary>
        /// Listener for the click event of the Angry Chicken Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButton_Clicked(object sender, RoutedEventArgs e)
        {
            AngryChicken a = new AngryChicken();
            var screen = new CustomizeAngryChicken();

            AddItemAndOpenCustomizationScreen(a, screen);
        }

        /// <summary>
        /// Listener for the click event of the Dakota Double Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger d = new DakotaDoubleBurger();
            ((Order)DataContext).Add(d);
            
        }

        /// <summary>
        /// Listener for the click event of the Pecos Pulled Pork Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButton_Clicked(object sender, RoutedEventArgs e)
        {
            PecosPulledPork p = new PecosPulledPork();
            ((Order)DataContext).Add(p);
            
        }

        /// <summary>
        /// Listener for the click event of the Rustler's Ribs Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButton_Clicked(object sender, RoutedEventArgs e)
        {
            RustlersRibs r = new RustlersRibs();
            ((Order)DataContext).Add(r);
            
        }

        /// <summary>
        /// Listener for the click event of the Texas Triple Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger t = new TexasTripleBurger();
            ((Order)DataContext).Add(t);
           
        }

        /// <summary>
        /// Listener for the click event of the Trail Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            TrailBurger tb = new TrailBurger();
            ((Order)DataContext).Add(tb);
            
        }

        /// <summary>
        /// Listener for the click event of the Baked Beans Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButton_Clicked(object sender, RoutedEventArgs e)
        {
            BakedBeans b = new BakedBeans();
            ((Order)DataContext).Add(b);
            
        }

        /// <summary>
        /// Listener for the click event of the Chili Cheese Fries Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButton_Clicked(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Listener for the click event of the Corn Dodgers Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButton_Clicked(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CornDodgers());
        }

        /// <summary>
        /// Listener for the click event of the Pan de Campo Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoButton_Clicked(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new PanDeCampo());
        }

        /// <summary>
        /// Listener for the click event of the Cowboy Coffee Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButton_Clicked(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCoffee());
        }

        /// <summary>
        /// Listener for the click event of the Jerked Soda Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButton_Clicked(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new JerkedSoda());
        }

        /// <summary>
        /// Listener for the click event of the Texas Tea Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButton_Clicked(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new TexasTea());
        }

        /// <summary>
        /// Listener for the click event of the Water Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButton_Clicked(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new Water());
        }

        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new System.Exception("DataContext expected to be an Order instance.");

            if (screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new System.Exception("An ancestor of OrderControl exception.");
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            order.Add(item);
        }
    }
}
