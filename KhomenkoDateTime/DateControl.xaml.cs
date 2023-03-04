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

namespace KhomenkoDateTime
{
    /// <summary>
    /// Interaction logic for DateControl.xaml
    /// </summary>
    public partial class DateControl : UserControl
    {
        public DateControl()
        {
            InitializeComponent();
        }

        private void ConfirmInput_Click(object sender, RoutedEventArgs e)
        {
            // return error if date isn't selected
            if (DateSelect.SelectedDate == null)
            {
                MessageBox.Show("No date set!");
                return;
            }

            //TODO get calculated data & operate with it
            MessageBox.Show("This is working! :D");
        }
    }
}
