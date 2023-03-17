namespace BugExample.MCTMediaElement;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new BuggedPage());
	}
}

