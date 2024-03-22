using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Podcast;

internal class Podcast
{
    private List<Episodio> ListEpisodios = new List<Episodio>();
    public Podcast(string nome, int host)
    {
        Nome = nome;
        Host = host;
    }
    public int Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => ListEpisodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        ListEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O nome do Podcast: {Nome} ");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Lista:");

        foreach (var episodio in ListEpisodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Episódio: {episodio.ObterResumo()}");
        }
        Console.WriteLine($"\nO Total de Episódio do Podcast {Nome} é: {ListEpisodios.Count} episódios.");
    }

}