using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProjektlabor
{
    /// <summary>
    /// class Dbase
    /// creates a connection object to a database and contains 
    /// methods to manage database operations
    /// programmed by
    /// Julian Stegemann and Robin Weischer in 2020
    /// modified by BKR-teacher in 2021
    /// </summary>
    class Dbase
    {
        private string serverName = "176.9.200.211";
        private string databaseName = "projektlabor";
        private string uid = "root";
        private string passwd = "TSvdVO81D95InUO6";
        private string connString = string.Empty;
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
 

        #region Konstruktor
        /// <summary>
        /// Verbindung mit der Datenbank mit Standardwerten, außer des Datenbanknamens.
        /// </summary>
        /// <param name="_database">Name der Datenbank</param>
        public Dbase(string _database)
        {
            databaseName = _database;
            Connect();
        }

        /// <summary>
        /// Verbindung mit der Datenbank mit Angabe des Servers und der Datenbank.
        /// </summary>
        /// <param name="_servername">Name oder IP des Servers</param>
        /// <param name="_database">Name der Datenbank</param>
        public Dbase(string _servername, string _database)
        {
            serverName = _servername;
            databaseName = _database;
            Connect();
        }

        /// <summary>
        /// Verbindung mit der Datenbank unter Angabe aller Verbindungsdaten.
        /// </summary>
        /// <param name="_servername">Name oder IP des Servers</param>
        /// <param name="_database">Name der Datenbank</param>
        /// <param name="_uid">Benutzername des Datenbankbenutzers</param>
        /// <param name="_passwd">Passwort des Benutzers</param>
        public Dbase(string _servername, string _database, string _uid, string _passwd)
        {
            serverName = _servername;
            databaseName = _database;
            uid = _uid;
            passwd = _passwd;
            Connect();
        }
        #endregion

        /// <summary>
        /// Stellt eine neue Verbindung mit der Datenbank her und testet diese.
        /// </summary>
        public void Connect()
        {
            connString = $"SERVER={serverName};DATABASE={databaseName};UID={uid};PWD={passwd}";
            try
            {
                connection = new MySqlConnection(connString);
                connection.Open();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                connection = null;
                if (MessageBox.Show(ex.Message, "Datenbank Verbindungsfehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    Connect();
            }
        }

        /// <summary>
        /// Trennt eine Verbindung zur Datenbank.
        /// </summary>
        public void Disconnect()
        {
            command?.Dispose();
            command = null;
            connection?.Dispose();
            connection = null;
        }

        /// <summary>
        /// Gibt true zurück, wenn eine Verbindung zur Datenbank besteht.
        /// </summary>
        public bool ConnectionExist
        {
            get
            {
                if (connection == null) return false;
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Führt allgemeine Querys, wie "INSERT INTO", "UPDATE", "DELETE FROM" etc. aus.
        /// </summary>
        /// <param name="_query">Auszuführende SQL-Query</param>
        public void ExecuteQuery(string _query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(_query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message, "Datenbank Verbindungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region ToDataTable
        /// <summary>
        /// Führt eine SQL-Query aus und gibt diese in Form eines DataTables zurück.
        /// </summary>
        /// <param name="_query">Auszuführende SQL-Query</param>
        /// <returns>Rückgabe des befüllten DataTables</returns>
        public DataTable QueryToDataTable(string _query)
        {
            DataTable dtData = new DataTable();
            try
            {
                connection.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(_query, connection);
                adp.Fill(dtData);
                connection.Close();
                return dtData;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{_query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        /// <summary>
        /// Führt eine SQL-Query aus, die nur eine Tabelle besitzt, und gibt diese als DataTable zurück. 
        /// </summary>
        /// <param name="_table">Name der auszugebenden Tabelle</param>
        /// <returns>Rückgabe des befüllten DataTables</returns>
        public DataTable TableToDataTable(string _table)
        {
            DataTable dtData = new DataTable();
            string query = $"SELECT * FROM {_table}";
            try
            {
                connection.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, connection);
                adp.Fill(dtData);
                connection.Close();
                return dtData;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
        #endregion

        #region ToList
        /// <summary>
        /// Führt eine SQL-Query aus und gibt dies als Liste mit String-Arrays zurück.
        /// </summary>
        /// <param name="_query">Auszuführenden SQL-Query</param>
        /// <returns>Rückgabe der befüllten Liste</returns>
        public List<string[]> QueryToList(string _query)
        {
            List<string[]> listData = new List<string[]>();
            string[] row;
            try
            {
                connection.Open();
                command = new MySqlCommand(_query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    row = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i].ToString();
                    }
                    listData.Add(row);
                }
                reader.Close();
                connection.Close();
                return listData;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{_query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string[]>();
            }
        }

        /// <summary>
        /// Führt eine SQL-Query aus, die nur eine Tabelle besitzt, und gibt diese als Liste mit String-Arrays zurück.
        /// </summary>
        /// <param name="_table">Name der auszugebenden Tabelle</param>
        /// <returns>Rückgabe der befüllten Liste</returns>
        public List<string[]> TableToList(string _table)
        {
            List<string[]> listData = new List<string[]>();
            string[] row;
            string query = $"SELECT * FROM {_table}";
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    row = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i].ToString();
                    }
                    listData.Add(row);
                }
                reader.Close();
                connection.Close();
                return listData;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string[]>();
            }
        }

        /// <summary>
        /// Führt eine SQL-Query aus, die nur eine Tabelle und bestimmte Spalten besitzt, und gibt diese als Liste mit String-Arrays zurück.
        /// </summary>
        /// <param name="_table">Name der auszugebenden Tabelle</param>
        /// <param name="_columns">Namen der auszugebenden Spalten als ein String ("column1, column2, ...")</param>
        /// <returns>Rückgabe der befüllten Liste</returns>
        public List<string[]> TableToList(string _table, string _columns)
        {
            List<string[]> listData = new List<string[]>();
            string[] row;
            string query = $"SELECT {_columns} FROM {_table}";
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    row = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i].ToString();
                    }
                    listData.Add(row);
                }
                reader.Close();
                connection.Close();
                return listData;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string[]>();
            }
        }

        /// <summary>
        /// Führt eine SQL-Query aus, die nur eine Tabelle und bestimmte Spalten besitzt, und gibt diese als Liste mit String-Arrays zurück.
        /// </summary>
        /// <param name="_table">Name der auszugebenden Tabelle</param>
        /// <param name="_columns">Namen der auszugebenden Spalten als String-Array</param>
        /// <returns>Rückgabe der befüllten Liste</returns>
        public List<string> TableToListOne(string _table, string _columns)
        {
            List<string> listData = new List<string>();
            string query = $"SELECT {_columns} FROM {_table}";
            try
            {
                connection.Open();
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listData.Add(reader[0].ToString());
                }
                reader.Close();
                connection.Close();
                return listData;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }

        /// <summary>
        /// Gibt alle Spaltennamen der angegebenen Tabelle als Liste von Strings zurück.
        /// </summary>
        /// <param name="_table">Abzufragende Tabelle</param>
        /// <returns>Gibt die befüllte Liste zurück</returns>
        public List<string> GetColumnName(string _table)
        {
            DataTable dtData = new DataTable();
            List<string> columnCaptions = new List<string>();
            string query = $"SELECT * FROM {_table}";
            try
            {
                connection.Open();
                MySqlDataAdapter adp = new MySqlDataAdapter(query, connection);
                adp.Fill(dtData);
                connection.Close();
                for (int i = 0; i < dtData.Columns.Count; i++)
                {
                    columnCaptions.Add(dtData.Columns[i].ColumnName);
                }
                return columnCaptions;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }
        #endregion

        #region Optional, aber sinnvolle, Methoden
        /// <summary>
        /// Führt eine SQL-Query aus und fragt ab, ob das Ergebnis mindestens eine Row hat.
        /// </summary>
        /// <param name="_query">Auszuführende Query</param>
        /// <returns>Gibt zurück, ob das Ergebnis Rows hat</returns>
        public bool QueryToBool(string _query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(_query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                bool hasRows = reader.HasRows;
                reader.Close();
                connection.Close();
                return hasRows;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{_query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Führt eine SQL-Query aus und gibt das erste Feld der ersten Reihe als string zurück.
        /// </summary>
        /// <param name="_query">Auszuführende SQL-Query</param>
        /// <returns>Gibt das erste Feld als string zurück</returns>
        public string QueryToString(string _query)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand(_query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                string result = reader.GetString(0);
                reader.Close();
                connection.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{_query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public string QueryToStringNew(string _query)
        {
            try
            {
                string result = "";
                connection.Open();
                command = new MySqlCommand(_query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    result = reader[0].ToString();
                }
                reader.Close();
                connection.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
                MessageBox.Show(ex.Message + $"\n\n{_query}", "Datenbank Query-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        
        #endregion

        /// <summary>
        /// Dekonstruktor
        /// </summary>
        ~Dbase()
        {
            Disconnect();
        }
    }
}
