﻿class Musica
{
    // Variaveis
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida
    {
        get
        {
            return $"A música {Nome} pertence a banda {Artista}";
        }
    }

    public void ExibirFichaTécnica()
    {
        Console.WriteLine(DescricaoResumida);
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}