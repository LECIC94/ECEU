using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.OracleClient;

namespace ECEUWin
{
    public class SQLDataAcces
    {
        public void ObtieneTablas(System.Windows.Forms.ListBox lista)
        {
            lista.Items.Clear();
            Sentencia = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE' ORDER BY table_name";
            DataSet Ds = new DataSet();
            Ds = GetData();
            foreach(DataRow Dr in Ds.Tables[0].Rows)
            {
                lista.Items.Add(Dr["Table_name"].ToString());
            }
        }
        public void Obtienecampos(System.Windows.Forms.ListBox lista,string tabla)
        {
            lista.Items.Clear();
            Sentencia = "SELECT column_name FROM Information_Schema.Columns where Table_Name = '"+tabla+"'";
            DataSet Ds = new DataSet();
            Ds = GetData();
            foreach (DataRow Dr in Ds.Tables[0].Rows)
            {
                lista.Items.Add(Dr["column_name"].ToString());
            }
        }

        public DataSet Buscainfo()
        {
            DataSet dsRet = new DataSet();

            return dsRet;
        }
        public DataSet GetData()
        {
            DataSet dsDatos = new DataSet();
            string connectionstring = ConfigurationManager.ConnectionStrings["Laboratorio"].ConnectionString;

            //Adn es la cadena de conexion en el web.config
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = new SqlCommand(Sentencia, connection))
                {
                    //OleDbCommand cmdConsultar = new OleDbCommand(strCommand, objConn);
                    SqlDataAdapter objAdapter = new SqlDataAdapter();
                    command.CommandTimeout = 36000;
                    command.CommandType = CommandType.Text;
                    command.CommandText = Sentencia;
                    //DataSet dtsDatos=new DataSet();
                    objAdapter.SelectCommand = command;
                    //sqlConn.Open();

                    objAdapter.Fill(dsDatos);
                }
            }
            return dsDatos;
        }
        public String Sentencia
        {
            get;
            set;
        }
    }

    public class MYSQLDataAcces
    {
        public void ObtieneTablas(System.Windows.Forms.ListBox lista)
        {
            lista.Items.Clear();
            Sentencia = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE table_type = 'BASE TABLE' AND TABLE_SCHEMA != 'mysql' AND TABLE_SCHEMA != 'world' AND TABLE_SCHEMA !='sakila' AND TABLE_SCHEMA !='sys' AND ENGINE='innoDB' ORDER BY table_name";
            DataSet Ds = new DataSet();
            Ds = GetData();
            foreach (DataRow Dr in Ds.Tables[0].Rows)
            {
                lista.Items.Add(Dr["Table_name"].ToString());
            }
        }

        public void Obtienecampos(System.Windows.Forms.ListBox lista, string tabla)
        {
            lista.Items.Clear();
            Sentencia = "SELECT column_name FROM Information_Schema.Columns where Table_Name = '" + tabla + "'";
            DataSet Ds = new DataSet();
            Ds = GetData();
            foreach (DataRow Dr in Ds.Tables[0].Rows)
            {
                lista.Items.Add(Dr["column_name"].ToString());
            }
        }

        public DataSet Buscainfo()
        {
            DataSet dsRet = new DataSet();

            return dsRet;
        }
        public DataSet GetData()
        {
            DataSet dsDatos = new DataSet();
            string connectionstring = ConfigurationManager.ConnectionStrings["Laboratorio"].ConnectionString;

            //Adn es la cadena de conexion en el web.config
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                using (MySqlCommand command = new MySqlCommand(Sentencia, connection))
                {
                    //OleDbCommand cmdConsultar = new OleDbCommand(strCommand, objConn);
                    MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                    command.CommandTimeout = 36000;
                    command.CommandType = CommandType.Text;
                    command.CommandText = Sentencia;
                    //DataSet dtsDatos=new DataSet();
                    objAdapter.SelectCommand = command;
                    //sqlConn.Open();

                    objAdapter.Fill(dsDatos);
                }
            }
            return dsDatos;
        }
        public String Sentencia
        {
            get;
            set;
        }
    }

    public class ORACLEDataAcces
    {

        public DataSet Buscainfo()
        {
            DataSet dsRet = new DataSet();

            return dsRet;
        }
        public DataSet GetData()
        {
            DataSet dsDatos = new DataSet();
            string connectionstring = ConfigurationManager.ConnectionStrings["Laboratorio"].ConnectionString;

            //Adn es la cadena de conexion en el web.config
            using (OracleConnection connection = new OracleConnection(connectionstring))
            {
                using ( OracleCommand command = new OracleCommand(Sentencia, connection))
                {
                    //OleDbCommand cmdConsultar = new OleDbCommand(strCommand, objConn);
                    OracleDataAdapter objAdapter = new OracleDataAdapter();
                    command.CommandTimeout = 36000;
                    command.CommandType = CommandType.Text;
                    command.CommandText = Sentencia;
                    //DataSet dtsDatos=new DataSet();
                    objAdapter.SelectCommand = command;
                    //sqlConn.Open();

                    objAdapter.Fill(dsDatos);
                }
            }
            return dsDatos;
        }
        public String Sentencia
        {
            get;
            set;
        }
    }
}
