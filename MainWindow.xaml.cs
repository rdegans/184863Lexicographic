﻿/*
* Name: Riley de Gans
* Date: May 27th, 2019
* Description: An app that finds the nth permuation of numbers 0 to 9
*/
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

namespace _184863Lexicographic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string finalNum = "";
        public MainWindow()
        {
            InitializeComponent();
            int million = 1000000;
            int permutation = 0;
            List<int> digits = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                digits.Add(i);
            }
            int range = fact(9);
            for (int i = 9; i > -1; i--)
            {
                for (int x = 0; x < digits.Count + 1; x++)
                {
                    int temp = permutation + range * (x+1);
                    if (temp >= million)
                    {
                        permutation += range * (x);
                        finalNum += digits[x] + "";
                        digits.RemoveAt(x);
                        try
                        {
                            range /= i;
                        }
                        catch
                        {

                        }
                        x = 9;
                    }
                }
            }
            MessageBox.Show(finalNum);
        }
        public int fact(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * fact(num - 1);
        }
    }
}
