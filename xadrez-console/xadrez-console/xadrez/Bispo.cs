using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "B";
        }
    }
}