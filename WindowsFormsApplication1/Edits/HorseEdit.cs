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

        public class HorseEdit : IHorse

        {
            private IList<Horse> _horses = new List<Horse>();
            public bool deleteHorse(Horse horseDelete)
            {
                var numberOfAffectedRows = 0;
                using (var con = new SqlConnection(Settings.Default.StableConnectionString))
                {
                    var sqlCommand = new SqlCommand("DeleteHorse", con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@horse_id", SqlDbType.Int).Value = horseDelete.horse_id;
                    con.Open();
                    numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                    _horses.Remove(horseDelete);
                    sqlCommand.Dispose();
                    con.Close();
                }
                return numberOfAffectedRows > 0;

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
                        Horse newHorse = new Horse
                        {
                            horse_id = (int)dr["horse_id"],
                            name = dr["name"].ToString(),
                            price = (int)dr["price"],
                        };
                        _horses.Add(newHorse);
                    }
                    sqlCommand.Dispose();
                    con.Close();

                }
                return _horses;

            }


            public int insertHorse(Horse newHorse)
            {
                var numberOfAffectedRows = 0;
                using (var con = new SqlConnection(Settings.Default.StableConnectionString))
                {
                    var sqlCommand = new SqlCommand("InsertHorse", con);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = newHorse.name;
                    sqlCommand.Parameters.Add("@price", SqlDbType.VarChar).Value = newHorse.price;

                    con.Open();
                    numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                    _horses.Add(newHorse);
                    sqlCommand.Dispose();
                    con.Close();

                }
                return numberOfAffectedRows;
            }

            public bool updateHorse(Horse horse)
            {
                var numberOfAffectedRows = 0;
                using (var con = new SqlConnection(Settings.Default.StableConnectionString))
                {
                    var sqlCommand = new SqlCommand("UpdateHorse", con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("horse_id", SqlDbType.Int).Value = horse.horse_id;
                    sqlCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = horse.name;
                    sqlCommand.Parameters.Add("@price", SqlDbType.Int).Value = horse.price;
                    numberOfAffectedRows = sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    con.Close();
                }
                return numberOfAffectedRows > 0;

            }
        }
}
