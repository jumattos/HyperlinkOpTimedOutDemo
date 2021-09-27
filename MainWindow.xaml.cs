using System.Windows;
using System.Windows.Input;

namespace HyperlinkOpTimedOutDemo
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

        public static RoutedUICommand ShowDialogCommand
            = new RoutedUICommand("Show dialog",
                                  nameof(ShowDialogCommand),
                                  typeof(MainWindow));

        private void CanShowDialog(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ShowDialog(object target, ExecutedRoutedEventArgs e)
        {
            _ = MessageBox.Show(owner: this,
                messageBoxText: "Are you sure you want to continue?",
                caption: "Continue Confirmation",
                button: MessageBoxButton.YesNo,
                icon: MessageBoxImage.Information,
                defaultResult: MessageBoxResult.No);
        }
    }
}
