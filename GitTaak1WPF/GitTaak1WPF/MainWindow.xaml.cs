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

namespace GitTaak1WPF
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

        private void redImg_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush redColor = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            programWindow.Background = redColor;
        }

        private void redImg_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush defaultColor = new SolidColorBrush(Color.FromRgb(191, 191, 191));
            programWindow.Background = defaultColor;
        }

        private void yellowImg_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush yellowColor = new SolidColorBrush(Color.FromRgb(255, 255, 0));
            programWindow.Background = yellowColor;
        }

        private void yellowImg_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush defaultColor = new SolidColorBrush(Color.FromRgb(191, 191, 191));
            programWindow.Background = defaultColor;
        }

        private void greenImg_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush greenColor = new SolidColorBrush(Color.FromRgb(0, 80, 0));
            programWindow.Background = greenColor;
        }

        private void greenImg_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush defaultColor = new SolidColorBrush(Color.FromRgb(191, 191, 191));
            programWindow.Background = defaultColor;
        }

        private void blueImg_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush blueColor = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            programWindow.Background = blueColor;
        }

        private void blueImg_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush defaultColor = new SolidColorBrush(Color.FromRgb(191, 191, 191));
            programWindow.Background = defaultColor;
        }

        private void redImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "#FF0000";
            colorInformation.Text = "Rood is de kleur van warmte.";
        }

        private void yellowImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "#FFFF00";
            colorInformation.Text = "Geel is de kleur van levenslust.";
        }

        private void greenImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "#008000";
            colorInformation.Text = "Groen is de kleur van genezing.";
        }

        private void blueImg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = "#0000FF";
            colorInformation.Text = "Blauw is de kleur van intelligentie.";
        }
    }
}
