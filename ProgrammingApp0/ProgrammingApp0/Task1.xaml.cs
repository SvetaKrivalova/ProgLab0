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
using System.Windows.Shapes;

namespace ProgrammingApp0
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        double VolumeBall, VolumeCube, WastePercentage, Radius, Side;

        private void runtask1_Click(object sender, RoutedEventArgs e)
        {
             if(Radius > Side/2 || InputRadius.Text.Length < 1 || InputSide.Text.Length < 1)
            {
                MessageBox.Show("Введены неверные данные");
            }
            else
            {
                 Radius = Convert.ToDouble(InputRadius.Text);
                Side = Convert.ToDouble(InputSide.Text);
                VolumeBall = 4 / 3 * Math.PI * Math.Pow(Radius, 3);
                VolumeCube = Math.Pow(Side, 3);
                WastePercentage = (VolumeCube - VolumeBall) * 100;
                MessageBox.Show($"Объем шара: {VolumeBall}\nОбъем куба: {VolumeCube}\nПроцент от отходов: {WastePercentage}");
                InputSide.Clear();
                InputRadius.Clear();
            }
          
        }

        private void InputSide_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (InputSide.Text.Length > 0)
            {
                if (!double.TryParse(InputSide.Text, out Side))
                {
                    MessageBox.Show("Введены неверные данные");
                    InputSide.Clear();
                }
            }
        }

        private void InputRadius_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (InputRadius.Text.Length > 0)
            {
                if (!double.TryParse(InputRadius.Text, out Radius))
                {
                    MessageBox.Show("Введены неверные данные");
                    InputRadius.Clear();
                }
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        
    }
}
