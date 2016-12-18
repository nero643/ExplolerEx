// <copyright file="MainWindow.xaml.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ExplolerEx
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using Microsoft.WindowsAPICodePack.Controls;
    using Microsoft.WindowsAPICodePack.Shell;

    public class TriCheckToPaneVisibilityState : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return PaneVisibilityState.DoNotCare;
            }
            else if ((bool)value == true)
            {
                return PaneVisibilityState.Show;
            }
            else
            {
                return PaneVisibilityState.Hide;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((PaneVisibilityState)value == PaneVisibilityState.DoNotCare)
            {
                return null;
            }
            else if ((PaneVisibilityState)value == PaneVisibilityState.Show)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
