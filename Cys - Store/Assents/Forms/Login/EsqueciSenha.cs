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

            ConeXml(nome, email);

            }

        protected internal void ConeXml(string nome, string mail)
        {
            string con = @"C:\Users\danbs\Documents\Pass\user.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(con);
            XPathNavigator Nav = doc.CreateNavigator();
            XPathNodeIterator logc = Nav.Select(@"cadastro/funcionarios/Administradores/Logs/login");
            XPathNodeIterator logc1 = Nav.Select(@"cadastro/funcionarios/Administradores/Logs/dados/email");
            
            while ()

            }

            
        }
    }

