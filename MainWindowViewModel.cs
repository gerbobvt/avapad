
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace Avapad;
public class MainWindowViewModel : ObservableRecipient
{
    private string? _fileContents;
    public bool HasChanges {get;set;}

    public string FileName {get;private set;} = "test_file.txt";

    public string? FileContents {get => _fileContents; set => SetProperty(ref _fileContents, value);}

    public RelayCommand SaveCommand {get; }
    public RelayCommand SaveAsCommand {get;}
    public RelayCommand OpenCommand {get;}
    public RelayCommand NewCommand {get;}

    public MainWindowViewModel()
    {
        SaveCommand = new RelayCommand(() => Save(), () => HasChanges);
        SaveAsCommand = new RelayCommand(() => SaveAs());
        OpenCommand = new RelayCommand(() => Open());
        NewCommand = new RelayCommand(() => New());
    }

    private void Save()
    {

    }

    private void SaveAs() {}

    private void Open() {}

    private void New() {}
}