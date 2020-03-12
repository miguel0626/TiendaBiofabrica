using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class ClientesData
    {
        public static MySqlConnection ConexionBd()
        {
            MySqlConnection conex = new MySqlConnection
            ("Server=127.0.0.1;" +
            "Database=bdbiofabrica;" +
            "Uid=root;" +
            "Pwd=;" +
            "SslMode=None");
            return conex;
        }

        public static bool GuardarCliente(ClientesEntity cliente)
        {

            MySqlConnection conex = ConexionBd();
            conex.Open();
            string sql = @"INSERT INTO cliente
                    (idcedula, nombre, apellidos, telefono, correo)
                     VALUES(@cedula, @nombre, @apellidos, @telefono, @correo )";
            MySqlCommand cmd = new MySqlCommand(sql, conex);
            cmd.Parameters.AddWithValue("@cedula", cliente.NumeroDocumento);
            cmd.Parameters.AddWithValue("@nombre", cliente.Primerombre);
            cmd.Parameters.AddWithValue("@apellidos", cliente.PrimerApellido);
            cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@correo", cliente.Email);
            int NumeroFilas = Convert.ToInt32(cmd.ExecuteNonQuery());
            if (NumeroFilas > 0)
            {
                return true;
            }
            else {

                return false;
            }

        }


    }
}

