using Prism.Commands;
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

            TestCommand = new DelegateCommand(this.OnTest);
        }

        public ICommand TestCommand { get; set; }
        void OnTest()
        {
            MessageBox.Show("Test OK!");
        }

        private Storyboard VisibilitySB
        {
            get
            {
                return this.FindResource("SB_Visibility") as Storyboard;
            }
        }

        private Storyboard CollapsedSB
        {
            get
            {
                return this.FindResource("SB_Collapsed") as Storyboard;
            }
        }


        bool flag = false;

        private void ImageRadioButton_Click(object sender, RoutedEventArgs e)
        {
            //折叠
            if (flag)
            {
                flag = false;
                if (this.stackpanel.Visibility != Visibility.Collapsed)
                {
                    this.stackpanel.Visibility = Visibility.Collapsed;
                }
            }
            else//展开
            {
                flag = true;
                if (this.stackpanel.Visibility != Visibility.Visible)
                {
                    this.stackpanel.Visibility = Visibility.Visible;
                }
            }
        }

        private void ImageRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            this.stackpanel.Visibility = Visibility.Collapsed;
            flag = false;
        }

        bool check = false;
        private void ImageRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (!check)
            {

                this.stackpanel.Visibility = Visibility.Visible;
                //flag = true;

                check = true;
            }


        }
    }
}
