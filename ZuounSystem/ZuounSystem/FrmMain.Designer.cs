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
            this.label1 = new System.Windows.Forms.Label();
            this.pBarraSuperior = new System.Windows.Forms.Panel();
            this.bMinimizar = new System.Windows.Forms.Button();
            this.bFechar = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bGithub = new System.Windows.Forms.Button();
            this.bTwitter = new System.Windows.Forms.Button();
            this.bSite = new System.Windows.Forms.Button();
            this.pSubMenu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pBarraSuperior.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 88);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZuounSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickToDrag_MouseDown);
            // 
            // pBarraSuperior
            // 
            this.pBarraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pBarraSuperior.Controls.Add(this.bMinimizar);
            this.pBarraSuperior.Controls.Add(this.bFechar);
            this.pBarraSuperior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pBarraSuperior.Location = new System.Drawing.Point(214, 0);
            this.pBarraSuperior.Margin = new System.Windows.Forms.Padding(0);
            this.pBarraSuperior.Name = "pBarraSuperior";
            this.pBarraSuperior.Size = new System.Drawing.Size(603, 27);
            this.pBarraSuperior.TabIndex = 1;
            this.pBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickToDrag_MouseDown);
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
            this.bFechar.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_x_white_;
            this.bFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bFechar.FlatAppearance.BorderSize = 0;
            this.bFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFechar.Location = new System.Drawing.Point(576, 0);
            this.bFechar.Margin = new System.Windows.Forms.Padding(0);
            this.bFechar.Name = "bFechar";
            this.bFechar.Size = new System.Drawing.Size(27, 27);
            this.bFechar.TabIndex = 0;
            this.bFechar.UseVisualStyleBackColor = true;
            this.bFechar.Click += new System.EventHandler(this.BFechar_Click);
            // 
            // pMenu
            // 
            this.pMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.pMenu.Location = new System.Drawing.Point(0, 88);
            this.pMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(214, 365);
            this.pMenu.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.bGithub);
            this.panel4.Controls.Add(this.bTwitter);
            this.panel4.Controls.Add(this.bSite);
            this.panel4.Location = new System.Drawing.Point(0, 453);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 50);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(0, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desenvolvido por Gabriel Monteiro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bGithub
            // 
            this.bGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGithub.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_github;
            this.bGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bGithub.FlatAppearance.BorderSize = 0;
            this.bGithub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGithub.Location = new System.Drawing.Point(135, 4);
            this.bGithub.Margin = new System.Windows.Forms.Padding(0);
            this.bGithub.Name = "bGithub";
            this.bGithub.Size = new System.Drawing.Size(25, 25);
            this.bGithub.TabIndex = 0;
            this.bGithub.UseVisualStyleBackColor = true;
            this.bGithub.Click += new System.EventHandler(this.BGithub_Click);
            // 
            // bTwitter
            // 
            this.bTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bTwitter.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_twitter;
            this.bTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bTwitter.FlatAppearance.BorderSize = 0;
            this.bTwitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bTwitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTwitter.Location = new System.Drawing.Point(95, 4);
            this.bTwitter.Margin = new System.Windows.Forms.Padding(0);
            this.bTwitter.Name = "bTwitter";
            this.bTwitter.Size = new System.Drawing.Size(25, 25);
            this.bTwitter.TabIndex = 0;
            this.bTwitter.UseVisualStyleBackColor = true;
            this.bTwitter.Click += new System.EventHandler(this.BTwitter_Click);
            // 
            // bSite
            // 
            this.bSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSite.BackgroundImage = global::ZuounSystem.Properties.Resources.icon_dribbble;
            this.bSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSite.FlatAppearance.BorderSize = 0;
            this.bSite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSite.Location = new System.Drawing.Point(55, 4);
            this.bSite.Margin = new System.Windows.Forms.Padding(0);
            this.bSite.Name = "bSite";
            this.bSite.Size = new System.Drawing.Size(25, 25);
            this.bSite.TabIndex = 0;
            this.bSite.UseVisualStyleBackColor = true;
            this.bSite.Click += new System.EventHandler(this.BSite_Click);
            // 
            // pSubMenu
            // 
            this.pSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSubMenu.Location = new System.Drawing.Point(214, 27);
            this.pSubMenu.Name = "pSubMenu";
            this.pSubMenu.Size = new System.Drawing.Size(603, 476);
            this.pSubMenu.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(817, 503);
            this.Controls.Add(this.pSubMenu);
            this.Controls.Add(this.pBarraSuperior);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.pBarraSuperior.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBarraSuperior;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bFechar;
        private System.Windows.Forms.Button bMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSite;
        private System.Windows.Forms.Button bGithub;
        private System.Windows.Forms.Button bTwitter;
        private System.Windows.Forms.Panel pSubMenu;
    }
}