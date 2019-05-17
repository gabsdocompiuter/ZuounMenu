using Database.Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuounSystem.Menu
{
    public class MontaMenu
    {
        #region Tamanhos

        /// <summary>
        /// Altura do botão
        /// </summary>
        private int hBtn = 40;

        /// <summary>
        /// Largura do botão
        /// </summary>
        private int wBtn;

        /// <summary>
        /// Largura do Icn (Parte colorida na esquerda)
        /// </summary>
        private int wIcn = 7;

        #endregion

        #region Cores

        /// <summary>
        /// Cor do botão - stantard
        /// </summary>
        private Color crBtnSt = Color.FromArgb(217, 217, 217);

        /// <summary>
        /// Cor do botão - selecionado
        /// </summary>
        private Color crBtnSl = Color.FromArgb(59, 60, 63);

        /// <summary>
        /// Cor dos Icn (Parte colorida na esquerda)
        /// </summary>
        private Color crIcn = Color.FromArgb(30, 30, 30);

        #endregion

        private readonly Panel pMenu;

        private readonly Panel pSubMenu;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hBtn">Altura do Botão</param>
        /// <param name="wBtn">Largura do Botão</param>
        /// <param name="wIcn">Largura do Icn (parte colorida do botão)</param>
        public MontaMenu(Panel pMenu, Panel pSubMenu, int hBtn, int wBtn, int wIcn)
        {
            this.pMenu = pMenu;
            this.pSubMenu = pSubMenu;

            this.hBtn = hBtn;
            this.wBtn = wBtn;
            this.wIcn = wIcn;
        }

        public void CarregaMenu()
        {
            //Obtém as opções do banco de dados
            MenuPrincipal menu = new MenuPrincipal();
            ArrayList opcoes = menu.GetOpcoes();

            //Tamanho da tela
            int yOpc = pMenu.Size.Height;

            //Quantidade de itens no menu
            int qtd = opcoes.Count;

            //Calculo para centralizar os botões verticalmente
            int pos1 = ((yOpc - qtd * hBtn) / 2) - (hBtn / 2);

            for (int i = 0; i < qtd; i++)
            {
                int pos = pos1 + (i * hBtn);

                MenuPrincipalDTO dto = (MenuPrincipalDTO)opcoes[i];
                string nome = dto.Opcao;

                string icnNome = $"icn{nome}{i}";
                string btnNome = $"{nome}{i}";

                AddIcn(pos, icnNome);
                AddButton(pos, btnNome, dto.Descricao);
            }
        }

        /// <summary>
        /// Adiciona ícone lateral
        /// </summary>
        /// <param name="posY"></param>
        /// <param name="name"></param>
        private void AddIcn(int posY, string name)
        {
            Panel p = new Panel
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                BackColor = crIcn,
                Name = name,
                TabStop = false,
                Size = new Size(wIcn, hBtn),
                Location = new Point(0, posY),
                Visible = false
            };
            pMenu.Controls.Add(p);
        }

        /// <summary>
        /// Adiciona Botão no menu
        /// </summary>
        /// <param name="posY"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        private void AddButton(int posY, string name, string desc)
        {
            Button b = new Button
            {
                Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(0, posY),
                Font = new Font("Microsoft Sans Serif", 10F),
                ForeColor = crBtnSt,
                Name = name,
                Size = new Size(wBtn, hBtn),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(wIcn, 0, 0, 0),
                TabStop = true,
                Text = desc
            };
            b.FlatAppearance.BorderSize = 0;

            b.Click += new EventHandler(MenuClick);
            pMenu.Controls.Add(b);
        }

        /// <summary>
        /// Click de alguma opção do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuClick(object sender, EventArgs e)
        {
            //Deixa todos com a cor padrão
            foreach (Control c in pMenu.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }

                if (c is Button)
                {
                    c.BackColor = pMenu.BackColor;
                }
            }

            Button b = (Button)sender;
            string pName = "icn" + b.Name;

            //Muda para as novas cores
            b.BackColor = crBtnSl;

            Panel icn = pMenu.Controls.Find(pName, false).FirstOrDefault() as Panel;
            icn.Visible = true;

            MontaSubMenu subMenu = new MontaSubMenu(pSubMenu);
            subMenu.CarregaMenu();
        }
    }
}
