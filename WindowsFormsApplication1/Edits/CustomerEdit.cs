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
    public class CustomerEdit : ICustomer
    {
        private IList<Customer> _customers = new List<Customer>();
        public bool deleteCustomer(Customer customerDelete)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("DeleteCustomer", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@customer_id", SqlDbType.Int).Value = customerDelete.customer_id;
                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _customers.Remove(customerDelete);
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


        public int insertCustomer(Customer newCustomer)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("InsertCustomer", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = newCustomer.name;
                sqlCommand.Parameters.Add("@surname", SqlDbType.VarChar).Value = newCustomer.surname;
                sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = newCustomer.email;

                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _customers.Add(newCustomer);
                sqlCommand.Dispose();
                con.Close();

            }
            return numberOfAffectedRows;
        }

        public bool updateCustomer(Customer customer)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("UpdateCustomer", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("customer_id", SqlDbType.Int).Value = customer.customer_id;
                sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = customer.name;
                sqlCommand.Parameters.Add("@surname", SqlDbType.VarChar).Value = customer.surname;
                sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = customer.email;
                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                con.Close();
            }
            return numberOfAffectedRows > 0;

        }
    }
}
