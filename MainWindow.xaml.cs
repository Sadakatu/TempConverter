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

namespace BasicWPF
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

        private void Button_Convert_Click(object sender, RoutedEventArgs e)
        {
            if (Input_Value.Text == "")
            {
                Input_Value.Text = "0";
            }

            double Val = Convert.ToDouble(Input_Value.Text);

            if (Select_Unit.SelectedIndex == 0)
            {
                Output_Result.Text = Convert.ToString(Math.Round(ToCelsius(Val), 2)) + "°c";
            }
            else
            {
                Output_Result.Text = Convert.ToString(Math.Round(ToFahrenheit(Val), 2)) + "°f";
            }
        }

        private double ToFahrenheit(double Value)
        {
            return ((Value * 9) / 5) + 32;
        }

        private double ToCelsius(double Value)
        {
            return ((Value - 32) * 5) / 9;
        }
    }
}
