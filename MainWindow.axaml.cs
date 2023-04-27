using Avalonia.Controls;

namespace Avapad;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var closeHandler = () => Close();

        DataContext = new MainWindowViewModel(closeHandler);
    }
}