using System.Windows;

namespace WPF_Lwsson_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        int counter = 0;
        string txt_to_show = "Count";
        private void btn_to_change_txt_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            target_txt.Text = $"{txt_to_show} : {counter}";
        }

        private void btn_to_minus_Click(object sender, RoutedEventArgs e)
        {
            counter--;
            target_txt.Text = $"{txt_to_show} : {counter}";
        }
    }
}