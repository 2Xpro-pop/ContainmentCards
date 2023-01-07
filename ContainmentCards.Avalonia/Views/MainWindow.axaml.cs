using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using ContainmentCards.Avalonia.ViewModels;

namespace ContainmentCards.Avalonia.Views;
public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Exit(object sender, RoutedEventArgs args)
    {
        Close();
    }
}
