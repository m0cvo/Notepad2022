using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Notepad2022
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Current.Shutdown();
        }

        private void FileBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /// ToDo
        }

        private void NewClick_Selected(object sender, RoutedEventArgs e)
        {
            UserTxt.Clear();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|CPP Files (*.cpp)|*.cpp|C# files (*.cs)|*.cs|Visual Basic (*.vb)|*.vb|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                UserTxt.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void ExitList_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Current.Shutdown();
        }

        private void SaveTxt_Selected(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|CPP Files (*.cpp)|*.cpp|C# files (*.cs)|*.cs|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, UserTxt.Text);
        }

        private void AboutList_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Notepad2022 text editor Copyright Nigel Booth, M0CVO, for Mogpie, 2022");
        }

        private void HelpList_Selected(object sender, RoutedEventArgs e)
        {
            Window2 HelpWin = new Window2();
            HelpWin.Show();
        }
    }
}
