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

namespace Notepad2022
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

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            //Shows goodbye message in MessageBox and then closes application.
            MessageBox.Show("Goodbye");
            Application.Current.Shutdown();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            //Opens new window for user to work on.
            Window1 WorkWindow = new Window1();
            WorkWindow.Show();
            this.Hide();
        }
    }
}
