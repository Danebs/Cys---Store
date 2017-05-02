using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Cys___Store.Assents.Forms.Sistema;

namespace Cys___Store 
{
    public partial class CYS_STORE : Form 
    {
        public CYS_STORE()
        {
            InitializeComponent();
            SplashScreen splash = new SplashScreen();
            Cys___Store.Classes.CRUD login = new Classes.CRUD();
            
            splash.Show();
            if (login.confirma == true)
            {
                splash.Close();
                return;
            }
        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            DialogResult resul = MessageBox.Show("Deseja mesmo sair do sistema ?", "CYS STORE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes) { Application.Exit(); }

        }

        private void dadosLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cys___Store.Assents.Forms.Abouts.SobreLoja lj = new Assents.Forms.Abouts.SobreLoja();

            lj.Show();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cys___Store.Assents.Forms.Abouts.SobreEmpresa emp = new Assents.Forms.Abouts.SobreEmpresa();
            emp.Show();
        }

        private void venderProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vender vnd = new Vender();
            vnd.MdiParent = this;
            vnd.Show(); 
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cys___Store.Assents.Forms.Sistema.Inicio ini = new Assents.Forms.Sistema.Inicio();
            ini.MdiParent = this;
            ini.ControlBox = false;
            ini.Show();

        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cys___Store.Assents.Forms.Sistema.AddProduto mostrar = new Assents.Forms.Sistema.AddProduto();
            mostrar.MdiParent = this;
            mostrar.Show();

        }

        private void removerProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverProd rmv = new RemoverProd();
            rmv.MdiParent = this;
            rmv.Show();

        }

        private void modificarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mod_Prod mdf = new Mod_Prod();
            mdf.MdiParent = this;
            mdf.Show();
        }

        private void alugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alugar alg = new Alugar();
            alg.MdiParent = this;
            alg.Show();
        }

        private void CYS_STORE_Load(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.MdiParent = this;
            ini.Show();
        }
    }

    public class SecondFloor : CYS_STORE
    {
        Cys___Store.Classes.CRUD crud = new Classes.CRUD();


        public void Buffer_form(Form sis_form)
        {
            
            




        }
            
}

    }

