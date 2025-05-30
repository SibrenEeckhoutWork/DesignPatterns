using Coderingen;
using System.Windows;
using System.Windows.Controls;

namespace CoderingenWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Helper helper;
        ICodering codering;

        public MainWindow()
        {
            helper = new Helper();
            InitializeComponent();            
            codering = helper["Blok"];
            Blok.IsChecked = true;
        }
  
        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            string type = button.Content.ToString();
            codering = helper[type];
            uitvoer.Text = codering.Codeer(invoer.Text);
        }

        private void Invoer_TextChanged(object sender, TextChangedEventArgs e)
        {
            uitvoer.Text = codering.Codeer(invoer.Text);
        }
    }
}
