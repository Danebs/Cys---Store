using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Cys___Store.Classes
{
    class CRUD
    {
        public bool confirma = true;
        private string conexao = @"server=localhost;user id=root;persistsecurityinfo=True;database=sys";

        public void Inserir() {
            string conecxao = @"server = localhost; user id = root; persistsecurityinfo = True; database = sys";
            MySqlConnection con = new MySqlConnection(conecxao);
            MySqlCommand cmd = new MySqlCommand("insert into usuario(login,senha,nome_usuario,email) values ('Krool','Teste','Krool do Crud','krool@jigoo.com')",con);

            try { 
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();

            }
            catch { MessageBox.Show("ERRO"); }
        }

        public void Select()
        {
            string conecxao = @"server = localhost; user id = root; persistsecurityinfo = True; database = sys";
            MySqlConnection con = new MySqlConnection(conecxao);
            MySqlCommand cmd = new MySqlCommand("select * from usuario", con);

            

        }

        public bool Login_banco(string login, string senha)
        {
            string strgconn = @"server=localhost;user id=root;persistsecurityinfo=True;database=sys";
            MySqlConnection con = new MySqlConnection(strgconn);
            MySqlCommand comm = new MySqlCommand("select * from usuario where login=@login and senha=@senha", con);
            comm.Parameters.AddWithValue("@login", login);
            comm.Parameters.AddWithValue("@senha", senha);


            try
            {
                con.Open();
                MySqlDataReader rd = comm.ExecuteReader();

                while (rd.Read()) { 
                string login_bank = rd["login"].ToString();
                string pass_bank = rd["senha"].ToString();
                    string user_name = rd["nome_usuario"].ToString();
                
                if ((login == login_bank) && (senha == pass_bank))
                {
                    MessageBox.Show( "BEM VINDO " + user_name, "CYS STORE - Sucesso ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Cys___Store.CYS_STORE oj = new CYS_STORE();
                        Cys___Store.SplashScreen splash = new SplashScreen();
                       
                        oj.Show();
                        Application.ExitThread();
                        Application.Run(new Cys___Store.CYS_STORE());
                        splash.Close();
                        return true;
                        



                    }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INCORRETOS", "CYS STORE - ERRO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        
                    }
                }
            
                rd.Close();
                con.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERRO 302 - Contate seu administrador", "CYS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            con.Close();

            return false;




        }




        public void AddProd(string nome_produto, double valor_produto, decimal quantidade_prod, string gnr, string subg) {

            string comd = @"insert into produtos(nome_produto,Prod_preco,Categoria,Subgenero,Qtd_produto,Descricao1) values ('@nome','@valor','@genero','@subgenero''@qtd','@descricao'";
            string lerbanco = @"select nome_produto from produtos";

            MySqlConnection conn = new MySqlConnection(conexao);
            MySqlCommand cmd = new MySqlCommand(comd, conn);
            MySqlCommand checagem = new MySqlCommand(lerbanco, conn);
            try
            {
                conn.Open();
                MySqlDataReader ler = checagem.ExecuteReader();


                try { 
                cmd.ExecuteNonQuery();
                }
                catch { MessageBox.Show("Não foi possivel cadastrar produto","ERROR SYS",MessageBoxButtons.OK,MessageBoxIcon.Error); }

                conn.Close();
            }

            catch (MySqlException) { MessageBox.Show("ERRO 303 - Contate seu administrador", "ERRO CYS STORE", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
    }

    class LoadDB
    {

        private string categoria_var;
        private string subgenero_var;
        private string conexao = @"server=localhost;user id=root;persistsecurityinfo=True;database=sys";

        public void Load_Itens(ComboBox genero, ComboBox subgenero)
        {
            
            string cmd1 = @"select nome_categoria from categorias where TipoCategoria='Produtos'";
            string cmd2 = @"select subgenero_categoria from categorias where=nome_categoria='";
          
            MySqlConnection conn = new MySqlConnection(conexao);
            MySqlCommand query1 = new MySqlCommand(cmd1, conn);
            MySqlCommand query2 = new MySqlCommand(cmd2, conn);

            conn.Open();
             
            try
            {
                MySqlDataReader rd = query1.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                DataRow dr = dt.NewRow();

                genero.DataSource = dt;
                genero.DisplayMember = "nome_categoria";
                //genero.ValueMember = "cod_categoria";

                rd.Close();
                
                MySqlDataReader rd2 = query2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(rd2);
                DataRow dr2 = dt2.NewRow();
                subgenero.DataSource = dt2;
                subgenero.DisplayMember = "subgenero_categoria";

                rd2.Close();
            }
            catch (MySqlException) { MessageBox.Show("Erro Aqui"); }
            
            

            conn.Close();
        } 

        public void Load_Imagem(PictureBox img)
        {
            string conexao = @"server=localhost;user id=root;persistsecurityinfo=True;database=sys";
            string cmd1 = @"select imagem_url from categorias where subgenero_categoria='@subgnr'";

            MySqlConnection conn = new MySqlConnection(conexao);
            MySqlCommand query1 = new MySqlCommand(cmd1, conn);

            MySqlDataReader rd = query1.ExecuteReader();

            while (rd.Read())
            {
                img.Load(rd["Imagem_url"].ToString());


            }




        }


    }


}
