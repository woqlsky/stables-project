using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Interfaces;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1.Edits
{
    public class StaffEdit : IStaff
    {
        private IList<Staff> _staff = new List<Staff>();
        public bool deleteStaff(Staff memberToDelete)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("DeleteStaff", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@staff_id", SqlDbType.Int).Value = memberToDelete.staff_id;
                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _staff.Remove(memberToDelete);
                sqlCommand.Dispose();
                con.Close();
            }
            return numberOfAffectedRows > 0;

        }

        public IEnumerable<Staff> GetStaff()
        {
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("GetStaff", con);
                con.Open();
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    var newMember = new Staff
                    {
                        staff_id = (int)dr["staff_id"],
                        name = dr["name"].ToString(),
                        surname = dr["surname"].ToString(),
                        position = dr["position"].ToString(),
                        salary = (int)dr["salary"]
                    };
                    _staff.Add(newMember);
                }
                sqlCommand.Dispose();
                con.Close();

            }
            return _staff;

        }

        public int insertStaff(Staff newMember)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("InsertStaff", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = newMember.name;
                sqlCommand.Parameters.Add("@surname", SqlDbType.VarChar).Value = newMember.surname;
                sqlCommand.Parameters.Add("@position", SqlDbType.VarChar).Value = newMember.position;
                sqlCommand.Parameters.Add("@salary", SqlDbType.Int).Value = newMember.salary;

                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _staff.Add(newMember);
                sqlCommand.Dispose();
                con.Close();

            }
            return numberOfAffectedRows;
        }

        public bool updateStaff(Staff member)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("UpdateStaff", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("staff_id", SqlDbType.Int).Value = member.staff_id;
                sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = member.name;
                sqlCommand.Parameters.Add("@surname", SqlDbType.VarChar).Value = member.surname;
                sqlCommand.Parameters.Add("@posotion", SqlDbType.VarChar).Value = member.position;
                sqlCommand.Parameters.Add("@salary", SqlDbType.Int).Value = member.salary;
                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                con.Close();
            }
            return numberOfAffectedRows > 0;

        }
    }
}
