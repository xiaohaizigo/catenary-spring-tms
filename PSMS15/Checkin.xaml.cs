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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PSMS15
{
    /// <summary>
    /// Checkin.xaml 的交互逻辑
    /// </summary>
    public partial class Checkin : Page
    {
        public Checkin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckinChange page1 = new CheckinChange();
            Content = new Frame()
            {
                Content = page1
            };
        }
    }
}
