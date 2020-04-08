/* Author: Cari Miller
 * Class: OrderSummaryControl.xaml.cs
 * Purpose: Summarizes the order
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void ItemSelected(object sender, SelectionChangedEventArgs e)
        {
            IOrderItem p = ((sender as ListView).SelectedItem as IOrderItem);
            var order = this.FindAncestor<OrderControl>();
            if (p is AngryChicken)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeAngryChicken();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is BakedBeans)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeBakedBeans();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is ChiliCheeseFries)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeChiliCheeseFries();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is CornDodgers)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeCornDodgers();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is CowboyCoffee)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeCowboyCoffee();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is CowpokeChili)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeCowpokeChili();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is DakotaDoubleBurger)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeDakotaDoubleBurger();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is JerkedSoda)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeJerkedSoda();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is PanDeCampo)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizePanDeCampo();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is PecosPulledPork)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizePecosPulledPork();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is RustlersRibs)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeRustlersRibs();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is TexasTea)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeTexasTea();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is TexasTripleBurger)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeTexasTripleBurger();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else if (p is TrailBurger)
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeTrailBurger();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
            else
            {
                if (DataContext is Order)
                {
                    var scr = new CustomizeWater();
                    scr.DataContext = p;
                    order.SwapScreen(scr);
                }
            }
        }
    }
}
