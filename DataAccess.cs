using System.Collections.Generic;
using System.Data.SqlClient;

public class DataAccess
{
    private string connectionString = "Server=localhost;Database=VF_Portfolio1;Integrated Security=True;\r\n   ";

    // Method to retrieve employees from the database
    public List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Id, Name FROM Person";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                employees.Add(new Employee
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                });
            }
        }

        return employees;
    }
}
