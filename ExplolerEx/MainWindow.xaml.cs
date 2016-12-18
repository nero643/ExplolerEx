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

    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Loaded += new RoutedEventHandler(this.ExplorerBrowserTestWindow_Loaded);
        }

        private void ExplorerBrowserTestWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Navigate to initial folder
            this.eb.ExplorerBrowserControl.Navigate((ShellObject)KnownFolders.Desktop);
        }
    }
}
