using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace DataBankSystem
{
    public class DataAccess
    {

        static string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public static bool CheckUserNameAvailable(int AdminID,String UserName)
        {
            
            String query = "SELECT CASE WHEN EXISTS (SELECT 1  FROM Admins WHERE UserName = @UserName AND AdminID <> @AdminID ) THEN 1 ELSE 0 END";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@AdminID", AdminID);
               

                    con.Open();
                    int result =Convert.ToInt32(command.ExecuteScalar());

                    return result == 1;
            }
            
        }
   

        public static bool GetAdminInfoByUserName(ref int AdminID, ref String UserName, ref String password, ref String fullName, ref String createdDate,ref String picturePath,ref int Role)
        {
            bool isAdmin = false;
            String Query = "SELECT * FROM Admins WHERE UserName = @UserName";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                command.Parameters.AddWithValue("@UserName", UserName);
                try
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            AdminID = Convert.ToInt32(reader["AdminID"]);
                            password = reader["PassowrdHash"].ToString();
                            fullName = reader["FullName"].ToString();
                            createdDate = Convert.ToDateTime(reader["CreatedDate"]).ToString("yyyy-MM-dd");
                            if (reader["PicturePath"] == DBNull.Value) 
                                picturePath = "";
                            else
                                picturePath = reader["PicturePath"].ToString();
                            Role = Convert.ToInt32(reader["Role"]);
                            isAdmin = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    isAdmin = false;
                }

                return isAdmin;
            }
        }
        public static bool GetAdminInfoByID(ref int AdminID, ref String UserName, ref String password, ref String fullName, ref String createdDate, ref String picturePath, ref int Role)
        {

            bool isAdmin = false;
            String Query = "SELECT * FROM Admins WHERE AdminID = @AdminID";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                command.Parameters.AddWithValue("@AdminID", AdminID);
                try
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {                   
                            UserName = reader["UserName"].ToString();
                            password = reader["PassowrdHash"].ToString();
                            fullName = reader["FullName"].ToString();
                            createdDate = Convert.ToDateTime(reader["CreatedDate"]).ToString("yyyy-MM-dd");
                            if (reader["PicturePath"] == DBNull.Value)
                                picturePath = "";
                            else
                                picturePath = reader["PicturePath"].ToString();
                            Role = Convert.ToInt32(reader["Role"]);
                            isAdmin = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    isAdmin = false;
                }

                return isAdmin;
            }
        }
        public static bool DeleteAdminByID(int AdminID) 
        {
            
            String query = "Delete from Admins Where AdminID =@AdminID";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@AdminID", AdminID);
                try
                {
                    con.Open();
                    int RowEffected = command.ExecuteNonQuery();
                    return RowEffected > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public static DataTable getAllAdminsInfo()
        {
            DataTable dt= new DataTable();
            string query = "SELECT * FROM Admins";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, con))
            {
               
                try
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }

                }
                catch (Exception ex)
                {
                    throw;
                }

                return dt;
            }
        }       
        public static bool AddAdmin(String UserName, String Password, string fullName, string createdDate,String PicturePath, int Role)
        {
            bool isAdminAdd = false;
            String Query = "INSERT INTO Admins (UserName, PassowrdHash, FullName, CreatedDate,PicturePath,Role) VALUES (@UserName, @Password, @FullName, @CreatedDate,@PicturePath , @Role)";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(Query, con))
            {
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@CreatedDate", createdDate);
                command.Parameters.AddWithValue("@PicturePath", PicturePath);
                command.Parameters.AddWithValue("@Role",Role);
                try
                {
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    isAdminAdd = rowsAffected > 0;
                    if (PicturePath == null)
                        PicturePath = "";
                }
                catch (Exception ex)
                {
                    isAdminAdd = false;
                }
                return isAdminAdd;
            }
        }
        public static bool EditAdmin(int AdminID,String FullName, String UserName, int Role ,String PicturePath)
        {
            bool isEdited = false;
            String query = "Update Admins set FullName=@FullName,UserName=@UserName,Role=@Role, PicturePath=@PicturePath where AdminID=@AdminID;";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@FullName", FullName);
                command.Parameters.AddWithValue("@UserName",UserName);
                command.Parameters.AddWithValue("@AdminID",AdminID);
                command.Parameters.AddWithValue("@PicturePath",string.IsNullOrWhiteSpace(PicturePath) ? (object)DBNull.Value : PicturePath);
                command.Parameters.AddWithValue("@Role",Role);
              try
                {
                    con.Open();
                    int affect = command.ExecuteNonQuery();
                    if (affect > 0)
                        isEdited = true;

                } 
                catch (Exception ex) 
                {
                    isEdited = false;
                    
                }

                
            }
                return isEdited;
        }

    }
}