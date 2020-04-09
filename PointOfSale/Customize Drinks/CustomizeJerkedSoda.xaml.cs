/* Author: Cari Miller
 * Class: CustomizeJerkedSoda.xaml.cs
 * Purpose: Customizes jerked soda
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
using Size = CowboyCafe.Data.Size;
using SodaFlavor = CowboyCafe.Data.SodaFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        public CustomizeJerkedSoda()
        {
            InitializeComponent();
            
            OrangeSodaButton.Click += Size_Clicked;
            CreamSodaButton.Click += Size_Clicked;
            BirchBeerButton.Click += Size_Clicked;
            RootBeerButton.Click += Size_Clicked;
            SarsparillaButton.Click += Size_Clicked;
        }
        void Size_Clicked(object sender, RoutedEventArgs e)
        {
            JerkedSoda b = (JerkedSoda)DataContext;
            switch (((RadioButton)sender).Name)
            {
              
                case "CreamSodaButton":
                    b.Flavor = SodaFlavor.CreamSoda;
                    break;
                case "OrangeSodaButton":
                    b.Flavor = SodaFlavor.OrangeSoda;
                    break;
                case "SarsparillaButton":
                    b.Flavor = SodaFlavor.Sarsparilla;
                    break;
                case "BirchBeerButton":
                    b.Flavor = SodaFlavor.BirchBeer;
                    break;
                case "RootBeerButton":
                    b.Flavor = SodaFlavor.RootBeer;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
