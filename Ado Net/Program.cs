using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;



var builder = new ConfigurationBuilder();
builder.AddJsonFile("appsetings.json");

var config = builder.Build();
var connectionString = config.GetConnectionString("Default");


using SqlConnection sqlConnection = new(connectionString);
sqlConnection.Open();

SqlCommand sqlCommand = new("select COUNT(*) from Students", sqlConnection);

void ReadMethod(string readfrom)
{
    sqlCommand = new($"select * from {readfrom}", sqlConnection);
    var read = sqlCommand.ExecuteReader();

    while (read.Read())
    {
        Console.WriteLine($"{read[1]}  {read[2]}  {read[3]}");
    }
}


object countStudents = sqlCommand.ExecuteScalar();
//Console.WriteLine($"Count of students: {countStudents}");


sqlCommand = new("select COUNT(*) from Teachers", sqlConnection);

object countTeachers = sqlCommand.ExecuteScalar();
//Console.WriteLine($"Count of teachers: {countTeachers}");


sqlCommand = new("select AVG(Salary) from Teachers", sqlConnection);

object avgSalary = sqlCommand.ExecuteScalar();
//Console.WriteLine($"Salary AVG Teachers: {avgSalary}");




//sqlCommand = new("insert into Students(StudentName, StudentSurname, Course) values(N'Рамиль', N'Теймуров', 4)", sqlConnection);
//sqlCommand.ExecuteNonQuery();
//ReadMethod("Students");


sqlCommand = new("DELETE from Students where StudentName = N'Рамиль'", sqlConnection);
sqlCommand.ExecuteNonQuery();
ReadMethod("Students");


//sqlCommand = new("UPDATE Students SET Course=2 where StudentName = N'Oleg'", sqlConnection);
//sqlCommand.ExecuteNonQuery();
//ReadMethod("Students");