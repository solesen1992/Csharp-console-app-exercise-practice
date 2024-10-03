using Exercise_DatabaseFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Exercise_DatabaseFirst.Data
{
    public class DBConnection
    {
        //string dbConnection = "Data Source=localhost;Initial Catalog=Cars-Dapper;User ID=sa;Password=SecretPassword01;Encrypt=False";
        private readonly string dbConnection = ConfigurationManager.ConnectionStrings["ConnectMsSqlString"].ToString();
        public List<Cars> GetAllCars()
        {
            List<Cars> result = null;
            string queryString = "select * from Cars";

            using (SqlConnection conn = new SqlConnection(dbConnection))
            using (SqlCommand readCommand = new SqlCommand(queryString, conn))
            {
                if (conn != null)
                {
                    conn.Open();
                    SqlDataReader carsReader = readCommand.ExecuteReader();
                    result = GetCarsObjects(carsReader);
                }

                return result;
            }


        }

        private List<Cars> GetCarsObjects(SqlDataReader carsReader)
        {

            List<Cars> result = new List<Cars>();
            Cars tempCar;
            string Licenseplate; string Make; string Model; string Color;

            while (carsReader.Read())
            {
                //tempId = (int)productReader[0];
                Licenseplate = carsReader.GetString(carsReader.GetOrdinal("Licenseplate"));
                Make = carsReader.GetString(carsReader.GetOrdinal("Make"));
                Model = carsReader.GetString(carsReader.GetOrdinal("Model"));
                Color = carsReader.GetString(carsReader.GetOrdinal("Color"));

                tempCar = new Cars(Licenseplate, Make, Model, Color);

                result.Add(tempCar);
            }

            return result;
        }

        public bool InsertCar(Cars carToInsert)
        {
            int numRowsInserted = 0;
            using (SqlConnection connection = new SqlConnection(dbConnection))
            {
                connection.Open();
                using (SqlCommand cmdInsertCar = connection.CreateCommand())
                {
                    cmdInsertCar.CommandText = "INSERT INTO Cars(Licenseplate, Make, Model, Color) VALUES(@Licenseplate, @Make, @Model, @Color)";
                    cmdInsertCar.Parameters.AddWithValue("Licenseplate", carToInsert.Licenseplate);
                    cmdInsertCar.Parameters.AddWithValue("Make", carToInsert.Make);
                    cmdInsertCar.Parameters.AddWithValue("Model", carToInsert.Model);
                    cmdInsertCar.Parameters.AddWithValue("Color", carToInsert.Color);
                    numRowsInserted = cmdInsertCar.ExecuteNonQuery();
                }
            }
            return (numRowsInserted == 1);
        }
    }
}
