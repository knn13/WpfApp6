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

namespace WpfApp6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Anstieg = Convert.ToDouble(anstieg.Text);
            double YAchsenAbschnitt = Convert.ToDouble(abschnitt.Text);
            linearefunktion f = new linearefunktion(Anstieg, YAchsenAbschnitt);
            string Ausgabe;
            Ausgabe = "Die Nullstelle ist x_n=" + f.berechneNullstelle() + "\n";
            Ausgabe += "Der Schnittpunkt mit der xAchse liegt bei: (" + f.berechneNullstelle() + "/ ";
            ausgabe.Text = Ausgabe;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double Anstieg = Convert.ToDouble(anstieg.Text);
            double YAchsenAbschnitt = Convert.ToDouble(abschnitt.Text);
            linearefunktion f = new linearefunktion(Anstieg, YAchsenAbschnitt);
            string Ausgabe="" ;
            Ausgabe = f.funktionswertberechnnen(Convert.ToDouble(xw.Text)).ToString();
            ausgabe.Text = Ausgabe;
        }
    }
}
