using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Playlist
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

      

        private void Button_Aggiungi_Brani(object sender, RoutedEventArgs e)
        {
            Brani brano = new Brani(Titolo.Text, Autore.Text,double.Parse(Durata.Text));
            Lista_CD.Items.Add(brano);


        }

        private void Button_Crea_CD(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < Lista_CD.Items.Count; i++)
            {
                CD cd = new CD(Titolo_CD.Text, Autore_CD.Text);
                cd.AggiungiBrano((Brani)Lista_CD.Items[i]);
            }
        }
    }
}