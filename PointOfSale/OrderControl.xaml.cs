/* Author: Cari Miller
 * Class: OrderControl.xaml.cs
 * Purpose:
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            this.DataContext = new Order();
            CancelOrderButton.Click += OnCancelOrderButton_Clicked;
            CompleteOrderButton.Click += OnCompleteOrderButton_Clicked;
        }

        /// <summary>
        /// Cancels the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Completes the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
        public void SwapScreen(UIElement elem)
        {
            Container.Child = elem;
        }
    }
}
