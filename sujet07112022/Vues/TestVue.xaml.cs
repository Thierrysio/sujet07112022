using sujet07112022.VueModeles;

namespace sujet07112022.Vues;

public partial class TestVue : ContentPage
{
    TestVueModele  vueModele;
    public TestVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new TestVueModele();
	}
}