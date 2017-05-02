using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cys___Store.Assents.Forms.Sistema
{
    public partial class AddProduto : Form
    {
        public AddProduto()
        {
            InitializeComponent();
        }

        private void AddProduto_Load(object sender, EventArgs e)
        {
            
            Cys___Store.Classes.LoadDB load = new Classes.LoadDB();
            load.Load_Itens(Cat_prod, Sub_Prod);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            preco_prod.Clear();
            nome_prod.Clear();
            quantidade_prod.Value = 0;
            descricao_Prod.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(nome_prod.Text)) { MessageBox.Show("Nome do produto Vazio", "CYS ERRO AO CADASTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (preco_prod.Text == "" || !string.IsNullOrEmpty(preco_prod.Text)) { MessageBox.Show("Preço do produto Vazio", "CYS ERRO AO CADASTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (quantidade_prod.Value == 0) { MessageBox.Show("Quantidade produto Vazia", "CYS ERRO AO CADASTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           else
            {
                double valor = double.Parse(preco_prod.Text);
                string Categoria = Cat_prod.SelectedText;
                string SUBCategoria = Sub_Prod.SelectedText;
                

                Cys___Store.Classes.CRUD obj = new Classes.CRUD();
                //obj.AddProd(nome_prod.Text, valor, quantidade_prod.Value,Categoria,SUBCategoria, descricao_Prod.Text);
                 

            }
        }
    }
}
