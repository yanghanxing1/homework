
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using TextEditor.ViewModel;

namespace TextEditor
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplicationClose(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
    }
}