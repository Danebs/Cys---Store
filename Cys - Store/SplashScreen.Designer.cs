namespace Cys___Store
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.tempoSplash = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraCronometro = new System.Windows.Forms.ProgressBar();
            this.FormularioLogin = new System.Windows.Forms.TableLayoutPanel();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textlogin = new System.Windows.Forms.TextBox();
            this.SairSistema = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.FormularioLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tempoSplash
            // 
            this.tempoSplash.Enabled = true;
            this.tempoSplash.Interval = 1000;
            this.tempoSplash.Tick += new System.EventHandler(this.tempoSplash_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Cys___Store.Properties.Resources.Hat3bN;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BarraCronometro);
            this.panel1.Controls.Add(this.FormularioLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 261);
            this.panel1.TabIndex = 0;
            // 
            // BarraCronometro
            // 
            this.BarraCronometro.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BarraCronometro.Location = new System.Drawing.Point(266, 182);
            this.BarraCronometro.Name = "BarraCronometro";
            this.BarraCronometro.Size = new System.Drawing.Size(370, 23);
            this.BarraCronometro.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraCronometro.TabIndex = 3;
            this.BarraCronometro.Click += new System.EventHandler(this.BarraCronometro_Click);
            // 
            // FormularioLogin
            // 
            this.FormularioLogin.ColumnCount = 3;
            this.FormularioLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.26984F));
            this.FormularioLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.73016F));
            this.FormularioLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.FormularioLogin.Controls.Add(this.textsenha, 1, 1);
            this.FormularioLogin.Controls.Add(this.label3, 0, 0);
            this.FormularioLogin.Controls.Add(this.label4, 0, 1);
            this.FormularioLogin.Controls.Add(this.Login, 0, 3);
            this.FormularioLogin.Controls.Add(this.linkLabel1, 0, 2);
            this.FormularioLogin.Controls.Add(this.textlogin, 1, 0);
            this.FormularioLogin.Controls.Add(this.SairSistema, 1, 3);
            this.FormularioLogin.Controls.Add(this.pictureBox2, 2, 0);
            this.FormularioLogin.Controls.Add(this.pictureBox3, 2, 1);
            this.FormularioLogin.Enabled = false;
            this.FormularioLogin.Location = new System.Drawing.Point(260, 153);
            this.FormularioLogin.Name = "FormularioLogin";
            this.FormularioLogin.RowCount = 4;
            this.FormularioLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.FormularioLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.FormularioLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.FormularioLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.FormularioLogin.Size = new System.Drawing.Size(379, 96);
            this.FormularioLogin.TabIndex = 4;
            this.FormularioLogin.Visible = false;
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(139, 32);
            this.textsenha.MaxLength = 16;
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(154, 20);
            this.textsenha.TabIndex = 3;
            this.textsenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome de Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Senha:";
            // 
            // Login
            // 
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Login.Image = global::Cys___Store.Properties.Resources.Double_J_Design_Origami_Colored_Pencil_Blue_mail_send;
            this.Login.Location = new System.Drawing.Point(3, 73);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(130, 20);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(3, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 15);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueci minha Senha:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textlogin
            // 
            this.textlogin.Location = new System.Drawing.Point(139, 3);
            this.textlogin.Name = "textlogin";
            this.textlogin.Size = new System.Drawing.Size(176, 20);
            this.textlogin.TabIndex = 2;
            // 
            // SairSistema
            // 
            this.SairSistema.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SairSistema.Image = global::Cys___Store.Properties.Resources.Awicons_Vista_Artistic_Delete;
            this.SairSistema.Location = new System.Drawing.Point(139, 73);
            this.SairSistema.Name = "SairSistema";
            this.SairSistema.Size = new System.Drawing.Size(136, 20);
            this.SairSistema.TabIndex = 7;
            this.SairSistema.Text = "Sair do sistema";
            this.SairSistema.UseVisualStyleBackColor = true;
            this.SairSistema.Click += new System.EventHandler(this.SairSistema_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Cys___Store.Properties.Resources.Alecive_Flatwoken_Apps_Bleachbit;
            this.pictureBox2.Location = new System.Drawing.Point(332, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Cys___Store.Properties.Resources.Alecive_Flatwoken_Apps_Bleachbit;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(332, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 20);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(397, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 74);
            this.label2.TabIndex = 2;
            this.label2.Text = "STORE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(248, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "CYS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cys___Store.Properties.Resources.glass_34783_640;
            this.pictureBox1.Location = new System.Drawing.Point(57, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(662, 261);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FormularioLogin.ResumeLayout(false);
            this.FormularioLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tempoSplash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar BarraCronometro;
        private System.Windows.Forms.TableLayoutPanel FormularioLogin;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textlogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button SairSistema;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}