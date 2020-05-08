/* Author: Cari Miller
 * Class: ExtensionMethod.cs
 * Purpose:
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Finds the ancestor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dp"></param>
        /// <returns></returns>
        public static T FindAncestor<T>(this DependencyObject dp) where T: DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(dp);
            if (parent is null) return null;
            if (parent is T) return parent as T;
            return FindAncestor<T>(parent);
        } 
    }
}
