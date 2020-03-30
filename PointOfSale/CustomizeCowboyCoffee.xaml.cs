/* Author: Cari Miller
 * Class: CustomizeCowboyCoffee.xaml.cs
 * Purpose: Customizes Cowboy Coffee
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffee : UserControl
    {
        public CustomizeCowboyCoffee()
        {
            InitializeComponent();
            SmallSize.Click += Size_Clicked;
            MediumSize.Click += Size_Clicked;
            LargeSize.Click += Size_Clicked;
        }

        void Size_Clicked(object sender, RoutedEventArgs e)
        {
            CowboyCoffee b = (CowboyCoffee)DataContext;
            switch (((RadioButton)sender).Name)
            {
                case "SmallSize":
                    b.Size = Size.Small;
                    break;
                case "MediumSize":
                    b.Size = Size.Medium;
                    break;
                case "LargeSize":
                    b.Size = Size.Large;
                    break;
            }
        }
    }
}
