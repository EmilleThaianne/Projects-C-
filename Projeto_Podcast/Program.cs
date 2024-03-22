using Projeto_Podcast;

Podcast podcast = new Podcast("Inteligência Ltda.", 1);

Episodio episodio1 = new Episodio("DIHH LOPES", 1, 7800);
episodio1.AdicionarConvidados("Dihh Lopes");
podcast.AdicionarEpisodio(episodio1);

Episodio episodio2 = new Episodio("MONARK", 2, 7000);
episodio2.AdicionarConvidados("Monark");
podcast.AdicionarEpisodio(episodio2);

Episodio episodio3 = new Episodio("NIL AGRA", 3, 2048);
episodio3.AdicionarConvidados("Nil Agra");
podcast.AdicionarEpisodio(episodio3);

Episodio episodio4 = new Episodio("VINHETEIRO & MUYLAERT ", 4, 1805);
episodio4.AdicionarConvidados("Vinheteiro");
episodio4.AdicionarConvidados("Muylaert");
podcast.AdicionarEpisodio(episodio4);

podcast.ExibirDetalhes();

Console.ReadKey();
