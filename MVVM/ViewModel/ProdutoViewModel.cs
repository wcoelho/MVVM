using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Model;

namespace MVVM.ViewModel
{
    class ProdutoViewModel
    {
        private readonly ProdutoRepositorio repositorio = new ProdutoRepositorio();
        public string Criterio { get; set; }

        public Produto[] Produtos { get; private set; }

        public async Task Procurar()
        {
            System.Console.WriteLine("@Entrei no ViewModel");
            if (string.IsNullOrEmpty(Criterio))
                Produtos = null;
            else
                Produtos = await repositorio.ProcuraProdutos(Criterio);

            System.Console.WriteLine("@Saí do ViewModel");
                      
        }
    }
}
