﻿/* Author: Cari Miller
 * Class: OrderControl.xaml.cs
 * Purpose: Handles the order buttons
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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
         CashDrawer cd = new CashDrawer();

        /// <summary>
        /// Sets up order control+
        /// </summary>
        public OrderControl()
        { 
            InitializeComponent();
            this.DataContext = new Order();
            CancelOrderButton.Click += OnCancelOrderButton_Clicked;
            CompleteOrderButton.Click += OnCompleteOrderButton_Clicked;
            ItemSelectionButton.Click += OnItemSelectionButton_Clicked;
        }

        /// <summary>
        /// Cancels the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Completes the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            var ord = DataContext as Order;
            IOrderItem[] items = ord.Items as IOrderItem[];
            if (items.Length != 0)
            {
                var main = this.FindAncestor<MainWindow>();
                main.Container.Child = new TransactionControl(cd, this);
            }
        }

        /// <summary>
        /// Selects Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionButton_Clicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
            
            
        }

        /// <summary>
        /// swaps screen
        /// </summary>
        /// <param name="elem"></param>
        public void SwapScreen(UIElement elem)
        {
            Container.Child = elem;
        }
    }
}
