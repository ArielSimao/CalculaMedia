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

namespace CalculaMedia
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

       

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resposta = MessageBox.Show("Voce Deseja Fechar Aplicação ? ", "Sair",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (resposta == MessageBoxResult.Yes) {
                Close();
                    } 
        }

       

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnCalcularMedia_Click(object sender, RoutedEventArgs e)
        {
            double N1, N2, Media;
            N1 = Convert.ToDouble(txtNota1.Text);
            N2 = Convert.ToDouble(txtNota2.Text);

            Media = (N1 + N2 / 2);

            txtMedia.Text = Convert.ToString(Media);

            if (Media>= 7)
            {
                MessageBox.Show("Aluno Aprovado", "Resultado",MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    else
                MessageBox.Show("Aluno Aprovado", "Resultado",MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}
