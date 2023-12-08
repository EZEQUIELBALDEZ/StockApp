using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAccess.Database
{
    public partial class DatabaseService
    {
        public void CriarTabelaCategoria()
        {
            var sql = @"
                        CREATE TABLE Categoria 
                        (
                        	idcategoria INT IDENTITY(1,1) PRIMARY KEY,
                        	nome VARCHAR(100) NOT NULL,
                           	telefone VARCHAR(45) 
                        )
                        ";
            try
            {
                using (var conexao = new SqlConnection(SqlServerContext.ConexaoSemBanco))
                {
                    var resultado = conexao.Execute(sql);
                }

            }
            catch (Exception)
            {
                throw;
            }
            throw new NotImplementedException();
        }
      
    }
}
