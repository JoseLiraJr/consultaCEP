
namespace ConsultaCEP
{
    partial class frmConsultaCEP
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCEP));
            this.lblCEP = new System.Windows.Forms.Label();
            this.edtCEP = new System.Windows.Forms.TextBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.edtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.edtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.edtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.edtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(28, 19);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // edtCEP
            // 
            this.edtCEP.Location = new System.Drawing.Point(32, 35);
            this.edtCEP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtCEP.MaxLength = 8;
            this.edtCEP.Name = "edtCEP";
            this.edtCEP.Size = new System.Drawing.Size(183, 21);
            this.edtCEP.TabIndex = 1;
            this.edtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtCEP_KeyPress);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.edtLogradouro);
            this.gbResultado.Controls.Add(this.lblLogradouro);
            this.gbResultado.Controls.Add(this.edtBairro);
            this.gbResultado.Controls.Add(this.lblBairro);
            this.gbResultado.Controls.Add(this.edtCidade);
            this.gbResultado.Controls.Add(this.lblCidade);
            this.gbResultado.Controls.Add(this.edtEstado);
            this.gbResultado.Controls.Add(this.lblEstado);
            this.gbResultado.Location = new System.Drawing.Point(32, 73);
            this.gbResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbResultado.Size = new System.Drawing.Size(539, 221);
            this.gbResultado.TabIndex = 2;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado da Consulta";
            // 
            // edtLogradouro
            // 
            this.edtLogradouro.BackColor = System.Drawing.Color.LightGray;
            this.edtLogradouro.Location = new System.Drawing.Point(27, 174);
            this.edtLogradouro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLogradouro.Name = "edtLogradouro";
            this.edtLogradouro.Size = new System.Drawing.Size(480, 21);
            this.edtLogradouro.TabIndex = 9;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(24, 158);
            this.lblLogradouro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(77, 13);
            this.lblLogradouro.TabIndex = 8;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // edtBairro
            // 
            this.edtBairro.BackColor = System.Drawing.Color.LightGray;
            this.edtBairro.Location = new System.Drawing.Point(27, 127);
            this.edtBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtBairro.Name = "edtBairro";
            this.edtBairro.Size = new System.Drawing.Size(480, 21);
            this.edtBairro.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(24, 111);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 13);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro:";
            // 
            // edtCidade
            // 
            this.edtCidade.BackColor = System.Drawing.Color.LightGray;
            this.edtCidade.Location = new System.Drawing.Point(27, 85);
            this.edtCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtCidade.Name = "edtCidade";
            this.edtCidade.Size = new System.Drawing.Size(480, 21);
            this.edtCidade.TabIndex = 5;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(24, 69);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 13);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";
            // 
            // edtEstado
            // 
            this.edtEstado.BackColor = System.Drawing.Color.LightGray;
            this.edtEstado.Location = new System.Drawing.Point(27, 42);
            this.edtEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtEstado.Name = "edtEstado";
            this.edtEstado.Size = new System.Drawing.Size(480, 21);
            this.edtEstado.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(24, 26);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultar.Image = global::ConsultaCEP.Properties.Resources.mail;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(372, 19);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(199, 50);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar CEP";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::ConsultaCEP.Properties.Resources.eraser;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(346, 300);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::ConsultaCEP.Properties.Resources.log_out;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(462, 300);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 35);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmConsultaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 346);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.edtCEP);
            this.Controls.Add(this.lblCEP);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmConsultaCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de CEP";
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox edtCEP;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.TextBox edtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox edtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox edtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox edtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

