using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.Sql
{
    public static class ADOpet
    {
        static string connectionString;

        static ADOpet()
        {
            ADOpet.connectionString = "Server=.;Database=VetDB;Trusted_Connection=True;";
        }


        /// <summary>
        /// Get pet by ID of the DataBase 
        /// </summary>
        /// <param name="pet"></param>
        /// <returns></returns>
        public static Pet Get(Pet pet)
        {
            try
            {
                string query = "SELECT * FROM Pet WHERE Id=@Id";

                using (SqlConnection sqlConnection = new SqlConnection(ADOpet.connectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Id", pet.Id);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read()) 
                    { 

                        int id = Convert.ToInt32(reader["Id"]);
                        string name = (string)reader["Nombre"];
                        string clinicHistory = (string)reader["HistoriaClinica"];
                        DateTime birth = Convert.ToDateTime(reader["Nacimiento"]);
                        int dni = Convert.ToInt32(reader["Dni"]);
                        int phone = Convert.ToInt32(reader["Celular"]);

                        EPet tipo;

                        if (!Enum.TryParse(reader["Tipo"].ToString(), out tipo))
                        {
                            // Si el parseo fue exitoso, ahora puedes usar la variable tipo
                            throw new Exception("Error al obtener el TIPO de la mascota");
                        }

                        return new Pet(id, name, tipo, birth, dni, phone, clinicHistory);
                    }

                }

            }
            catch (Exception)
            {
                throw;
            }

            return null;
        }

        public static int Add(Pet pet)
        {
            try
            {
                string query = "INSERT INTO Pet (Nombre,Nacimiento,Tipo,Dni,Celular) VALUES (@Nombre,@Nacimiento,@Tipo,@Dni,@Celular)";

                using (SqlConnection sqlConnection = new SqlConnection(ADOpet.connectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Nombre", pet.Name);
                    //sqlCommand.Parameters.AddWithValue("HistoriaClinica", pet.ClinicHistory);
                    sqlCommand.Parameters.AddWithValue("Nacimiento", pet.Birth);
                    sqlCommand.Parameters.AddWithValue("Tipo", pet.Tipo.ToString());
                    sqlCommand.Parameters.AddWithValue("Dni", pet.Dni);
                    sqlCommand.Parameters.AddWithValue("Celular", pet.Phone);

                    sqlConnection.Open();

                    // Ejecutar la consulta y obtener el ID generado
                    int idGenerado = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    return idGenerado;



                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public static void Update(Pet pet)
        {
            try
            {
                string query = $"UPDATE Pet "+
                    "SET Nombre=@Nombre,HistoriaClinica=@HistoriaClinica,Nacimiento=@Nacimiento,Tipo=@Tipo,Dni=@Dni,Celular=@Celular) ";

                using (SqlConnection sqlConnection = new SqlConnection(ADOpet.connectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Nombre", pet.Name);
                    sqlCommand.Parameters.AddWithValue("HistoriaClinica", pet.ClinicHistory);
                    sqlCommand.Parameters.AddWithValue("Nacimiento", pet.Birth);
                    sqlCommand.Parameters.AddWithValue("Tipo", pet.Tipo);
                    sqlCommand.Parameters.AddWithValue("Dni", pet.Dni);
                    sqlCommand.Parameters.AddWithValue("Celular", pet.Phone);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Pet pet)
        {
            try
            {
                string query = $"DELETE FROM Pet WHERE Id=@Id";
                    
                using (SqlConnection sqlConnection = new SqlConnection(ADOpet.connectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("Id", pet.Id);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
