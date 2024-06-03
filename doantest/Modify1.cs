using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace doantest
{
    class Modify1
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public Modify1()
        {
        }
        public DataTable getAllCustomer()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from ThanhVien";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert(Customer customer)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "insert into ThanhVien values (@Id,@Name,@Birday,@Phone,@Gender,@Email)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = customer.Id;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customer.Name;
                sqlCommand.Parameters.Add("@Birday", SqlDbType.NVarChar).Value = customer.Birday.ToShortDateString();
                sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = customer.Phone;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = customer.Gender;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customer.Email;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public Customer GetCustomerById(string id)
        {
            Customer customer = null;
            string query = "SELECT * FROM ThanhVien WHERE Id = @Id";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new Customer
                        {
                            Id = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            Birday = DateTime.Parse(reader["Birday"].ToString()),
                            Phone = reader["Phone"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }
                }
                sqlConnection.Close();
            }
            return customer;
        }
        public bool DeleteCustomerById(string id)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                string query = "DELETE FROM ThanhVien WHERE Id = @Id";
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = id;
                    sqlCommand.ExecuteNonQuery();
                }
                catch
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
                return true;
            }
        }
        public bool update(Customer customer)
        {

            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string query = "UPDATE ThanhVien SET Name = @Name, Birday = @Birday, Phone = @Phone, Gender = @Gender, Email = @Email WHERE Id = @Id";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = customer.Id;
                sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = customer.Name;
                sqlCommand.Parameters.Add("@Birday", SqlDbType.NVarChar).Value = customer.Birday.ToShortDateString();
                sqlCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = customer.Phone;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = customer.Gender;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customer.Email;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }

    }
}
