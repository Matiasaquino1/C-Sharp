using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public class EmpleadoRepository // ADO.NET
    {
        private string connectionString = "Server=DESKTOP-SQ4VKBB;Database=EMPLEADOS_DB;Trusted_Connection=True;"; //conexión BD

        public List<Empleado> ObtenerEmpleados()// Traer todos los empleados de la BD
        {
            List<Empleado> empleados = new List<Empleado>();
            string query = "SELECT * FROM Empleados";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    empleados.Add(new Empleado
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        DNI = reader["DNI"].ToString(),
                        Edad = Convert.ToInt32(reader["Edad"]),
                        Casado = Convert.ToBoolean(reader["Casado"]),
                        Salario = Convert.ToDouble(reader["Salario"])
                    });
                }
            }
            return empleados;
        }

        public void AgregarEmpleado(Empleado empleado) 
        {
            string query = "INSERT INTO Empleados (NombreCompleto, DNI, Edad, Casado, Salario) VALUES (@NombreCompleto, @DNI, @Edad, @Casado, @Salario)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreCompleto", empleado.NombreCompleto);
                command.Parameters.AddWithValue("@DNI", empleado.DNI);
                command.Parameters.AddWithValue("@Edad", empleado.Edad);
                command.Parameters.AddWithValue("@Casado", empleado.Casado);
                command.Parameters.AddWithValue("@Salario", empleado.Salario);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ModificarEmpleado(Empleado empleado)
        {
            string query = "UPDATE Empleados SET NombreCompleto=@NombreCompleto, DNI=@DNI, Edad=@Edad, Casado=@Casado, Salario=@Salario WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", empleado.Id);
                command.Parameters.AddWithValue("@NombreCompleto", empleado.NombreCompleto);
                command.Parameters.AddWithValue("@DNI", empleado.DNI);
                command.Parameters.AddWithValue("@Edad", empleado.Edad);
                command.Parameters.AddWithValue("@Casado", empleado.Casado);
                command.Parameters.AddWithValue("@Salario", empleado.Salario);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EliminarEmpleado(int id)
        {
            string query = "DELETE FROM Empleados WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

