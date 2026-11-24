using Tde01;

namespace Bhaskara;

public partial class MainPage : ContentPage
{
    public MainPage() => InitializeComponent();

    private void CalcularRaizes_Clicked(object? sender, EventArgs e)
    {
        Erro.IsVisible = false;
        Resultado.IsVisible = false;

        if (!Numeros.TentarLerDecimal(A.Text, out decimal a) ||
            !Numeros.TentarLerDecimal(B.Text, out decimal b) ||
            !Numeros.TentarLerDecimal(C.Text, out decimal c))
        {
            MostrarErro("Preencha A, B e C com números válidos.");
            return;
        }

        if (a == 0)
        {
            MostrarErro("A deve ser diferente de zero para a equação ser de segundo grau.");
            return;
        }

        decimal delta;
        try
        {
            delta = b * b - 4 * (a * c);
        }
        catch (OverflowException)
        {
            MostrarErro("O delta está fora do intervalo numérico do aplicativo.");
            return;
        }

        ValorDelta.Text = $"Δ = {Numeros.Formatar((double)delta)}";
        if (delta < 0)
        {
            Raizes.Text = "A equação não possui raízes reais.";
        }
        else if (delta == 0)
        {
            double raiz = (-(double)b / 2) / (double)a;
            Raizes.Text = $"x = {Numeros.Formatar(raiz)}";
        }
        else
        {
            // Calcula a raiz que evita a subtração de números muito próximos.
            // Obtém a outra pelo produto das raízes, c/a.
            double coeficienteB = (double)b;
            double numerador = -coeficienteB / 2 - Math.CopySign(Math.Sqrt((double)delta) / 2, coeficienteB);
            double raizPrincipal = numerador / (double)a;
            double outraRaiz = (double)c / numerador;
            var (x1, x2) = double.IsNegative(coeficienteB) ? (raizPrincipal, outraRaiz) : (outraRaiz, raizPrincipal);
            Raizes.Text = $"x₁ = {Numeros.Formatar(x1)}\nx₂ = {Numeros.Formatar(x2)}";
        }

        Resultado.IsVisible = true;
    }

    private void MostrarErro(string mensagem)
    {
        Erro.Text = mensagem;
        Erro.IsVisible = true;
    }
}
