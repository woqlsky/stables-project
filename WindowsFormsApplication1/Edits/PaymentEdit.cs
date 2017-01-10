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
    class PaymentEdit : IPayment
    {
        private IList<Visit> _visits = new List<Visit>();
        private IList<Payment> _payments = new List<Payment>();
        public bool deletePayment(Payment paymentDelete)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("DeletePayment", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@pay_id", SqlDbType.Int).Value = paymentDelete.pay_id;
                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _payments.Remove(paymentDelete);
                sqlCommand.Dispose();
                con.Close();
            }
            return numberOfAffectedRows > 0;

        }

        public IEnumerable<Payment> GetPayment()
        {
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("GetPayment", con);
                con.Open();
                var dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Payment newPayment = new Payment
                    {
                        pay_id = (int)dr["pay_id"],
                        for_which_visit = (int)dr["for_which_visit"],
                        sum_of_payment = (int)dr["sum_of_payment"],
                    };
                    _payments.Add(newPayment);
                }
                sqlCommand.Dispose();
                con.Close();

            }
            return _payments;

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


        public int insertPayment(Payment newPayment)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("InsertPayment", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@for_which_visit", SqlDbType.Int).Value = newPayment.for_which_visit;
                sqlCommand.Parameters.Add("@sum_of_payment", SqlDbType.Int).Value = newPayment.sum_of_payment;

                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                _payments.Add(newPayment);
                sqlCommand.Dispose();
                con.Close();

            }
            return numberOfAffectedRows;
        }

        public bool updatePayment(Payment payment)
        {
            var numberOfAffectedRows = 0;
            using (var con = new SqlConnection(Settings.Default.StableConnectionString))
            {
                var sqlCommand = new SqlCommand("UpdatePayment", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("pay_id", SqlDbType.Int).Value = payment.pay_id;
                sqlCommand.Parameters.Add("@for_which_visit", SqlDbType.Int).Value = payment.for_which_visit;
                sqlCommand.Parameters.Add("@sum_of_payment", SqlDbType.Int).Value = payment.sum_of_payment;
                con.Open();
                numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                con.Close();
            }
            return numberOfAffectedRows > 0;

        }
    }
}
