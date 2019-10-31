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
using System.Collections.ObjectModel;

namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Color> Colores = new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            Colores.Add(new Color("Rojo", "#FF0000", "(255,0,0)"));
            Colores.Add(new Color("Verde", "#00FF00", "(0,255,0)"));
            Colores.Add(new Color("Azul", "#0000FF", "(0,0,255)"));

            lstColores.ItemsSource = Colores;
            
        }

        private void btnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
            /*Colores.Add(txtbox1.Text);
            txtbox1.Text = "";*/

            Colores.Add(new Color(txtbox1.Text, txtbox2.Text, txtbox3.Text));
            txtbox1.Text = "";
            txtbox2.Text = "";
            txtbox3.Text = "";

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(lstColores.SelectedIndex != -1)
            {
                Colores.RemoveAt(lstColores.SelectedIndex);
            }
        }

        private void lstColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            { 
            txtboxNombreA.Text = Colores[lstColores.SelectedIndex].Nombre;
            txtboxHexA.Text = Colores[lstColores.SelectedIndex].Hexadecimal;
            txtboxRgbA.Text = Colores[lstColores.SelectedIndex].RGB;
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores[lstColores.SelectedIndex].Nombre = txtboxNombreA.Text;
                Colores[lstColores.SelectedIndex].Hexadecimal = txtboxHexA.Text;
                Colores[lstColores.SelectedIndex].RGB = txtboxRgbA.Text;
            }
        }
    }
}
