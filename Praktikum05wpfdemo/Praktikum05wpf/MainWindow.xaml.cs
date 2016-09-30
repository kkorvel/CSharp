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

namespace Praktikum05wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ListInimesed _inimesed;

        public MainWindow()
        {
            InitializeComponent();
            txtEesnimi.Text = "Peeter";
            txtPerenimi.Text = "Käru";
            txtPikkus.Text = "175cm";
            _inimesed = new ListInimesed();
        }

        private void btnLisa_Click(object sender, RoutedEventArgs e)
        {
            Inimene uusInimene = new Inimene();
            {
            Eesnimi = txtEesnimi.Text;
            Perenimi = txtPerenimi;
                Pikkus = int.Parse(txtPikkus.Text);
                
            }
            

        // List <Inimene> inimesed = new List<Inimene>();


            lboxInimesed.Items.Refresh();
        }

        public int Pikkus { get; set; }

        public TextBox Perenimi { get; set; }

        public string Eesnimi { get; set; }

        private void lboxInimesed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lboxInimesed.SelectedIndex > -1)
            {
                Inimene valitud = lboxInimesed.SelectedItem as Inimene;
                if (valitud != null)
                {
                    txtEesnimi.Text = valitud.Eesnimi;
                    txtPerenimi.Text = valitud.Perenimi;
                    txtPikkus.Text = valitud.Pikkus.ToString();
                    btnLisa.Content = "Muuda";

                }


            }



        }
    }
}
