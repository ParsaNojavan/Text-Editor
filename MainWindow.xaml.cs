using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.IO;
using Microsoft.Win32;

namespace Exercise_WPF
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LblStatus.Content = DateTime.Now.ToString(format: "yyyy/MM/dd - HH:mm:ss");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox TextBox = sender as TextBox;
            if (TextBox.Text != null)
            {
                LblStatus.Content = "Character : #" + TextBox.SelectionStart + ",";
                LblStatus.Content += "Character num : " + TextBox.SelectionLength + ",";
                LblStatus.Content += "Choosen text : '" + TextBox.SelectedText + "'";
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Textbox.Text);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (Textbox.Text.Length > 0)
            {
                Clipboard.SetText(Textbox.Text);
                Textbox.Text = null;
            }

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Textbox.Text = Clipboard.GetText();
            }
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Textbox.FontFamily = new System.Windows.Media.FontFamily("Rog Fonts");
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Textbox.FontFamily = new System.Windows.Media.FontFamily("Segoe UI");
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Textbox.FontFamily = new System.Windows.Media.FontFamily("Tw Cen MT");
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Textbox.FontFamily = new System.Windows.Media.FontFamily("Dubai");
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            string path = @"C:\\ParsaEditor";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            TextWriter txt = new StreamWriter("C:\\ParsaEditor\\NewText.txt");
            txt.Write(Textbox.Text);
            txt.Close();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                Textbox.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}