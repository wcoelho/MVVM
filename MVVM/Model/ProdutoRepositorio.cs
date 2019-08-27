using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    class ProdutoRepositorio
    {
        // uma lista de produtos para simular os dados
        private Produto[] produtos = new[]
        {
            new Produto { Id = 1, Nome = "Camisa", Preco = 39.99f },
            new Produto { Id = 2, Nome = "Sapato", Preco = 95.99f },
            new Produto { Id = 3, Nome = "Blusa", Preco = 49.99f },
        };
        public async Task<Produto[]> ProcuraProdutos(string criterio)
        {
            System.Console.WriteLine("@Entrei no Model");
            // Aguarda 2 segundos para simular uma requisição
            await Task.Delay(2000);
            // Usando Linq-to-objects para procurar
            criterio = criterio.ToLower();
            var prodList = produtos.Where(p => p.Nome.ToLower().Contains(criterio)).ToArray();
            System.Console.WriteLine("@Saí do Model");
            return prodList;
        }
    }
}
