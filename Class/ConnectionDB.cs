using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SebraOut
{
    internal class ConnectionDB
    {
        public ConnectionDB() { }
        private static string getChainDB()
        {
            string host_DB = "bpjwzu8twqarobvbozjn-postgresql.services.clever-cloud.com";
            string port_DB = "5432";
            string name_DB = "bpjwzu8twqarobvbozjn";
            string user_DB = "u4xv8xoh3vaecggdpabc";
            string passwod_DB = "OaSf9E5SzR4oeq4uixf7M9BlEWhwRJ";



            string chainConnection = string.Format($"Host={host_DB};Port={port_DB};Database={name_DB};UserName={user_DB};Password={passwod_DB};");

            return chainConnection;
        }

        private NpgsqlConnection Connection;
        private NpgsqlCommand Command;
        private NpgsqlDataReader Reader;

        public void ManagerConnection()
        {
            try
            {
                Connection = new NpgsqlConnection(getChainDB());
                Connection.Open();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Alerta");
            }
        }

        public int New_Registro(int puntos)
        {
            ManagerConnection();

            int result = 0;

            try
            {
                string query = "INSERT INTO Usuario(puntaje) VALUES(@puntos)";

                Command = new NpgsqlCommand(query, Connection);

                
                Command.Parameters.AddWithValue("@puntos", puntos);
                

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;

        }

        
        public List<Puntos> List_Puntaje()
        {
            ManagerConnection();
            
            List<Puntos> list = new List<Puntos>();
            try
            {
                string query = $"SELECT * FROM usuario ORDER BY puntaje desc";


                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Puntos puntos = new Puntos();
                    puntos.Id = Reader.GetInt32(0);                    
                    puntos.Puntaje = Reader.GetInt32(1);
                    list.Add(puntos);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return list;
        }
    }
}
