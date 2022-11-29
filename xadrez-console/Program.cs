using tabuleiro;
using xadrez;

Tabuleiro tab = new(8, 8);
tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));

Tela.ImprimirTabuleiro(tab);

Console.ReadLine();