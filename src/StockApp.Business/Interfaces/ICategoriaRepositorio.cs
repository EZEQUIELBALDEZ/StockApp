using StockApp.Business.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Interfaces
{
    public interface ICategoriaRepositorio
    {
        bool Incluir(int id, string nome, bool status);
        bool Atualizar(Categoria categoria);
        bool Remover(int id);
        bool Ativar(int id);
        bool Inativar(int id);
        bool Incluir(Categoria novaCategoria);
    }
}
