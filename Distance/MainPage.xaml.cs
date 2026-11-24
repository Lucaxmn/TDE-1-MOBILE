using Tde01;

namespace Distance;

public partial class MainPage : ContentPage
{
    public MainPage() => InitializeComponent();

    private void CalcularDistancia_Clicked(object? sender, EventArgs e)
    {
        Erro.IsVisible = false;
        Resultado.IsVisible = false;

        if (!Numeros.TentarLer(Ax.Text, out double ax) || !Numeros.TentarLer(Ay.Text, out double ay))
        {
            MostrarErro("Preencha X₁ e Y₁ do ponto A com números válidos.");
            return;
        }

        if (!Numeros.TentarLer(Bx.Text, out double bx) || !Numeros.TentarLer(By.Text, out double by))
        {
            MostrarErro("Preencha X₂ e Y₂ do ponto B com números válidos.");
            return;
        }

        double distancia = double.Hypot(bx - ax, by - ay);
        if (!double.IsFinite(distancia))
        {
            MostrarErro("A distância está fora do intervalo numérico do aplicativo.");
            return;
        }

        ValorDistancia.Text = Numeros.Formatar(distancia);
        Resultado.IsVisible = true;
    }

    private void MostrarErro(string mensagem)
    {
        Erro.Text = mensagem;
        Erro.IsVisible = true;
    }
}
