namespace ShellTest;

public partial class AppShell : Shell
{
	public AppShell()
	{
        var backButtonBehavior = new BackButtonBehavior
        {
            IsEnabled = false
        };
        Shell.SetBackButtonBehavior(this, backButtonBehavior);
        InitializeComponent();
        Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
    }
}

