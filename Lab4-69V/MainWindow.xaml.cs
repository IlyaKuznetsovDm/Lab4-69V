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

namespace Lab4_69V
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;
        private Hyperbola hyperbola;
        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ellipse = new Ellipse(double.Parse(One.Text),
                                      double.Parse(Two.Text),
                 double.Parse(Three.Text),
                 double.Parse(Four.Text));
            RES1.Text = ellipse.Print();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hyperbola = new Hyperbola(double.Parse(HyperOne.Text),
                                      double.Parse(HyperTwo.Text),
                 double.Parse(HyperThree.Text),
                 double.Parse(HyperFour.Text));
            RES2.Text = hyperbola.Print();
        }
    }
}
