﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace OneHundredAndEighty.Windows
{
    /// <summary>
    /// Логика взаимодействия для WinnerWindow.xaml
    /// </summary>
    public partial class WinnerWindow : Window
    {
        public bool StatsShow { get; private set; } //  Показ статистики
        public WinnerWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShowStatsButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StatsShow = true;
            this.Close();
        }
    }
}
