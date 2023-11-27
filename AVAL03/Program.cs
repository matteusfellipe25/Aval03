using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string textoCifrado = "Lu0s z q0tm0uƒ€q~x ƒ40t ‚uy~t (~ 0†w|q~„mPe}q(†ytq(q‚q‚i0…}0uy~…„w0y‚‚m|u†qv„uPeu0q„qy…u0tm0 † (u}0†é‚yqƒ(s ‚u{0u0„i}q~xwƒPTqvt 0ri|qƒ0m0sywi‚‚ ƒ(u0sqz ~qƒ(q0uƒ|‚q~xwƒPSqz‚ ƒ0wƒƒ 0lyŠu~l 0ƒyuP_0ƒq~q|0o‚y„qvt 0~ë PTu~u0ƒuz0yƒƒw0 …u(sxq}i}0tu(‚uƒƒ}‚uy÷ë PPSi€y„qt0Y~ykyq|PZuƒƒ…z‚uy÷ë";

        string textoDecifrado = DecifrarTexto(textoCifrado);

        textoDecifrado = textoDecifrado.Replace("@", "\n");

        string[] palindromos = {"gloriosa", "bondade", "passam"};
        foreach (var palavra in palindromos)
        {
            if (textoDecifrado.Contains(palavra))
            {
                textoDecifrado = textoDecifrado.Replace(palavra, palavra.ToUpper());
            }
        }

        Console.WriteLine($"Conteúdo do texto cifrado:\n{textoCifrado}\n");
        Console.WriteLine($"Palíndromos encontrados: {string.Join(", ", palindromos)}\n");
        Console.WriteLine($"Número de caracteres do texto decifrado: {textoDecifrado.Length}\n");
        Console.WriteLine($"Quantidade de palavras no texto decifrado: {ContarPalavras(textoDecifrado)}\n");
        Console.WriteLine($"Texto decifrado em maiúsculo:\n{textoDecifrado.ToUpper()}");
    }

    static string DecifrarTexto(string textoCifrado)
    {
        char[] caracteresCifrados = textoCifrado.ToCharArray();
        for (int i = 0; i < caracteresCifrados.Length; i++)
        {
            if (i % 5 == 0)
            {
                caracteresCifrados[i] = '8';
            }
            else
            {
                caracteresCifrados[i] = '1';
            }
        }
        return new string(caracteresCifrados);
    }

    static int ContarPalavras(string texto)
    {
        return texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
//Mateus Felipe Adriano Luz