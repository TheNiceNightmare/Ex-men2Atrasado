using Exámen2.ViewModels;

namespace Exámen2.Views;

public partial class Calcular : ContentPage
{
    public Calcular(CalcularViewModels calcularViewModels)
    {
        InitializeComponent();
        BindingContext = CalcularViewModels;
    }
}