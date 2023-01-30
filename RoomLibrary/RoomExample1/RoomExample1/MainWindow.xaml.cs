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
using RoomLibrary;

namespace RoomExample1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen1_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen2.IsEnabled = true;
            room1.RoomLenght = rnd.Next(2, 11);
            room1.RoonWidth = rnd.Next(2, 11);
            int numP = rnd.Next(1, 9);

            LabelLenght1.Content = room1.RoomLenght;
            LabelWidth1.Content = room1.RoonWidth;
            LabelNumPerson1.Content = numP;

            LabelPerimeter1.Content = room1.RoomPerimetr();
            LabelArea1.Content = room1.RoomArea();
            LabelPersonAsea1.Content = room1.PersonArea(numP);
        }

        private void ButtonOpen2_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
