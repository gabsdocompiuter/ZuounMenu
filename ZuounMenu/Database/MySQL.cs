using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Database
{
    public class MySQL
    {
        //MySqlConnection 
        private readonly MySqlConnection Connection;

        private MySqlCommand Command;

        /// <summary>
        /// Dados Resultantes
        /// </summary>
        private MySqlDataReader Reader { get; set; }

        public MySQL()
        {
            string ip = "127.0.0.1";
            string dBase = "zuounmenu";
            string user = "zuoun";
            string pass = "1234";

            string connString = $@"server={ip};database={dBase};Uid={user};Pwd={pass}";
            Connection = new MySqlConnection(connString);
        }

        /// <summary>
        /// Abre a conexão com o banco de dados
        /// </summary>
        /// <returns></returns>
        private bool AbreConexao()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um erro ao abrir a conexão:\n" + e);
                return false;
            }
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados
        /// </summary>
        public void FechaConexao()
        {
            Connection.Close();
        }

        /// <summary>
        /// Prepara o MySQL para realizar uma consulta
        /// </summary>
        /// <param name="sql">SQL que será utilizado</param>
        private void PreparaMySQL(string sql)
        {
            AbreConexao();
            CreateCommand();

            Command.CommandText = sql;
        }

        /// <summary>
        /// Cria o Command
        /// </summary>
        private void CreateCommand()
        {
            try
            {
                Command = new MySqlCommand();
                Command = Connection.CreateCommand();
            }
            catch (Exception e)
            {
                throw (new Exception(e.Message));
            }
        }

        /// <summary>
        /// Executa SQL Non Query
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>Retorna se deu certo ou não</returns>
        public bool ExecuteNonQuery(string sql)
        {
            bool ret = true;
            PreparaMySQL(sql);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = false;
                throw (new Exception(e.Message));
            }

            FechaConexao();
            return ret;
        }

        #region Métodos para o Reader

        /// <summary>
        /// Executa consulta SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public void ExecuteReader(string sql)
        {
            PreparaMySQL(sql);

            try
            {
                Reader = null;
                Reader = Command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw (new Exception(e.Message));
            }
        }

        /// <summary>
        /// Verifica se a consulta retornou linhas
        /// </summary>
        /// <returns></returns>
        public bool HasRows()
        {
            bool auxReturn = false;
            if (Reader != null)
            {
                auxReturn = Reader.HasRows;
            }
            return auxReturn;
        }

        /// <summary>
        /// Lê próximo registro no Reader
        /// </summary>
        /// <returns>Retorna false quando acabar</returns>
        public bool ReadNextRecord()
        {
            bool auxReturn = false;
            if (Reader != null)
            {
                auxReturn = Reader.Read();
            }
            return auxReturn;
        }

        /// <summary>
        /// Retorna um inteiro
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public int GetInt(string column)
        {
            try
            {
                return Convert.ToInt32(Reader[column]);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Retorna uma string
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public string GetString(string column)
        {
            try
            {
                return Convert.ToString(Reader[column]);
            }
            catch
            {
                return string.Empty;
            }
        }

        #endregion
    }
}
