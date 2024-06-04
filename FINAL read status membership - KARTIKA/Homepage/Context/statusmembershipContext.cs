using Homepage.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homepage.Context
{
    internal class statusmembershipContext
    {
        public List<statusmembership> statuslist = new List<statusmembership>();

        public bool Read()
        {
            bool isSuccess = false;
            string constr = "Server = localhost; Port = 5432; Database = JT - Apps; User Id = postgres; Password = timotius";

            using (NpgsqlConnection connection = new NpgsqlConnection(constr))
            {
                string sql = @"SELECT membership_membership_id FROM ""User""";

                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                using (NpgsqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        statusmembership newStatus = new statusmembership();
                        newStatus.status = (int)Reader["membership_membership_id"];
                        statuslist.Add(newStatus);
                    }
                }
            }

            return isSuccess;
        }
    }
}
//aktif : where membership_membership_id = 1