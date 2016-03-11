namespace Analisis_Lexico_PL
{
    partial class frm_Analisis_Lexico_Escrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Analisis_Lexico_Escrito));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxt_Tokens = new System.Windows.Forms.RichTextBox();
            this.rtxt_Mostar = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tls_Analizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_Save_tokens = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tls_Errores = new System.Windows.Forms.ToolStripButton();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rtxt_Tokens);
            this.groupBox1.Controls.Add(this.rtxt_Mostar);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 455);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analizador Léxico";
            // 
            // rtxt_Tokens
            // 
            this.rtxt_Tokens.Location = new System.Drawing.Point(296, 16);
            this.rtxt_Tokens.Name = "rtxt_Tokens";
            this.rtxt_Tokens.ReadOnly = true;
            this.rtxt_Tokens.Size = new System.Drawing.Size(269, 433);
            this.rtxt_Tokens.TabIndex = 6;
            this.rtxt_Tokens.Text = "";
            // 
            // rtxt_Mostar
            // 
            this.rtxt_Mostar.Location = new System.Drawing.Point(8, 19);
            this.rtxt_Mostar.Name = "rtxt_Mostar";
            this.rtxt_Mostar.Size = new System.Drawing.Size(269, 430);
            this.rtxt_Mostar.TabIndex = 4;
            this.rtxt_Mostar.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tls_Analizar,
            this.toolStripSeparator1,
            this.tls_Save_tokens,
            this.toolStripSeparator3,
            this.tls_Errores});
            this.toolStrip1.Location = new System.Drawing.Point(590, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(94, 436);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tls_Analizar
            // 
            this.tls_Analizar.Image = ((System.Drawing.Image)(resources.GetObject("tls_Analizar.Image")));
            this.tls_Analizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_Analizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Analizar.Name = "tls_Analizar";
            this.tls_Analizar.Size = new System.Drawing.Size(91, 67);
            this.tls_Analizar.Text = "Analizar";
            this.tls_Analizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tls_Analizar.Click += new System.EventHandler(this.tls_Analizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(91, 6);
            // 
            // tls_Save_tokens
            // 
            this.tls_Save_tokens.Image = ((System.Drawing.Image)(resources.GetObject("tls_Save_tokens.Image")));
            this.tls_Save_tokens.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_Save_tokens.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Save_tokens.Name = "tls_Save_tokens";
            this.tls_Save_tokens.Size = new System.Drawing.Size(91, 67);
            this.tls_Save_tokens.Text = "Guardar Tokens";
            this.tls_Save_tokens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tls_Save_tokens.Click += new System.EventHandler(this.tls_Save_tokens_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(91, 6);
            // 
            // tls_Errores
            // 
            this.tls_Errores.Image = ((System.Drawing.Image)(resources.GetObject("tls_Errores.Image")));
            this.tls_Errores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tls_Errores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tls_Errores.Name = "tls_Errores";
            this.tls_Errores.Size = new System.Drawing.Size(91, 67);
            this.tls_Errores.Text = "Errores";
            this.tls_Errores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tls_Errores.Click += new System.EventHandler(this.tls_Errores_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(621, 473);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 3;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // frm_Analisis_Lexico_Escrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(731, 505);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Analisis_Lexico_Escrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis Escrito";
            this.Load += new System.EventHandler(this.frm_Analisis_Lexico_Escrito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxt_Tokens;
        private System.Windows.Forms.RichTextBox rtxt_Mostar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tls_Analizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tls_Save_tokens;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tls_Errores;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}