using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Menu
{
    public class MenuPrincipal
    {
        private readonly MySQL my;

        public MenuPrincipal()
        {
            my = new MySQL();
        }

        public ArrayList GetOpcoes()
        {
            ArrayList array = new ArrayList();

            string sql = "SELECT * FROM menu";

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
