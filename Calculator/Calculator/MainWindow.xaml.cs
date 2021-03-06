﻿using Microsoft.Win32;
using System;
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

namespace Calculator
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
        public void Btn_nummer(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_procent(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_CE(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                
            }
        }

        public void Btn_C(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text = "";
            }
        }

        public void Btn_Delat(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_gånger(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_minus(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_plus(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_likamed(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_comma(Object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                TextField.Text += button.Content;
            }
        }

        public void Btn_calc(Object sender, RoutedEventArgs e)
        {
            var numbers = TextField.Text.Split('+', '-', '÷', '*');

            if (e.Source is Button button)
            {
                if(TextField.Text.Contains('+')) {
                    var sum = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1]);
                    TextField.Text = sum + "";
                }

                if (TextField.Text.Contains('-'))
                {
                    var sum = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1]);
                    TextField.Text = sum + "";
                }

                if (TextField.Text.Contains('÷'))
                {
                    var sum = Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
                    TextField.Text = sum + "";
                }

                if (TextField.Text.Contains('*'))
                {
                    var sum = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
                    TextField.Text = sum + "";
                }

                if (TextField.Text.Contains('%'))
                {
                    var sum = Convert.ToDouble(numbers[0]) % Convert.ToDouble(numbers[1]);
                    TextField.Text = sum + "";
                }
            }
        }
    }
}
