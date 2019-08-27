using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class Program
    {
        static async void MainAsync(string[] args)
        {
            ProdutoViewModel prod = new ProdutoViewModel();
            await prod.Procurar();
        }
    }
}
