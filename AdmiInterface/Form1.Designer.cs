namespace AdmiInterface
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Entrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nomeUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.senhaUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-1, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 15);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.checkBox1.Location = new System.Drawing.Point(79, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Recordar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "NB:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(27, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Acesso Restrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(90, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "apenas para administradores do ssitema";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Leelawadee UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Salmon;
            this.linkLabel1.Location = new System.Drawing.Point(255, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 12);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Saiba mais";
            // 
            // Entrar
            // 
            this.Entrar.Activecolor = System.Drawing.Color.Red;
            this.Entrar.BackColor = System.Drawing.Color.Gainsboro;
            this.Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Entrar.BorderRadius = 0;
            this.Entrar.ButtonText = "Entrar";
            this.Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrar.DisabledColor = System.Drawing.Color.Gray;
            this.Entrar.Iconcolor = System.Drawing.Color.Transparent;
            this.Entrar.Iconimage = null;
            this.Entrar.Iconimage_right = null;
            this.Entrar.Iconimage_right_Selected = null;
            this.Entrar.Iconimage_Selected = null;
            this.Entrar.IconMarginLeft = 0;
            this.Entrar.IconMarginRight = 0;
            this.Entrar.IconRightVisible = true;
            this.Entrar.IconRightZoom = 0D;
            this.Entrar.IconVisible = true;
            this.Entrar.IconZoom = 90D;
            this.Entrar.IsTab = false;
            this.Entrar.Location = new System.Drawing.Point(197, 384);
            this.Entrar.Name = "Entrar";
            this.Entrar.Normalcolor = System.Drawing.Color.Gainsboro;
            this.Entrar.OnHovercolor = System.Drawing.Color.LightSalmon;
            this.Entrar.OnHoverTextColor = System.Drawing.Color.White;
            this.Entrar.selected = false;
            this.Entrar.Size = new System.Drawing.Size(106, 37);
            this.Entrar.TabIndex = 12;
            this.Entrar.Text = "Entrar";
            this.Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Entrar.Textcolor = System.Drawing.Color.Black;
            this.Entrar.TextFont = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomeUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomeUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.nomeUsuario.HintText = "";
            this.nomeUsuario.isPassword = false;
            this.nomeUsuario.LineFocusedColor = System.Drawing.Color.Firebrick;
            this.nomeUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.nomeUsuario.LineMouseHoverColor = System.Drawing.Color.LightSalmon;
            this.nomeUsuario.LineThickness = 3;
            this.nomeUsuario.Location = new System.Drawing.Point(79, 232);
            this.nomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(231, 33);
            this.nomeUsuario.TabIndex = 52;
            this.nomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // senhaUsuario
            // 
            this.senhaUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senhaUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.senhaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.senhaUsuario.HintForeColor = System.Drawing.Color.DarkSalmon;
            this.senhaUsuario.HintText = " ";
            this.senhaUsuario.isPassword = true;
            this.senhaUsuario.LineFocusedColor = System.Drawing.Color.Firebrick;
            this.senhaUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.senhaUsuario.LineMouseHoverColor = System.Drawing.Color.LightSalmon;
            this.senhaUsuario.LineThickness = 3;
            this.senhaUsuario.Location = new System.Drawing.Point(79, 305);
            this.senhaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.senhaUsuario.Name = "senhaUsuario";
            this.senhaUsuario.Size = new System.Drawing.Size(231, 33);
            this.senhaUsuario.TabIndex = 53;
            this.senhaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuTileButton1.color = System.Drawing.Color.Gainsboro;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.LightSalmon;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Sign on";
            this.bunifuTileButton1.Location = new System.Drawing.Point(113, 47);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(347, 511);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.senhaUsuario);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(363, 550);
            this.MinimumSize = new System.Drawing.Size(363, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton Entrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nomeUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox senhaUsuario;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}

