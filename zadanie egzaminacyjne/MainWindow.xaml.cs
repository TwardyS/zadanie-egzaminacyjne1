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

namespace zadanie_egzaminacyjne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Filip Twardowski
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string male = "zxcvbnmasdfghjklqwertyuiop";
            string duze = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string zanki_specjalne = "!@#$%^&*()_+-=";
            int liczby =1234567890 ;

        }

        private void button_haslo_Click(object sender, RoutedEventArgs e)
        {
            if (button_haslo = true) 
            {

            }
        }

        private void button_zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(("dane pracownika: ")+text1.Text + (",") + text2.Text + (",") + moje_combo.Text);
        }
    }
}