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
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Sa = Convert.ToInt32(Number.Text) * Convert.ToInt32(Number.Text);
            int P = Convert.ToInt32(Number.Text) * 2;
            S.Text = Convert.ToString(Sa);
            Per.Text = Convert.ToString(P);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int Number = random.Next(0, 100);
            Random.Text = Convert.ToString(Number);

            int One = Number / 10;
            Random1.Text = Convert.ToString(One);

            int Two = Number % 10;
            Random2.Text = Convert.ToString(Two);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select a Photo";

            if (openFileDialog.ShowDialog() == true)
            {
                MyImage.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(openFileDialog.FileName));
             
            }
        }
    

}
    

}
