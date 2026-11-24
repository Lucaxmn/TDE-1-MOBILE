using System.Globalization;

namespace Tde01;

internal static class Numeros
{
    private static readonly CultureInfo Cultura = CultureInfo.GetCultureInfo("pt-BR");

    public static bool TentarLer(string? texto, out double valor) =>
        (double.TryParse(texto, NumberStyles.Float, Cultura, out valor) ||
         double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out valor)) &&
        double.IsFinite(valor);

    public static bool TentarLerDecimal(string? texto, out decimal valor) =>
        decimal.TryParse(texto, NumberStyles.Float, Cultura, out valor) ||
        decimal.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out valor);

    public static string Formatar(double valor) =>
        (valor == 0 ? 0 : valor).ToString("G12", Cultura);
}
