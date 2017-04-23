using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cys___Store.Assents.Forms.Login;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;


namespace Cys___Store
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();



        }


        private void tempoSplash_Tick(object sender, EventArgs e)
        {
            if (BarraCronometro.Value == 100)
            {
                tempoSplash.Enabled = false;
                BarraCronometro.Visible = false;
                BarraCronometro.Enabled = false;
                BarraCronometro.Hide();

                FormularioLogin.Visible = true;
                FormularioLogin.Enabled = true;
                this.SuspendLayout();

            }
            else
            {
                BarraCronometro.Value = BarraCronometro.Value + 10;
            }
        }

        private void BarraCronometro_Click(object sender, EventArgs e)
        {

        }

        private void SairSistema_Click(object sender, EventArgs e)
        {

            DialogResult resul = MessageBox.Show("Deseja mesmo sair?", "CYS Store - sair do sitema ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textlogin.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textsenha.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EsqueciSenha sho = new EsqueciSenha();

            sho.Show();

        }

        private void Login_Click(object sender, EventArgs e)
        {

            string login = textlogin.Text;
            login.TrimStart();
            string senha = textsenha.Text;
            senha.TrimStart();
            if (login == "") { MessageBox.Show("Campo Login Vazio"); }
            else if (senha == "") { MessageBox.Show("Campo Senha Vazio."); }
            else
            {
                LoginSistema logar = new LoginSistema();
                logar.Login(login, senha);
            }


        }
    }

    class LoginSistema
    {

        protected internal int Login(string lgn, string snh)
        {

            XMLConect(lgn, snh);


            return 0;
        }






        private void XMLConect(string log, string senha)
        {
            try
            {
                string doc = @"C:\Users\danbs\Documents\Pass\user.xml";
                XmlDocument file = new XmlDocument();
                file.Load(doc);

                XmlTextReader r = new XmlTextReader(doc);

                while (r.Read())
                {
                    

                    XmlNode nod1 = file.SelectSingleNode(@"cadastro/Administradores/Logs/login");
                    XmlNode nod2 = file.SelectSingleNode(@"cadastro/Administradores/Logs/senha");
                    XPathNavigator nav = file.CreateNavigator();
                    XPathNodeIterator iet1 = nav.Select("cadastro/funcionarios/Administradores/Logs/login");
                    XPathNodeIterator iet2 = nav.Select("cadastro/funcionarios/Administradores/Logs/senha");
                    while (iet1.MoveNext())
                    {
                        if (iet1.Current.Value == log)
                        {



                            while (iet2.MoveNext())
                            {
                                if (iet2.Current.Value == senha)
                                {
                                    MessageBox.Show("Login Efetuado com Sucesso");
                                    break;
                                }
                                else if (iet2.Count == iet2.CurrentPosition)
                                {
                                    MessageBox.Show("Erro ao Entrar");
                                    break;
                                }


                            }
                            break;
                        }
                        else if (iet1.Count == iet1.CurrentPosition)
                        {
                            MessageBox.Show("Nenhum Usuario encontrado");
                            break;
                        }


                    }
                    break;




                }




            }

            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Erro ao tentar acessar o arquivo!!! Contate o desenvolvedor.", "CYS - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                GC.Collect();


            }
        }







        private static void LogSucess(object source, ElapsedEventArgs e)
        {
            MessageBox.Show("CYS - BEM VINDO", "Login com Sucesso");


        }





        /*  private void BarraCronometro_Click(object sender, EventArgs e)
         {

         }

         */
    }
}