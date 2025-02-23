using AdoCurd.Models;
using Microsoft.Data.SqlClient;

namespace AdoCurd.Data
{
    public class UserDbOperations : Connection
    {
        //passing configuration to connection class
        public UserDbOperations(IConfiguration configuration) : base(configuration) { }

        //GetAllUsers

        public List<User> GetAllUsers()
        {
            //creating a list of user type
            var users = new List<User>();

            using(var connection = new SqlConnection(_connectionstring))
            {
                var command = new SqlCommand("SELECT * FROM Users", connection);
                connection.Open();
                
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Age = (int)reader["Age"],
                            Gender = (string)reader["Gender"]
                        });
                    }
                }
            }

            return users;

        }


        //insert user details
        public void InsertUser(User users)
        {
            using(var connection = new SqlConnection(_connectionstring))
            {
                var command = new SqlCommand("INSERT INTO Users (Name, Age, Gender) VALUES (@Name, @Age, @Gender)", connection);
                command.Parameters.AddWithValue("@Name", users.Name);
                command.Parameters.AddWithValue("@Age", users.Age);
                command.Parameters.AddWithValue("@Gender", users.Gender);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //update user 

        public void UpdateUser(User users)
        {
            using(var connection = new SqlConnection(_connectionstring))
            {
                var command = new SqlCommand("UPDATE Users SET Name=@Name, Age=@Age, Gender=@Gender WHERE Id=@Id", connection);
                command.Parameters.AddWithValue("@Name", users.Name);
                command.Parameters.AddWithValue("@Age", users.Age);
                command.Parameters.AddWithValue("@Gender", users.Gender);
                command.Parameters.AddWithValue("@Id", users.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //delete
        public void DeleteUser(int id)
        {
            using(var connection = new SqlConnection(_connectionstring))
            {
                var command = new SqlCommand("DELETE FROM Users WHERE Id=@Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public User? GetUser(int id)
        {
            User? singleuser = null;
            
            using(var connection = new SqlConnection(_connectionstring))
            {
                var command = new SqlCommand("Select * from users where id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();

                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        singleuser = new User
                        {

                            Name = (string)reader["Name"],
                            Age = (int)reader["Age"],
                            Gender = (string)reader["Gender"]

                        };
                    }
                }
            }

            return singleuser;
        }
    }
}
