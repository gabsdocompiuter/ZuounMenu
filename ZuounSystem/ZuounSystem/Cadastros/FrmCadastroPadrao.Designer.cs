namespace ZuounSystem.Cadastros
{
    partial class FrmCadastroPadrao
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
            this.pBarraSuperior = new System.Windows.Forms.Panel();
            this.lblNomePrograma = new System.Windows.Forms.Label();
            this.bMinimizar = new System.Windows.Forms.Button();
            this.bFechar = new System.Windows.Forms.Button();
            this.pBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBarraSuperior
            // 
            this.pBarraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pBarraSuperior.Controls.Add(this.lblNomePrograma);
            this.pBarraSuperior.Controls.Add(this.bMinimizar);
            this.pBarraSuperior.Controls.Add(this.bFechar);
            this.pBarraSuperior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pBarraSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.pBarraSuperior.Name = "pBarraSuperior";
            this.pBarraSuperior.Size = new System.Drawing.Size(789, 27);
            this.pBarraSuperior.TabIndex = 2;
            // 
            // lblNomePrograma
            // 
            this.lblNomePrograma.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePrograma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomePrograma.Location = new System.Drawing.Point(0, 0);
            this.lblNomePrograma.Margin = new System.Windows.Forms.Padding(0);
            this.lblNomePrograma.Name = "lblNomePrograma";
            this.lblNomePrograma.Size = new System.Drawing.Size(735, 27);
            this.lblNomePrograma.TabIndex = 1;
            this.lblNomePrograma.Text = "Nome do Programa";
            this.lblNomePrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNomePrograma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickAndDrag_MouseDown);
            // 
            // bMinimizar
            // 
            this.bMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinimizar.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_outlined_white_;
            this.bMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMinimizar.FlatAppearance.BorderSize = 0;
            this.bMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bMinimizar.Location = new System.Drawing.Point(735, 0);
            this.bMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.bMinimizar.Name = "bMinimizar";
            this.bMinimizar.Size = new System.Drawing.Size(27, 27);
            this.bMinimizar.TabIndex = 0;
            this.bMinimizar.UseVisualStyleBackColor = true;
            this.bMinimizar.Click += new System.EventHandler(this.BMinimizar_Click);
            // 
            // bFechar
            // 
            this.bFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFechar.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_x_white_;
            this.bFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bFechar.FlatAppearance.BorderSize = 0;
            this.bFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFechar.Location = new System.Drawing.Point(762, 0);
            this.bFechar.Margin = new System.Windows.Forms.Padding(0);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(27, 27);
            this.bFechar.TabIndex = 0;
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.BFechar_Click);
            // 
            // FrmCadastroPadrao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 491);
            this.Controls.Add(this.pBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroPadrao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroPadrao";
            this.pBarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bMinimizar;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Panel pBarraSuperior;
        private System.Windows.Forms.Label lblNomePrograma;
    }
}