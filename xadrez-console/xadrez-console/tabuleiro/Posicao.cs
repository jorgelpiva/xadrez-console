
    class Posicao
    {
        public int linha { get; set; }
        public int coluna;

        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        public override string ToString()
        {
            return linha + ", " + coluna;
        }
    }

