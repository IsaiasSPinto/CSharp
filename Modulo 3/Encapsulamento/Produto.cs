namespace Encapsulamento
{
    public class Produto
    {
        private string _nome;

        private double _preco;

        private int _quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
        }

        public override string ToString()
        {
            return _nome +
            ", $ " +
            _preco
                .ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture) +
            ", " +
            _quantidade +
            " unidades, Total: $ " +
            ValorTotalEmEstoque()
                .ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture);
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (!String.IsNullOrEmpty(nome))
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
    }
}
