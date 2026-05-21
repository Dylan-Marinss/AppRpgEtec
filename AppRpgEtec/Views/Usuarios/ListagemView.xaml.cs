using AppRpgEtec.ViewModels.Usuarios;

namespace AppRpgEtec.Views.Usuarios;

public partial class ListagemView : ContentPage
{
	LocalizacaoViewModel viewModel;
	public ListagemView()
	{
		InitializeComponent();

		viewModel = new LocalizacaoViewModel();
		viewModel.InicializarMapa();
	}
}