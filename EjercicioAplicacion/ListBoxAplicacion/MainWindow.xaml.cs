using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace ListBoxAplicacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<PoblacionSV> listaPob = new List<PoblacionSV>();

            listaPob.Add(new PoblacionSV() { Poblacion1 = "Apopa", Poblacion2 = "Soyapango", Temperatura1 = 19, Temperatura2 = 30, DiferenciaTemp=11 });
            listaPob.Add(new PoblacionSV() { Poblacion1 = "Ilopango", Poblacion2 = "Mejicanos", Temperatura1 = 22, Temperatura2 = 29, DiferenciaTemp=7 });
            listaPob.Add(new PoblacionSV() { Poblacion1 = "Nejapa", Poblacion2 = "Tonacatepeque", Temperatura1 = 20, Temperatura2 = 28, DiferenciaTemp=8 });
            listaPob.Add(new PoblacionSV() { Poblacion1 = "Cuscatancingo", Poblacion2 = "San Martin", Temperatura1 = 22, Temperatura2 = 23, DiferenciaTemp=1});
            Poblacion.ItemsSource = listaPob;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Poblacion.SelectedItem!= null) { 
            MessageBox.Show((Poblacion.SelectedItem as PoblacionSV).Poblacion1 + " " +
            (Poblacion.SelectedItem as PoblacionSV).Temperatura1 + "°C " +
            (Poblacion.SelectedItem as PoblacionSV).Poblacion2 + " " +
            (Poblacion.SelectedItem as PoblacionSV).Temperatura2 + "°C " );
            }
            else
            {
                MessageBox.Show("Selecciona una comparativa");
            }
           
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Poblacion.SelectedItem != null)
            {
                MessageBox.Show((Poblacion.SelectedItem as PoblacionSV).Poblacion1 + " " +
          (Poblacion.SelectedItem as PoblacionSV).Temperatura1 + "°C " +
          (Poblacion.SelectedItem as PoblacionSV).Poblacion2 + " " +
          (Poblacion.SelectedItem as PoblacionSV).Temperatura2 + "°C ");
            }
            else
            {
                MessageBox.Show("Selecciona una comparativa");
            }
        }
    }

    public class PoblacionSV
    {
        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int DiferenciaTemp { get; set; }

    }
}
