using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace poznámkovy_blok
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



        private void MenuItem_Otevri_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog otvorSoubor = new OpenFileDialog();

            if (otvorSoubor.ShowDialog() == true)
            {
                string danejsoubor = otvorSoubor.FileName;

                ObsahSouboru.Text = File.ReadAllText(danejsoubor);

            }
        }



        private void MenuItem_Uloz_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog ulozSoubor = new SaveFileDialog();

            if (ulozSoubor.ShowDialog() == true)
            {
                string danejsoubor = ulozSoubor.FileName;

                File.WriteAllText(danejsoubor, ObsahSouboru.Text);
            }
        }

        private void Buttonmax(object sender, RoutedEventArgs e)
        {
            ObsahSouboru.FontSize += 2;
        }

        private void Buttonmin(object sender, RoutedEventArgs e)
        {
            ObsahSouboru.FontSize -= 2;
        }

        private void Buttontrash(object sender, RoutedEventArgs e)
        {
            ObsahSouboru.Clear();
        }

        private void Buttonamount(object sender, RoutedEventArgs e)
        {
            int pocetZnaku = ObsahSouboru.Text.Length;
            MessageBox.Show("znaky: " + pocetZnaku.ToString());
        }
        private void ObsahSouboru_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
         
        }
    }
}
