using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Xml;

namespace WpfApplication1
{
    /// <summary>D
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Uri iconUri = new Uri("pack://application:,,,/theme/icon.png");
            this.Icon = BitmapFrame.Create(iconUri);
            LoadEditorWithSyntax();
        }

        private void LoadEditorWithSyntax()
        {
            MainTextEditor.ShowLineNumbers = true;
            /*StreamResourceInfo sri = Application.GetResourceStream(new Uri("pack://application:,,,/lua.xml"));
            using (Stream XMLStream = sri.Stream)
            {
                XmlTextReader XMLRead = new XmlTextReader(XMLStream);
                //TextEditor.SyntaxHighlighting = HighlightingLoader.Load(XMLRead, HighlightingManager.Instance);
                XMLRead.Close();
                XMLStream.Close();
            }*/
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 sh1 = new Window2();
            sh1.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            about ab1 = new about();
            ab1.Show();
        }

        private void AddNewTabBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TabItem NewTab = new TabItem()
            {
                Header = "New Tab" + (MaintabControl.Items.Count + 1)
            };
            TextEditor NewEditor = new TextEditor()
            {
                SyntaxHighlighting = MainTextEditor.SyntaxHighlighting,
                Background = MainTextEditor.Background,
                FontFamily = MainTextEditor.FontFamily,
                Foreground = MainTextEditor.Foreground,
                FontSize = MainTextEditor.FontSize,
                FontWeight = MainTextEditor.FontWeight,
                ShowLineNumbers = MainTextEditor.ShowLineNumbers,
                Name = MainTextEditor.Name
            };
            MaintabControl.Items.Add(NewTab);
            NewTab.Content = NewEditor;
            MaintabControl.SelectedItem = NewTab;
        }

        private void CloseTabs_Click(object sender, RoutedEventArgs e)
        {
            if (MaintabControl.Items.Count >= 2)
            {
                TabItem MyTabToClose = MaintabControl.SelectedItem as TabItem;
                MaintabControl.Items.Remove(MyTabToClose);
            }
        }

        private void AddNewTabBtn_MouseLeftButtonUp(object sender, RoutedEventArgs e)
        {
            TabItem NewTab = new TabItem()
            {
                Header = "New Tab" + (MaintabControl.Items.Count + 1)
            };
            TextEditor NewEditor = new TextEditor()
            {
                SyntaxHighlighting = MainTextEditor.SyntaxHighlighting,
                Background = MainTextEditor.Background,
                FontFamily = MainTextEditor.FontFamily,
                Foreground = MainTextEditor.Foreground,
                FontSize = MainTextEditor.FontSize,
                FontWeight = MainTextEditor.FontWeight,
                ShowLineNumbers = MainTextEditor.ShowLineNumbers
            };
            MaintabControl.Items.Add(NewTab);
            NewTab.Content = NewEditor;
            MaintabControl.SelectedItem = NewTab;
        }

        private void RegClick_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }

        private void SetClick_Click(object sender, RoutedEventArgs e)
        {
            settings opt = new settings();
            opt.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MaintabControl.Items.Count >= 2)
            {
                TextEditor NewEditor = new TextEditor()
                {
                    SyntaxHighlighting = MainTextEditor.SyntaxHighlighting,
                    Background = MainTextEditor.Background,
                    FontFamily = MainTextEditor.FontFamily,
                    Foreground = MainTextEditor.Foreground,
                    FontSize = MainTextEditor.FontSize,
                    FontWeight = MainTextEditor.FontWeight,
                    ShowLineNumbers = MainTextEditor.ShowLineNumbers
                };
                TabItem MyTabToClose = MaintabControl.SelectedItem as TabItem;
                MyTabToClose.Content = NewEditor;
            }
        }
    }
}

