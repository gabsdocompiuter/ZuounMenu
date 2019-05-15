namespace ZuounSystem
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBarraSuperior = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bMinimizar = new System.Windows.Forms.Button();
            this.bFechar = new System.Windows.Forms.Button();
            this.pBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 88);
            this.panel1.TabIndex = 1;
            // 
            // pBarraSuperior
            // 
            this.pBarraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarraSuperior.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pBarraSuperior.Controls.Add(this.bMinimizar);
            this.pBarraSuperior.Controls.Add(this.bFechar);
            this.pBarraSuperior.Location = new System.Drawing.Point(214, 0);
            this.pBarraSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.pBarraSuperior.Name = "pBarraSuperior";
            this.pBarraSuperior.Size = new System.Drawing.Size(603, 27);
            this.pBarraSuperior.TabIndex = 1;
            this.pBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBarraSuperior_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 365);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Coral;
            this.panel4.Location = new System.Drawing.Point(0, 453);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 50);
            this.panel4.TabIndex = 1;
            // 
            // bMinimizar
            // 
            this.bMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMinimizar.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_outlined;
            this.bMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bMinimizar.FlatAppearance.BorderSize = 0;
            this.bMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bMinimizar.Location = new System.Drawing.Point(549, 0);
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
            this.bFechar.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_x;
            this.bFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bFechar.FlatAppearance.BorderSize = 0;
            this.bFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFechar.Location = new System.Drawing.Point(576, 0);
            this.bFechar.Margin = new System.Windows.Forms.Padding(0);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(27, 27);
            this.bFechar.TabIndex = 0;
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.BFechar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(817, 503);
            this.Controls.Add(this.pBarraSuperior);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.pBarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBarraSuperior;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Button bMinimizar;
    }
}