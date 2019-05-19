using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Menu
{
    public class SubMenu
    {
        private readonly MySQL my;

        public SubMenu()
        {
            my = new MySQL();
        }

        public ArrayList GetOpcoes(MenuPrincipalDTO pai)
        {
            ArrayList array = new ArrayList();

            string sql = $"SELECT * FROM submenu WHERE menuPai = {pai.Id}";

            my.ExecuteReader(sql);

            if (my.HasRows())
            {
                while (my.ReadNextRecord())
                {
                    SubMenuDTO dto = new SubMenuDTO
                    {
                        Id = my.GetInt("id"),
                        MenuPai = pai,
                        Descricao = my.GetString("descricao"),
                        Opcao = my.GetString("opcao"),
                        Nivel = my.GetInt("nivel")
                    };
                    array.Add(dto);
                }
            }

            return array;
        }
    }
}
