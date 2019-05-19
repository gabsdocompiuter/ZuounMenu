using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database
{
    public class Usuario
    {
        private readonly MySQL my;

        public Usuario()
        {
            my = new MySQL();
        }

        /// <summary>
        /// Valida se o usuário e senha informado estão corretos
        /// </summary>
        /// <param name="user">Usuário</param>
        /// <param name="pass">Senha</param>
        /// <returns></returns>
        public bool UsuarioValido(string user, string pass)
        {
            string sql = $@"SELECT 1
                               FROM usuario
                               WHERE user = '{user}'
                                 AND senha = '{pass}';";
            my.ExecuteReader(sql);
            bool valido = my.HasRows();

            my.FechaConexao();
            return valido;
        }
    }
}
