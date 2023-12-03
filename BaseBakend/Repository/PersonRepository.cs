using BaseBakend.Contract;
using BaseBakend.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseBakend.Repository;

public  class PersonRepository : BaseRepository
{
    const string ConnectionString = "Data Source=.;Initial Catalog=Library;Integrated Security=True";

    public override bool Insert(PersonClass per)

    {
        PersonClass person = new PersonClass();
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            try
            {
                connection.Open();

                string tableName = "dbo.Person";

                string query = $"INSERT INTO{tableName}(NationalCode,FirstName,LastName,PhoneNumber,IsAdmin,IsActive,CreationDate" +
                "VALUES(@Id,@NationaCode,@FirstName,@LastName,@PhoneNumber,@IsAdmin,@IsActive,@CreationDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NationalCode", person.NationalCode);
                command.Parameters.AddWithValue("@FirstName", person.FirstName);
                command.Parameters.AddWithValue("@LastName", person.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", person.PhoneNumber);
                command.Parameters.AddWithValue("@IsAdmin", person.IsAdmin);
                command.Parameters.AddWithValue("@IsActive", person.IsActive);
                command.Parameters.AddWithValue("@CreationDate", person.CreationDate);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
    }


    public override List<PersonClass> GetPeople()
    {
        List<PersonClass> people = new List<PersonClass>();
        string tableName = "Library.Person";
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            try
            {
                connection.Open();
                string query = $"SELECT Id,NationalCode,FirstName,LastName,PhoneNumber,IsAdmin,IsActive,CreationDate FROM{tableName}";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PersonClass person = new PersonClass()
                    {
                        PersonID = (int)reader["Id"],
                        NationalCode = reader["NationalCode"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        IsAdmin = reader["IsAdmin"].Equals(true),
                        IsActive = reader["IsActive"].Equals(true),



                    };
                    people.Add(person);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(message: "Error");
            }
            finally
            {
                connection.Close();
            }
            return people;
        }

    }
}



    



