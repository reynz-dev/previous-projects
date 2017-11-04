using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using App.Common.Entities;
using App.DataAccessLayer;

namespace App.DBLayer.Repositories
{
    public class MemberRepository
    {
        private readonly SqlConnection _sqlConnection;

        public MemberRepository(string connectionString)
        {
            _sqlConnection = DataAccessFactory.GetOpenConnection(connectionString);
        }

        public IEnumerable<Member> GetMembers()
        {
            DataTable dataTable;

            using (_sqlConnection)
            {
                var command = new SqlCommand
                {
                    CommandText = @"SELECT * FROM Member",
                    Connection = _sqlConnection
                };

                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
            }

            return (from DataRow record in dataTable.Rows
            select new Member
            {
                Id = Convert.ToInt32(record[0].ToString()),
                FirstName = record[1].ToString(),
                LasttName = record[2].ToString(),
                Gender = record[3].ToString()
            }).ToList();
        }

        public IEnumerable<Member> GetMemberByLastName(string lastName)
        {
            DataTable dataTable;

            using (_sqlConnection)
            {
                var command = new SqlCommand
                {
                    CommandText = $@"SELECT * FROM Member WHERE L_Name = '{lastName}'",
                    Connection = _sqlConnection
                };

                dataTable = new DataTable();
                dataTable.Load(command.ExecuteReader());
            }

            return (from DataRow record in dataTable.Rows
            select new Member
            {
                Id = Convert.ToInt32(record[0].ToString()),
                FirstName = record[1].ToString(),
                LasttName = record[2].ToString(),
                Gender = record[3].ToString()
            }).ToList();
        }
    }
}
