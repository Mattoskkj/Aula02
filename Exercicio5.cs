// -- Arquivo Exercicio1.cs
using System.Reflection.Metadata;

public static class Exercicio5
{
    public static void Executar()
    {
		    String nome = "joao mattos";
            string estilo = "Pagode";
            string banda = "Ferrugem";
		    
        Console.WriteLine(nome);
        Console.WriteLine(estilo);
        Console.WriteLine(banda);

        Console.WriteLine($"Eu sou {nome}, curto o estilo musical {estilo} e meu artista favorito desse estilo é {banda}.");
    }
}