using System.Data.SqlClient;
using ADONetCurd.Models;
using System.Data;

namespace ADONetCurd.Repository;

public class StudentRepository
{
    private readonly string _connectionString;
    public IConfiguration Configuration { get; }

    public StudentRepository(IConfiguration configuration)
    {
        Configuration = configuration;
        _connectionString = Configuration["ConnectionStrings:DefaultConnection"];
    }

    public IEnumerable<Student> Get()
    {
        var students = new List<Student>();
        DataTable dataTable = new DataTable();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = "Select * from Student";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
        }

        for (int i = 0; i < dataTable.Rows.Count; i++)
        {
            var student = new Student()
            {
                Id = Convert.ToInt32(dataTable.Rows[i]["Id"]),
                Name = dataTable.Rows[i]["Name"].ToString(),
                City = dataTable.Rows[i]["City"].ToString(),

            };
            students.Add(student);
        }

        return students;
    }

    public bool Create(Student student)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = $"Insert into Student (Id, Name, City) Values ('{student.Id}', " +
                         $"'{student.Name}', '{student.City}')";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
    }

    public string CreateUsingStoredProcedure(Student student)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = "CreateStudent";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = student.Id,
                    SqlDbType = SqlDbType.Int,
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = student.Name,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };
                command.Parameters.Add(parameter);

                parameter = new SqlParameter
                {
                    ParameterName = "@City",
                    Value = student.City,
                    SqlDbType = SqlDbType.VarChar,
                    Size = 50
                };
                command.Parameters.Add(parameter);

                connection.Open();
                command.ExecuteNonQuery();
                string result = command.Parameters["@Result"].Value.ToString();
                connection.Close();
                return result;
            }
        }
    }

    public bool Update(Student student, int id)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = $"Update Student SET Id='{student.Id}', Name='{student.Name}', City='{student.City}' Where Id='{id}'";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            return true;
        }
    }

    public bool Delete(int id)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string sql = $"Delete From Student Where Id='{id}'";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            return true;
        }
    }
}
