# TDE 01 · Programação Mobile

Dois aplicativos independentes feitos em C# e XAML com .NET MAUI.

| Projeto | O que faz | Exemplo |
| --- | --- | --- |
| **Distance** | Calcula a distância euclidiana entre dois pontos no plano, usando X₁, Y₁, X₂ e Y₂. | A = (0, 0), B = (3, 4) resulta em **5**. |
| **Bhaskara** | Calcula o delta e apresenta uma raiz, duas raízes ou a mensagem de ausência de raízes reais. | A = 1, B = −3, C = 2 resulta em **Δ = 1**, **x₁ = 2** e **x₂ = 1**. |

Os campos aceitam números com vírgula ou ponto decimal. Os aplicativos indicam campos vazios ou inválidos. A calculadora de Bhaskara também verifica se A é diferente de zero.

## Como rodar

Abra `TDE1.Mobile.slnx` no Visual Studio com .NET 10 e a carga de trabalho .NET MAUI. Selecione **Distance** ou **Bhaskara** como projeto de inicialização e execute no Windows ou em um dispositivo Android.

Para compilar para Android, coloque a solução em um caminho sem acentos, como `C:\Projetos\TDE1-Mobile`. O empacotador Android pode falhar se houver caracteres fora de ASCII no caminho. [Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/android/messages/apt2265)

## Materiais de aula

O aplicativo **Distance** reaproveita a estrutura e o ícone do [projeto de aula](https://drive.google.com/file/d/101NFjL9R7BxQ5pJc6pRClv7xaPhQcCKT/view). As entradas e a fórmula foram adaptadas para o plano 2D conforme o [enunciado](https://drive.google.com/file/d/1mEmwJDbZTMSY2pdSmoWM_yNRjAThrnug/view). O aplicativo **Bhaskara** usa o ícone e a imagem da fórmula fornecidos na [pasta do TDE 01](https://drive.google.com/drive/folders/1pxLfbYCWmnRr6_XO7J_voJEMJgsATH7P).
