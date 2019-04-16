namespace ECEUWin
{
    partial class ECEUWin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_autenticacionwin = new System.Windows.Forms.CheckBox();
            this.txt_bd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_instancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_rdbms = new System.Windows.Forms.ComboBox();
            this.btn_sinc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_sinc);
            this.groupBox1.Controls.Add(this.chb_autenticacionwin);
            this.groupBox1.Controls.Add(this.txt_bd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_instancia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_conectar);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_rdbms);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RDBMS";
            // 
            // chb_autenticacionwin
            // 
            this.chb_autenticacionwin.AutoSize = true;
            this.chb_autenticacionwin.Location = new System.Drawing.Point(116, 50);
            this.chb_autenticacionwin.Name = "chb_autenticacionwin";
            this.chb_autenticacionwin.Size = new System.Drawing.Size(135, 17);
            this.chb_autenticacionwin.TabIndex = 8;
            this.chb_autenticacionwin.Text = "Windows Autentication";
            this.chb_autenticacionwin.UseVisualStyleBackColor = true;
            this.chb_autenticacionwin.CheckedChanged += new System.EventHandler(this.chb_autenticacionwin_CheckedChanged);
            // 
            // txt_bd
            // 
            this.txt_bd.Location = new System.Drawing.Point(117, 170);
            this.txt_bd.Name = "txt_bd";
            this.txt_bd.Size = new System.Drawing.Size(205, 20);
            this.txt_bd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Base de Datos";
            // 
            // txt_instancia
            // 
            this.txt_instancia.Location = new System.Drawing.Point(116, 141);
            this.txt_instancia.Name = "txt_instancia";
            this.txt_instancia.Size = new System.Drawing.Size(205, 20);
            this.txt_instancia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instancia:";
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(246, 196);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 3;
            this.btn_conectar.Text = "conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(116, 114);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(205, 20);
            this.txt_contraseña.TabIndex = 2;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(116, 89);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(205, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // cbo_rdbms
            // 
            this.cbo_rdbms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_rdbms.FormattingEnabled = true;
            this.cbo_rdbms.Items.AddRange(new object[] {
            "SQL_SERVER",
            "MYSQL",
            "ORACLE",
            "INFORMIX"});
            this.cbo_rdbms.Location = new System.Drawing.Point(116, 21);
            this.cbo_rdbms.Name = "cbo_rdbms";
            this.cbo_rdbms.Size = new System.Drawing.Size(205, 21);
            this.cbo_rdbms.TabIndex = 0;
            this.cbo_rdbms.SelectionChangeCommitted += new System.EventHandler(this.cbo_rdbms_SelectionChangeCommitted);
            // 
            // btn_sinc
            // 
            this.btn_sinc.Location = new System.Drawing.Point(116, 196);
            this.btn_sinc.Name = "btn_sinc";
            this.btn_sinc.Size = new System.Drawing.Size(92, 23);
            this.btn_sinc.TabIndex = 4;
            this.btn_sinc.Text = "conectar 2BD";
            this.btn_sinc.UseVisualStyleBackColor = true;
            this.btn_sinc.Click += new System.EventHandler(this.btn_sinc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Manejadore de BD";
            // 
            // ECEUWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 256);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ECEUWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECEUWin";
            this.Load += new System.EventHandler(this.ECEUWin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_rdbms;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.TextBox txt_instancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sinc;
        private System.Windows.Forms.TextBox txt_bd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chb_autenticacionwin;
        private System.Windows.Forms.Label label5;
    }
}

