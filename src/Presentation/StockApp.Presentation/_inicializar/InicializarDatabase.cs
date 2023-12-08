using StockApp.Busines.Interface.Database;
using StockApp.DataAccess.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.WindowsForms._inicializar
{
    internal  class InicializarDatabase
    {
        private readonly IDataBaseService _databaseService;



        public InicializarDatabase() 
        {
            _databaseService = new DatabaseService();

        }
        internal void Init()
        {
            _databaseService.CriarBanco();                                                                 
        }  
    }
}
