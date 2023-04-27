
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.ComponentModel;

namespace Avapad;
public class MainWindowViewModel : ObservableRecipient
{
    private string? _fileContents;
    private int _fontSize = 12;
    private readonly Action _closeHandler;

    public bool HasChanges { get; set; }

    public string FileName { get; private set; } = "test_file.txt";

    public string? FileContents { get => _fileContents; set => SetProperty(ref _fileContents, value); }

    public int FontSize { get => _fontSize; set => SetProperty(ref _fontSize, value); }

    public RelayCommand SaveCommand {get; }
    public RelayCommand SaveAsCommand {get;}
    public RelayCommand OpenCommand {get;}
    public RelayCommand NewCommand {get;}

    public RelayCommand HelpCommand {get;}

    public RelayCommand AboutCommand {get;}

    public RelayCommand CloseCommand {get;}

    public MainWindowViewModel(Action closeHandler)
    {
        _closeHandler = closeHandler;

        SaveCommand = new RelayCommand(() => Save(), () => HasChanges);
        SaveAsCommand = new RelayCommand(() => SaveAs());
        OpenCommand = new RelayCommand(() => Open());
        NewCommand = new RelayCommand(() => New());
        HelpCommand = new RelayCommand(() => ShowHelp());
        AboutCommand = new RelayCommand(() => ShowAbout());
        CloseCommand = new RelayCommand(() => CloseApplication());
    }

    private void CloseApplication()
    {
        throw new NotImplementedException();
    }

    private void Save()
    {

    }

    private void SaveAs() {}

    private void Open() {}

    private void New() {}

    private void ShowHelp() {}

    private void ShowAbout() {}
}