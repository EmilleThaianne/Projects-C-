using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Podcast;

public class Episodio
{
    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;

    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }

    public void MinutosDuracao(int seg)
    {
        int minutos = seg / 60;
        int seg2 = seg % 60;
        string result = $"Duração: {minutos} minutos e  {seg2} segundos.\n";
        Console.WriteLine(result);
    }

    public List<string> Convidados { get; } = new List<string>();

    public void AdicionarConvidados(string nomeConvidado)
    {
        Convidados.Add(nomeConvidado);
    }

    public string ObterResumo()
    {
        int minutos = Duracao / 60;
        int segundos = Duracao % 60;
        string resumo = ($"{Ordem}. {Titulo} ({minutos} min {segundos} seg) - ");
        if (Convidados.Any())
        {
            resumo += string.Join(", ", Convidados);
        }
        return resumo;
    }
}

