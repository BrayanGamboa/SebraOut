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

        public int New_Usuario(Usuario usuario)
        {
            ManagerConnection();

            int result = 0;

            try
            {
                string query = "INSERT INTO Usuario(nombre, apellido, email, puntos) VALUES(@nombre,@apellido,@email, 0)";

                Command = new NpgsqlCommand(query, Connection);

                
                Command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                Command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                Command.Parameters.AddWithValue("@email", usuario.Email);

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;

        }

        public int Update_Usuario(string correo, int puntos)
        {
            ManagerConnection();

            int result = 0;

            try
            {
                string query = $"UPDATE usuario SET puntos = @puntos WHERE email = @correo";

                Command = new NpgsqlCommand(query, Connection);


                Command.Parameters.AddWithValue("@puntos", puntos);
                Command.Parameters.AddWithValue("@email", correo);                

                result = Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: '{err.Message}'", "Error");
            }
            Connection.Close();

            return result;

        }
        public List<Usuario> List_Usuarios()
        {
            ManagerConnection();
            
            List<Usuario> list = new List<Usuario>();
            try
            {
                string query = $"SELECT nombre, email, puntos FROM usuario";


                Command = new NpgsqlCommand(query, Connection);
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Nombre = Reader.GetString(0);
                    usuario.Email = Reader.GetString(1);
                    usuario.Puntos = Reader.GetInt32(2);
                    list.Add(usuario);
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
