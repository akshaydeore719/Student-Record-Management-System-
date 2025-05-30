
using System;
using System.Data.SqlClient;

namespace StudentRecordManagement {
    public class StudentService {
        private string connectionString = "Your Azure SQL connection string here";

        public void AddStudent(string name, int age, string grade) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Students (Name, Age, Grade) VALUES (@name, @age, @grade)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
