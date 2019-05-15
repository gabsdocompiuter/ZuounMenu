using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZuounSystem
{
    public partial class FrmLogin : Form
    {
        #region Definições para o Click and Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Método responsável pelo Click and Drag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region Definições para o BackgroungImage

        private Image backgroundImage;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            backgroundImage = ResizeImage(backgroundImage, 215, 1000, false);

            int x = this.ClientSize.Width - backgroundImage.Width;
            int y = (this.ClientSize.Height - backgroundImage.Height) / 2;
            int width = backgroundImage.Width;
            int height = backgroundImage.Height;

            var rc = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(backgroundImage, rc);
        }

        /// <summary>  
        /// resize an image and maintain aspect ratio  
        /// </summary>  
        /// <param name="image">image to resize</param>  
        /// <param name="newWidth">desired width</param>  
        /// <param name="maxHeight">max height</param>  
        /// <param name="onlyResizeIfWider">if image width is smaller than newWidth use image width</param>  
        /// <returns>resized image</returns>  
        public static Image ResizeImage(Image image, int newWidth, int maxHeight, bool onlyResizeIfWider)
        {
            if (onlyResizeIfWider && image.Width <= newWidth) newWidth = image.Width;

            var newHeight = image.Height * newWidth / image.Width;
            if (newHeight > maxHeight)
            {
                // Resize with height instead  
                newWidth = image.Width * maxHeight / image.Height;
                newHeight = maxHeight;
            }

            var res = new Bitmap(newWidth, newHeight);

            using (var graphic = Graphics.FromImage(res))
            {
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.SmoothingMode = SmoothingMode.HighQuality;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.CompositingQuality = CompositingQuality.HighQuality;
                graphic.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return res;
        }

        #endregion

        private readonly Usuario user;

        public FrmLogin()
        {
            InitializeComponent();

            user = new Usuario();

            #region BackgroundImage

            backgroundImage = Properties.Resources.key;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            #endregion
        }

        private void BEntrar_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidos()) return;

            if (user.UsuarioValido(tbUser.Text, tbPass.Text))
            {
                this.Hide();

                FrmMain main = new FrmMain();
                main.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void BSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CamposPreenchidos()
        {
            if (!tbUser.CampoPreenchido("Usuario")) return false;
            if (!tbPass.CampoPreenchido("Senha")) return false;

            return true;
        }
    }
}
