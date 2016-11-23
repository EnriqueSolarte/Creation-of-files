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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExternalFile
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

        private void buttonWrite_Click(object sender, RoutedEventArgs e)
        {
            TextRange allTextRange = new TextRange(this.richTextBoxSourceWrite.Document.ContentStart,
                richTextBoxSourceWrite.Document.ContentEnd);

            string allText = allTextRange.Text;
            File.WriteAllText("text.prf", allText);
        }

        private void buttonRead_Click(object sender, RoutedEventArgs e)
        {
            string allText = File.ReadAllText("text.prf");
            this.richTextBoxSourceRead.AppendText(allText);

        }
    }
}
