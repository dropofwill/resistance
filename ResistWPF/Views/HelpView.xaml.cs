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

namespace ResistWPF.Views
{
    /// <summary>
    /// Interaction logic for HelpView.xaml
    /// </summary>
    public partial class HelpView : UserControl
    {
        private ViewControl viewController;

        public HelpView(ViewControl vC)
        {
            viewController = vC;
            InitializeComponent();
        }

        private void Back_btn_help_Click(object sender, RoutedEventArgs e)
        {
            viewController.SetView(viewController.Menu);
        }
    }
}
