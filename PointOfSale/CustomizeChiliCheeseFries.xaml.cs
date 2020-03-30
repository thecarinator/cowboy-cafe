/* Author: Cari Miller
 * Class: CustomizeChiliCheeseFries.xaml.cs
 * Purpose: Customizes chili cheese fries
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
    /// Interaction logic for CustomizeChiliCheeseFries.xaml
    /// </summary>
    public partial class CustomizeChiliCheeseFries : UserControl
    {
        public CustomizeChiliCheeseFries()
        {
            InitializeComponent();
            SmallSize.Click += Size_Clicked;
            MediumSize.Click += Size_Clicked;
            LargeSize.Click += Size_Clicked;
        }

        void Size_Clicked(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries b = (ChiliCheeseFries)DataContext;
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
