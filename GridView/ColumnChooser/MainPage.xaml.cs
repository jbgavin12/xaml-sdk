﻿using System;
using System.Linq;
using System.Windows.Controls;
using ColumnChooser;

namespace SilverlightApplication1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            DataContext = new MyDataContext();
        }
    }
}
