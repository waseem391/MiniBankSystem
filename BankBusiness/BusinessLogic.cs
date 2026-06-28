using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataBankSystem;
namespace BankBusiness
{
    public class BankBusinessLogic
    {
        enum enRole
        {
            Admin = 0,
            Leader = 1
        }
        public static bool IsUserNameTaken(int AdminID,String UserName) 
        {
            return DataAccess.CheckUserNameAvailable(AdminID,UserName);
        }

        public static AdminINFO TryTogetAdminInfo(String userName)
        {
            int AdminID = -1;
            String UserName = userName;
            String password = "";
            String fullName = "";
            String createdDate = "";
            String picturePath = "";
            int Role = 0;

            if (DataAccess.GetAdminInfoByUserName(ref AdminID, ref UserName, ref password, ref fullName, ref createdDate,ref picturePath,ref Role))
            {   if (picturePath == "")
                    picturePath = @"C:\Mini Bank System\Pic\account-icon-sign-symbol-logo-design-free-vector.jpg";
                return new AdminINFO(AdminID, UserName, password, fullName, createdDate, picturePath, Role);
            }
            return null;

        }
        public static AdminINFO FindAdminByID(int ID) 
        {
            int AdminID =ID;
            String UserName = "";
            String password = "";
            String fullName = "";
            String createdDate = "";
            String picturePath = "";
            int Role = 0;

            if (DataAccess.GetAdminInfoByID(ref AdminID, ref UserName, ref password, ref fullName, ref createdDate, ref picturePath, ref Role))
            {
                if (picturePath == "")
                    picturePath = @"C:\Mini Bank System\Pic\account-icon-sign-symbol-logo-design-free-vector.jpg";
                return new AdminINFO(AdminID, UserName, password, fullName, createdDate, picturePath, Role);
            }
            return null;
        }
        public static bool TryToLogin(String UserName, String Password)
        {
            AdminINFO admin = TryTogetAdminInfo(UserName);
            if (admin == null)
            {
                return false;
            }
            return admin.Password == Password;
        }
        public static bool TryToAddAdmin(String UserName, String Password, string fullName, string createdDate,String PicturePath,int Role)
        {
            
            if(TryTogetAdminInfo(UserName) != null)
            {
                return false;
            }
            if(String.IsNullOrEmpty(UserName)||UserName.Length<5 || UserName.Contains(" "))
            {
                return false;
            }
            if (String.IsNullOrEmpty(Password) || Password.Length < 5 || Password.Contains(" "))
            {
                return false;
            }
            if (String.IsNullOrEmpty(fullName))
                return false;

            return DataAccess.AddAdmin(UserName, Password, fullName, createdDate,PicturePath,Role);
        }
        public static bool DeleteAdmin(int AdminID) 
        {
            return DataAccess.DeleteAdminByID(AdminID);
        }
        public static bool HasFullPermissions(AdminINFO admin)
        {
            if ((enRole)admin.Role == enRole.Leader)
                return true;
            else
                return false;
        }
        public static DataTable GetAllAdmins() 
        {
            return DataAccess.getAllAdminsInfo();
        }
        public static bool EditAdminInfo(int AdminID,String FullName, String UserName,int Role, String PicturePath)
        {
            if (UserName.Length < 4 || UserName.Contains(" ") || String.IsNullOrWhiteSpace(UserName))
                return false;
            if (FullName.Length < 4 || FullName.StartsWith(" ") || String.IsNullOrWhiteSpace(FullName))
                return false;
            if (IsUserNameTaken(AdminID,UserName))
                return false;
           
            return DataAccess.EditAdmin(AdminID,FullName, UserName, Role ,PicturePath);
            
      
        }
    

    }  
    public class AdminINFO
        {
            public AdminINFO(String userName, String password)
            {
                this.AdminID = -1;
                this.UserName = userName;
                this.Password = password;
            }
            public AdminINFO()
            {
                this.Role = 0;
            }
            public AdminINFO(int adminID, String userName, String password, string fullName, String createdDate,String picturePath, int Role)
            {
                this.AdminID = adminID;
                this.UserName = userName;
                this.Password = password;
                this.FullName = fullName;
                this.createdDate = createdDate;
                this.picturePath = picturePath;
                this.Role = Role;
            }
            public int AdminID { get; set; }
            public String UserName { get; set; }
            public String Password { get; set; }
            public string FullName { get; set; }
            public String createdDate { get; set; }
            public String picturePath { get; set; }
            public int Role { get; set; }
        }
}
