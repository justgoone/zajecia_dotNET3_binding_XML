using System;
using System.Collections;
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
using System.Xml;

namespace NET_PR2._1_z3
{
    /// <summary>
    /// Logika interakcji dla klasy MarkiPojazdów.xaml
    /// </summary>

    public partial class MarkiPojazdów : Window
    {
        ListBox lista;
        public MarkiPojazdów(XmlElement kategoria)
        {
            DataContext = kategoria;
            InitializeComponent();
            lista = (ListBox)FindName("Podkategorie");
        }

        private void WidokDetali(object sender, RoutedEventArgs e)
        {
        
           XmlElement wybrana = (XmlElement)lista.SelectedItem;
           new KategoriaWidok(wybrana)
               .Show();
        
        }
    }
}
