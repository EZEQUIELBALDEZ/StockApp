using StockApp.Busines.Entties;
using StockApp.Busines.Interface;
using StockApp.DataAccess.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.WindowsForms.Cadastros
{
    public partial class frmCategoria : Form
    {
        private readonly ICategoriaRepository _categoriaRepositorio;
        public frmCategoria()
        {
            InitializeComponent();
            _categoriaRepositorio = new CategoriaRepositorio();

        }
      
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novaCategoria = new Categoria();
            novaCategoria.Nome = txtCategoria.Text;
            novaCategoria.Status = chkStatus.Checked;

            var resultado = _categoriaRepositorio.Incluir(novaCategoria);
            if (resultado)
            {
                MessageBox.Show("Usuario cadastrado com Sucesso!!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastra Tente Novamente");
            }
        }
    }
}
