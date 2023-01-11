using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ContainmentCards.Avalonia.ViewModels;
using ContainmentCards.Avalonia.Views;

namespace ContainmentCards.Avalonia;
public partial class App : Application
{
    public const string MenuMusic = "SKG Records - Sabotage - Official Music.ogg";
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
