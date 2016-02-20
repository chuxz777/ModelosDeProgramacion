namespace Analisis_Lexico_PL
{
    partial class frm_Analisis_Lexico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Analisis_Lexico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsv_Mostar = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tls_Cargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_Analizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_Errores = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_RutaArchivo = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tls_Abrir = new System.Windows.Forms.ToolStripButton();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsv_Mostar);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analizador Léxico";
            // 
            // lsv_Mostar
            // 
            this.lsv_Mostar.Location = new System.Drawing.Point(8, 19);
            this.lsv_Mostar.Name = "lsv_Mostar";
            this.lsv_Mostar.Size = new System.Drawing.Size(282, 291);
            this.lsv_Mostar.TabIndex = 3;
            this.lsv_Mostar.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_Cargar,
            this.toolStripSeparator2,
            this.tls_Analizar,
            this.toolStripSeparator1,
            this.tls_Errores});
            this.toolStrip1.Location = new System.Drawing.Point(594, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(54, 306);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tls_Cargar
            // 
            this.tls_Cargar.Image = ((System.Drawing.Image)(resources.GetObject("tls_Cargar.Image")));
            this.tls_Cargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_Cargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Cargar.Name = "tls_Cargar";
            this.tls_Cargar.Size = new System.Drawing.Size(51, 35);
            this.tls_Cargar.Text = "Cargar";
            this.tls_Cargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(51, 6);
            // 
            // tls_Analizar
            // 
            this.tls_Analizar.Image = ((System.Drawing.Image)(resources.GetObject("tls_Analizar.Image")));
            this.tls_Analizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_Analizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Analizar.Name = "tls_Analizar";
            this.tls_Analizar.Size = new System.Drawing.Size(51, 35);
            this.tls_Analizar.Text = "Analizar";
            this.tls_Analizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(51, 6);
            // 
            // tls_Errores
            // 
            this.tls_Errores.Image = ((System.Drawing.Image)(resources.GetObject("tls_Errores.Image")));
            this.tls_Errores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Errores.Name = "tls_Errores";
            this.tls_Errores.Size = new System.Drawing.Size(51, 35);
            this.tls_Errores.Text = "Errores";
            this.tls_Errores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_RutaArchivo);
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ruta del Archivo";
            // 
            // txt_RutaArchivo
            // 
            this.txt_RutaArchivo.Location = new System.Drawing.Point(7, 20);
            this.txt_RutaArchivo.Name = "txt_RutaArchivo";
            this.txt_RutaArchivo.ReadOnly = true;
            this.txt_RutaArchivo.Size = new System.Drawing.Size(580, 20);
            this.txt_RutaArchivo.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_Abrir});
            this.toolStrip2.Location = new System.Drawing.Point(606, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(38, 58);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tls_Abrir
            // 
            this.tls_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("tls_Abrir.Image")));
            this.tls_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Abrir.Name = "tls_Abrir";
            this.tls_Abrir.Size = new System.Drawing.Size(35, 35);
            this.tls_Abrir.Text = "Abrir";
            this.tls_Abrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tls_Abrir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(588, 427);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 427);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(177, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // frm_Analisis_Lexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 462);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Analisis_Lexico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis Lexico";
            this.Load += new System.EventHandler(this.frm_Analisis_Lexico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tls_Cargar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tls_Analizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_RutaArchivo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tls_Abrir;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.ListView lsv_Mostar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tls_Errores;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}