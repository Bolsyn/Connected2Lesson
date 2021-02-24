using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Connected2Lesson
{
    public class DataTable
    {
        public void CreateTable(Group group,string nameTable)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Server = DESKTOP-9EP80DV; DataBase = ConnectedLesson; Trusted_Connection = true;";
                connection.Open();

                string insertSqlScript = $"create table {nameTable} ({group.Id} {group.Id.GetType()}, {group.Name} {group.Name.GetType()})";
                SqlCommand command = new SqlCommand(insertSqlScript, connection);

                command.ExecuteNonQuery();
            }
        }

    }
}
