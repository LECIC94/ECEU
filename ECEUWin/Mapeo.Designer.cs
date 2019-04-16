namespace ECEUWin
{
    partial class Mapeo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_tablas = new System.Windows.Forms.ListBox();
            this.Columnas = new System.Windows.Forms.Label();
            this.lst_columnas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_mapea = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lst_camporequerido = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_tablas);
            this.groupBox1.Controls.Add(this.Columnas);
            this.groupBox1.Controls.Add(this.lst_columnas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qúe campo decea mapear?";
            // 
            // lst_tablas
            // 
            this.lst_tablas.FormattingEnabled = true;
            this.lst_tablas.Location = new System.Drawing.Point(18, 40);
            this.lst_tablas.Name = "lst_tablas";
            this.lst_tablas.Size = new System.Drawing.Size(151, 212);
            this.lst_tablas.TabIndex = 6;
            this.lst_tablas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_tablas_MouseDoubleClick);
            // 
            // Columnas
            // 
            this.Columnas.AutoSize = true;
            this.Columnas.Location = new System.Drawing.Point(218, 23);
            this.Columnas.Name = "Columnas";
            this.Columnas.Size = new System.Drawing.Size(53, 13);
            this.Columnas.TabIndex = 8;
            this.Columnas.Text = "Columnas";
            // 
            // lst_columnas
            // 
            this.lst_columnas.FormattingEnabled = true;
            this.lst_columnas.Location = new System.Drawing.Point(187, 40);
            this.lst_columnas.Name = "lst_columnas";
            this.lst_columnas.Size = new System.Drawing.Size(171, 212);
            this.lst_columnas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tablas";
            // 
            // btn_mapea
            // 
            this.btn_mapea.Location = new System.Drawing.Point(415, 184);
            this.btn_mapea.Name = "btn_mapea";
            this.btn_mapea.Size = new System.Drawing.Size(75, 23);
            this.btn_mapea.TabIndex = 7;
            this.btn_mapea.Text = "mapea";
            this.btn_mapea.UseVisualStyleBackColor = true;
            this.btn_mapea.Click += new System.EventHandler(this.btn_mapea_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Campos Requeridos";
            // 
            // lst_camporequerido
            // 
            this.lst_camporequerido.FormattingEnabled = true;
            this.lst_camporequerido.Items.AddRange(new object[] {
            "ID",
            "FECHA",
            "SERVICIO",
            "PRESCRIPCION",
            "DOMICILIO",
            "OCUPACION",
            "SEGURO_SOCIAL",
            "GENERO",
            "EDAD",
            "CLINICA"});
            this.lst_camporequerido.Location = new System.Drawing.Point(18, 50);
            this.lst_camporequerido.Name = "lst_camporequerido";
            this.lst_camporequerido.Size = new System.Drawing.Size(142, 186);
            this.lst_camporequerido.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lst_camporequerido);
            this.groupBox2.Location = new System.Drawing.Point(532, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 260);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "¿Con que campo decea mapear?";
            // 
            // Mapeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 297);
            this.Controls.Add(this.btn_mapea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mapeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapeo";
            this.Load += new System.EventHandler(this.Mapeo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_camporequerido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_mapea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Columnas;
        public System.Windows.Forms.ListBox lst_columnas;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox lst_tablas;
    }
}