using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Ciberdon
{
   public class CarpetaDAO
    {

        public static Dictionary<int, Folder> get(string dbPath)
        {
            string connection = Properties.Settings.Default.ConnectionString;
            connection = connection.Replace("PATH", dbPath);


            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Carpetas", con);
            OleDbDataReader reader = cmd.ExecuteReader();


            Dictionary<int, Folder> carpetas = new Dictionary<int, Folder>();
            while (reader.Read())
            {
                Folder c = new Folder();
                
                if (!reader.IsDBNull(0))
                    c.Id = reader.GetInt32(0);
                if (!reader.IsDBNull(1))
                    c.Nombre = reader.GetString(1);
                if (!reader.IsDBNull(2))
                    c.Habilitada = reader.GetBoolean(2);
                if (!reader.IsDBNull(3))
                    c.Carpeta = reader.GetString(3);

                carpetas.Add(c.Id, c);
            }

            reader.Close();

            return carpetas;

        }



        public static Dictionary<int, Folder> getObviar(string dbPath)
        {
            string connection = Properties.Settings.Default.ConnectionString;
            connection = connection.Replace("PATH", dbPath);


            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Obviar", con);
            OleDbDataReader reader = cmd.ExecuteReader();


            Dictionary<int, Folder> carpetas = new Dictionary<int, Folder>();
            while (reader.Read())
            {
                Folder c = new Folder();

                if (!reader.IsDBNull(0))
                    c.Id = reader.GetInt32(0);
                if (!reader.IsDBNull(1))
                    c.Carpeta = reader.GetString(1);

                carpetas.Add(c.Id, c);
            }

            reader.Close();

            return carpetas;

        }



        public static int insert(string dbPath, Folder c)
        {
            string strconnection = Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);
            OleDbCommand cmd = new OleDbCommand();


            cmd.CommandText = @"INSERT INTO Carpetas (NAME,ENABLED,PATH) 
                                VALUES(@NAME,@ENABLED,@PATH)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@NAME", OleDbType.VarChar, 255).Value = c.Nombre;
            cmd.Parameters.Add("@ENABLED", OleDbType.Boolean, 1).Value = c.Habilitada;
            cmd.Parameters.Add("@PATH", OleDbType.VarChar, 255).Value = c.Carpeta;


            cmd.Connection = connection;
            connection.Open();


            int rows = cmd.ExecuteNonQuery();

            string query2 = "Select @@Identity";
            int ID;

            cmd.CommandText = query2;
            ID = (int)cmd.ExecuteScalar();

            // cmd.Transaction.Commit();
            connection.Dispose();
            connection.Close();


            return ID;
        }

        public static void update(string dbPath, Folder c)
        {
            string strconnection = Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);



            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = @"UPDATE Carpetas SET NAME=@NAME, ENABLED=@ENABLED, PATH=@PATH WHERE ID=@ID";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@NAME", OleDbType.VarChar, 255).Value = c.Nombre;
            cmd.Parameters.Add("@ENABLED", OleDbType.Boolean, 1).Value = c.Habilitada;
            cmd.Parameters.Add("@PATH", OleDbType.VarChar, 255).Value = c.Carpeta;
            cmd.Parameters.Add("@ID", OleDbType.Integer, 255).Value = c.Id;



            cmd.Connection = connection;
            connection.Open();
            cmd.Transaction = connection.BeginTransaction();

            int rows = cmd.ExecuteNonQuery();


            cmd.Transaction.Commit();
            connection.Dispose();
            connection.Close();
        }



        public static void delete(string dbPath, int id)
        {
            string strconnection = Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);



            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = @"DELETE FROM Carpetas WHERE ID=@ID";

            cmd.CommandType = CommandType.Text;

           
            cmd.Parameters.Add("@ID", OleDbType.Integer, 255).Value = id;



            cmd.Connection = connection;
            connection.Open();
            cmd.Transaction = connection.BeginTransaction();

            int rows = cmd.ExecuteNonQuery();


            cmd.Transaction.Commit();
            connection.Dispose();
            connection.Close();
        }
    }
}
