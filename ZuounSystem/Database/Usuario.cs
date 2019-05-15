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

        public bool UsuarioValido(string user, string pass)
        {

            return true;
        }
    }
}
