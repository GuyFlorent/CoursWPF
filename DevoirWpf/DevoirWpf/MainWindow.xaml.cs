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

namespace DevoirWpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel.Main _vm;
        
        public MainWindow()
        {
            InitializeComponent();
            _vm = new ViewModel.Main();// création d'une instance
            DataContext = _vm; // DataContext est une propriété qui va déterminer le contexte pour les données
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            
            var message =
            $"Mon message: {sender.ToString()}\r\nSource: {e.Source}\r\r";
            MessageBox.Show(message, "event ! ");
            MessageBox.Show(App.Localized["msgPleaseEnterServerName"]);
            // La facon la plus simple de trouver un contenu dans ressources avec FindResource
            MessageBox.Show(FindResource("msgPleaseEnterServerName").ToString(), "avec un FindRessource");
            e.Handled = true;
        }

    }
}
