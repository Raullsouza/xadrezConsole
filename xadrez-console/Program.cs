using tabuleiro;
using xadrez;
using exceptions;

try { 
Tabuleiro tab = new(8, 8);
tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
tab.colocarPeca(new Torre(tab, Cor.Amarela), new Posicao(4, 7));
tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(1, 3));
tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 4));

Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e) {
    Console.WriteLine(e.Message);
}

Console.ReadLine();