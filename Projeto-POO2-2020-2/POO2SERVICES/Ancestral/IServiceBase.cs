using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2SERVICES.Ancestral
{
    public interface IServiceBase<TPoco> where TPoco : class
    {
        List<TPoco> ObterTodos();

        TPoco Obter(int id);

        TPoco Incluir(TPoco poco);

        TPoco Alterar(TPoco poco);

        TPoco Excluir(int id);
    }
}
