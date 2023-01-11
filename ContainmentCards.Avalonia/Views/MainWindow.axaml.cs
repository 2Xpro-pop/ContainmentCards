using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using Bassoon;
using ContainmentCards.Avalonia.ViewModels;

namespace ContainmentCards.Avalonia.Views;
public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected async override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);

        var snd = new Sound(App.MenuMusic)
        {
            Volume = 0.85f
        };
        snd.Play();
    }


    public void Exit(object sender, RoutedEventArgs args)
    {
        Close();
    }
}
