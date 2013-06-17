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

        public static Dictionary<int, Carpeta> get(string dbPath)
        {
            string connection = Properties.Settings.Default.ConnectionString;
            connection = connection.Replace("PATH", dbPath);


            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Carpetas", con);
            OleDbDataReader reader = cmd.ExecuteReader();


            Dictionary<int, Carpeta> carpetas = new Dictionary<int, Carpeta>();
            while (reader.Read())
            {
                Carpeta c = new Carpeta();
                
                if (!reader.IsDBNull(0))
                    c.Id = reader.GetInt32(0);
                if (!reader.IsDBNull(1))
                    c.Path = reader.GetString(1);

                carpetas.Add(c.Id, c);
            }

            reader.Close();

            return carpetas;

        }



        public static Dictionary<int, Carpeta> getObviar(string dbPath)
        {
            string connection = Properties.Settings.Default.ConnectionString;
            connection = connection.Replace("PATH", dbPath);


            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Obviar", con);
            OleDbDataReader reader = cmd.ExecuteReader();


            Dictionary<int, Carpeta> carpetas = new Dictionary<int, Carpeta>();
            while (reader.Read())
            {
                Carpeta c = new Carpeta();

                if (!reader.IsDBNull(0))
                    c.Id = reader.GetInt32(0);
                if (!reader.IsDBNull(1))
                    c.Path = reader.GetString(1);

                carpetas.Add(c.Id, c);
            }

            reader.Close();

            return carpetas;

        }



        public static int insert(string dbPath, Carpeta c)
        {
            string strconnection = Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);
            OleDbCommand cmd = new OleDbCommand();


            cmd.CommandText = @"INSERT INTO Carpetas (PATH) 
                                VALUES(@PATH)";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@PATH", OleDbType.VarChar, 255).Value = c.Path;


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

        public static void update(string dbPath, Carpeta c)
        {
            string strconnection = Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);



            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = @"UPDATE Carpetas SET PATH=@PATH WHERE ID=@ID";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@PATH", OleDbType.VarChar, 255).Value = c.Path;
            cmd.Parameters.Add("@ID", OleDbType.Integer, 255).Value = c.Id;



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
