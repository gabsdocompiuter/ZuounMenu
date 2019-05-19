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

        public ArrayList GetOpcoes()
        {
            ArrayList array = new ArrayList();

            string sql = "SELECT * FROM submenu";

            my.ExecuteReader(sql);

            if (my.HasRows())
            {
                while (my.ReadNextRecord())
                {
                    MenuPrincipalDTO dto = new MenuPrincipalDTO
                    {
                        Descricao = my.GetString("descricao"),
                        Opcao = my.GetString("opcao")
                    };
                    array.Add(dto);
                }
            }

            return array;
        }
    }
}
