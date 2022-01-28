﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace introduction_cs_municipalities
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadDataButton(object sender, RoutedEventArgs e)
        {
            IEnumerable<string> csv_data = new List<string>();
            OpenFileDialog openfileDialog = new OpenFileDialog();
            if (openfileDialog.ShowDialog() == true)
            {
                openfileDialog.Title = "Select a File";
                openfileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openfileDialog.InitialDirectory = @"introduction-cs-municipalities/data";
                csv_data = File.ReadLines(openfileDialog.FileName);
            }

            foreach (string item in csv_data)
            {
                System.Diagnostics.Debug.WriteLine(item);
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
