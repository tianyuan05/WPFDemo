using Prism.Commands;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace WPFDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            combobox.ItemsSource = list;
        }
        List<string> list = new List<string> { "1", "2", "3" };




        public ICommand TestCommand { get; set; }
        void OnTest()
        {
            MessageBox.Show("Test OK!");
        }


        private void ImageRadioButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ImageRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            this.stackpanel.Visibility = Visibility.Collapsed;

        }


    }
}
