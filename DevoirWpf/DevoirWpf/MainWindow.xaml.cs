using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
      //  private ViewModel.Main _vm;
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
          //  _vm = new ViewModel.Main();// création d'une instance

           // DataContext = _vm; // DataContext est une propriété qui va déterminer le contexte pour les données

            //this.DataContext = "coucou";
            // this.DataContext = this;

            this.DataContext = new Employee { Age = 25, Name = "NOMEDE", FirstName = "Nydia" };
           
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
          
            MessageBox.Show((this.DataContext as Employee).Name);
            
           /* var message =
            $"Mon message: {sender.ToString()}\r\nSource: {e.Source}\r\r";
            MessageBox.Show(message, "event ! ");
            MessageBox.Show(App.Localized["msgPleaseEnterServerName"]);
            // La facon la plus simple de trouver un contenu dans ressources avec FindResource
            MessageBox.Show(FindResource("msgPleaseEnterServerName").ToString(), "avec un FindRessource");

            //extrait de code pour chercher un liens et mettre de la musique
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri("//C: /Users/stagiaire/Desktop/images/music.mp3"));
                mediaPlayer.Play();
            }
            e.Handled = true;*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {         
            MessageBox.Show((this.DataContext as Employee).Name = "DODO");
           
        }
    }
}
