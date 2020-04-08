/* Author: Cari Miller
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose: Adds Item to order
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
            var screen = new CustomizeDakotaDoubleBurger();
            AddItemAndOpenCustomizationScreen(d, screen);
            
        }

        /// <summary>
        /// Listener for the click event of the Pecos Pulled Pork Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButton_Clicked(object sender, RoutedEventArgs e)
        {
            PecosPulledPork p = new PecosPulledPork();
            var screen = new CustomizePecosPulledPork();

            AddItemAndOpenCustomizationScreen(p, screen);
            
        }

        /// <summary>
        /// Listener for the click event of the Rustler's Ribs Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButton_Clicked(object sender, RoutedEventArgs e)
        {
            RustlersRibs r = new RustlersRibs();
            var screen = new CustomizeRustlersRibs();
            AddItemAndOpenCustomizationScreen(r, screen);
            
        }

        /// <summary>
        /// Listener for the click event of the Texas Triple Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger t = new TexasTripleBurger();
            var screen = new CustomizeTexasTripleBurger();

            AddItemAndOpenCustomizationScreen(t, screen);
           
        }

        /// <summary>
        /// Listener for the click event of the Trail Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButton_Clicked(object sender, RoutedEventArgs e)
        {
            TrailBurger tb = new TrailBurger();
            var screen = new CustomizeTrailBurger();

            AddItemAndOpenCustomizationScreen(tb, screen);
            
        }

        /// <summary>
        /// Listener for the click event of the Baked Beans Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButton_Clicked(object sender, RoutedEventArgs e)
        {
            BakedBeans b = new BakedBeans();
            var screen = new CustomizeBakedBeans();
            AddItemAndOpenCustomizationScreen(b, screen);
            
        }

        /// <summary>
        /// Listener for the click event of the Chili Cheese Fries Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButton_Clicked(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries c = new ChiliCheeseFries();
            var screen = new CustomizeChiliCheeseFries();
            AddItemAndOpenCustomizationScreen(c, screen);
        }

        /// <summary>
        /// Listener for the click event of the Corn Dodgers Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButton_Clicked(object sender, RoutedEventArgs e)
        {
            CornDodgers c = new CornDodgers();
            var screen = new CustomizeCornDodgers();
            AddItemAndOpenCustomizationScreen(c, screen);
            
        }

        /// <summary>
        /// Listener for the click event of the Pan de Campo Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoButton_Clicked(object sender, RoutedEventArgs e)
        {
            PanDeCampo p = new PanDeCampo();
            var screen = new CustomizePanDeCampo();
            AddItemAndOpenCustomizationScreen(p, screen);
        }

        /// <summary>
        /// Listener for the click event of the Cowboy Coffee Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButton_Clicked(object sender, RoutedEventArgs e)
        {
            CowboyCoffee c = new CowboyCoffee();
            var screen = new CustomizeCowboyCoffee();

            AddItemAndOpenCustomizationScreen(c, screen);
        }

        /// <summary>
        /// Listener for the click event of the Jerked Soda Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButton_Clicked(object sender, RoutedEventArgs e)
        {
            JerkedSoda j = new JerkedSoda();
            var screen = new CustomizeJerkedSoda();
            AddItemAndOpenCustomizationScreen(j, screen);
        }

        /// <summary>
        /// Listener for the click event of the Texas Tea Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButton_Clicked(object sender, RoutedEventArgs e)
        {
            TexasTea t = new TexasTea();
            var screen = new CustomizeTexasTea();
            AddItemAndOpenCustomizationScreen(t, screen);
        }

        /// <summary>
        /// Listener for the click event of the Water Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButton_Clicked(object sender, RoutedEventArgs e)
        {
            Water w = new Water();
            var screen = new CustomizeWater();
            AddItemAndOpenCustomizationScreen(w, screen);
        }

        /// <summary>
        /// Switches to the customization screen
        /// </summary>
        /// <param name="item"> item being added</param>
        /// <param name="screen"> screen being switched to</param>
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
