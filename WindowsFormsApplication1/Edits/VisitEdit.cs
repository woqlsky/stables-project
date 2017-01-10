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
    public class VisitEdit : IVisit
    {
        private IList<Horse> _horses = new List<Horse>();
        private IList<Visit> _visits = new List<Visit>();
        private IList<Customer> _customers = new List<Customer>();

        public bool deleteVisit(Visit visitToDelete)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("DeleteVisit", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@visit_id", SqlDbType.Int).Value = visitToDelete.visit_id;
                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _visits.Remove(visitToDelete);
                sqlCommand.Dispose();
                con.Close();
            }
            return numberOfAffectedRows > 0;
        }

        public IEnumerable<Customer> GetCustomer()
        {
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("GetCustomer", con);
                con.Open();
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Customer newCustomer = new Customer
                    {
                        customer_id = (int)dr["customer_id"],
                        name = dr["name"].ToString(),
                        surname = dr["surname"].ToString(),
                        email = dr["email"].ToString()
                    };
                    _customers.Add(newCustomer);
                }
                sqlCommand.Dispose();
                con.Close();

            }
            return _customers;
        }

        public IEnumerable<Horse> GetHorse()
        {
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("GetHorse", con);
                con.Open();
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    var newHorse = new Horse
                    {
                        horse_id = (int)dr["horse_id"],
                        price = (int)dr["price"]
                    };
                    _horses.Add(newHorse);
                }
                sqlCommand.Dispose();
                con.Close();

            }
            return _horses;
        }

        public IEnumerable<Visit> GetVisit()
        {
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("GetVisit", con);
                con.Open();
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    var newVisit = new Visit
                    {
                        visit_id = (int)dr["visit_id"],
                        visitor = (int)dr["visitor"],
                        which_horse = (int)dr["which_horse"],
                        which_day = dr["which_day"].ToString()
                    };
                    _visits.Add(newVisit);
                }
                sqlCommand.Dispose();
                con.Close();

            }
            return _visits;

        }

        public int insertVisit(Visit newVisit)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("InsertVisit", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@visitor", SqlDbType.Int).Value = newVisit.visitor;
                sqlCommand.Parameters.Add("@which_horse", SqlDbType.Int).Value = newVisit.which_horse;
                sqlCommand.Parameters.Add("@which_day", SqlDbType.VarChar).Value = newVisit.which_day;

                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _visits.Add(newVisit);
                sqlCommand.Dispose();
                con.Close();

            }
            return numberOfAffectedRows;
        }

        public bool updateVisit(Visit newVisit)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("UpdateVisit", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("visit_id", SqlDbType.Int).Value = newVisit.visit_id;
                sqlCommand.Parameters.Add("@visitor", SqlDbType.Int).Value = newVisit.visitor;
                sqlCommand.Parameters.Add("@which_horse", SqlDbType.Int).Value = newVisit.which_horse;
                sqlCommand.Parameters.Add("@which_day", SqlDbType.VarChar).Value = newVisit.which_day;

                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                con.Close();
            }
            return numberOfAffectedRows > 0;
        }
    }
}
