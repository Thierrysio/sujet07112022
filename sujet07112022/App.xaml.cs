using sujet07112022.Vues;

namespace sujet07112022;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TestVue();
	}
}
