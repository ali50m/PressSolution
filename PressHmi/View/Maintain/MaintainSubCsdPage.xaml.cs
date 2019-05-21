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
using FanucCnc;

namespace PressHmi.View
{
    /// <summary>
    /// MaintainSubCsdPage.xaml 的交互逻辑
    /// </summary>
    public partial class MaintainSubCsdPage : Page
    {
        public MaintainSubCsdPage()
        {
            InitializeComponent();

            IntPtr hwnd;
            hwnd = myPanel.Handle;
            var csd = CncScreenDisplay.CreateInstance();
            csd.CreateCncScreenDisplay(hwnd);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO:NO CNC
            var csd = CncScreenDisplay.CreateInstance();
            csd.StartRefreshCncScreenDisplay();
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            //TODO:NO CNC
            var csd = CncScreenDisplay.CreateInstance();
            csd.StopRefreshCncScreenDisplay();
        }
    }
}