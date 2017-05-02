using System;
using System.Xml;
using System.Xml.XPath;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cys___Store.Assents.Forms.Login;
using System.Web;
using System.Dynamic;
using System.Net.Mail;
using Cys___Store.Classes;
using MySql.Data.MySqlClient;

namespace Cys___Store.Assents.Forms.Login
{
    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            nome.Trim();
            string email = txtEmail.Text;
            email.Trim();
            email.ToLower();

            Recuper_Senha(nome, email);
            if (Recuper_Senha(nome, email) == true){Application.ExitThread();}


            }

        protected internal void ConeXml(string nome, string mail)
        {
            string con = @"C:\Users\danbs\Documents\Pass\user.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(con);
            XPathNavigator Nav = doc.CreateNavigator();
            XPathNodeIterator logc = Nav.Select(@"cadastro/funcionarios/Administradores/Logs/login");
            XPathNodeIterator logc1 = Nav.Select(@"cadastro/funcionarios/Administradores/Logs/dados/email");
            
            //while ()

            }

        protected internal bool Recuper_Senha(string nome,string email)
        {

            string connx = @"server=localhost;user id=root;persistsecurityinfo=True;database=sys";
            string query = @"select login, senha,email from usuario where login=@nome and email=@email";


            MySqlConnection conn = new MySqlConnection(connx);
            MySqlCommand comm = new MySqlCommand(query, conn);
            comm.Parameters.AddWithValue("@nome", nome);
            comm.Parameters.AddWithValue("@email", email);

            conn.Open();
            try {
                MySqlDataReader rd = comm.ExecuteReader();
                while (rd.Read())
                {
                    string bank_login = rd["login"].ToString();
                    string bank_email = rd["email"].ToString();
                    if ((nome == bank_login) && (email == bank_email)) {
                        MessageBox.Show("Senha Enviada com Sucesso para: " + bank_email);
                        
                        break;
                        
                    }


                    else
                    {
                        MessageBox.Show("Login ou senha inválidos");
                        break;
                        return false;
                    }

                    rd.Close();
                }    


            }
            catch {

                MessageBox.Show("ERRO 302 - Contate seu Administrador","CYS STORE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            conn.Close();

            return true;

        } 
           
        }
    }

