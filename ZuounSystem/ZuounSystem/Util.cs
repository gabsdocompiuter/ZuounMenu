using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZuounSystem
{
    public static class Util
    {
        #region Validação de Campos

        public static bool CampoPreenchido(this TextBox obj, string campo)
        {
            //Se o campo está preenchido, retorna verdadeiro
            if (!string.IsNullOrEmpty(obj.Text)) return true;

            MessageBox.Show($"Campo '{campo}' não preenchido!");
            obj.Focus();
            return false;
        }

        #endregion
    }
}
