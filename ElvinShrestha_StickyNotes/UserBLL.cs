using System;
using System.Data;

namespace ElvinShrestha_StickyNotes
{
    public class UserBLL : DbConnection
    {
        // Field initialization
        private String firstName;
        private String lastName;
        private String dob;
        private String address;
        private String email;
        private String contactNumber;
        private String username;
        private String password;

        // Constructor
        public UserBLL() { }

        // Getter and setter
        public string _firstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string _lastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string _dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string _address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string _email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string _contactNumber
        {
            get
            {
                return contactNumber;
            }

            set
            {
                contactNumber = value;
            }
        }

        public string _username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string _password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        // Methods
        public void addBasicUserTypes()
        {
            bool userTypeStatus = false;
            String sql;
            sql = "select userTypeId from UserType_tbl where userTypeName = 'Admin';";
            DataTable dataTable = dbRetrieve(sql);

            if (dataTable.Rows.Count > 0)
            {
                dataTable = null;
                sql = "select userTypeId from UserType_tbl where userTypeName = 'User';";
                try
                {
                    dataTable = dbRetrieve(sql);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (dataTable.Rows.Count > 0)
                {
                    userTypeStatus = true;
                }
            }

            if (userTypeStatus == false)
            {
                sql = "insert into UserType_tbl(userTypeName) values('Admin'),('User');";
                try
                {
                    dbManipulate(sql);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void addAdmin()
        {
            String sql;
            bool adminStatus = false;

            sql = "select userId from User_tbl where userUsername = 'admin'";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dataTable.Rows.Count > 0)
            {
                adminStatus = true;
            }

            if (adminStatus == false)
            {
                sql = "select userTypeId from UserType_tbl where userTypeName = 'Admin';";
                try
                {
                    dataTable = dbRetrieve(sql);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                int userTypeId = int.Parse(dataTable.Rows[0][0].ToString());

                sql = "insert into User_tbl(userFName, userUsername, userPassword, userTypeId, userActivationStatus) " +
                        "values('Administration','admin','admin'," + userTypeId + ", 1);";
                try
                {
                    dbManipulate(sql);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public int validateUserLogin()
        {
            // return values:
            // 0 for invalid
            // 1 for valid
            // 2 for inactive

            int userStatus = 0;
            String sql = "select userId from User_tbl where userUsername = '" + username + "' and userPassword = '" + password + "';";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dataTable.Rows.Count > 0)
            {
                dataTable = null;
                sql = "select userId from User_tbl where userUsername = '" + username + "' and userPassword = '" + password + "'" +
                     " and userActivationStatus = 1;";
                try
                {
                    dataTable = dbRetrieve(sql);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (dataTable.Rows.Count > 0)
                {
                    userStatus = 1;
                }
                else
                {
                    userStatus = 2;
                }
            }

            return userStatus;
        }

        public bool isUsernameAvailable(String username)
        {
            String sql = "select userId from User_tbl where userUsername = '" + username + "';";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dataTable.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        public void insertUser()
        {
            String sql = "select userTypeId from UserType_tbl where userTypeName = 'User';";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int userTypeId = int.Parse(dataTable.Rows[0][0].ToString());

            sql = "insert into User_tbl(userFName, userLName, userDOB, userAddress, userContact, userEmail, userUsername," +
                    " userPassword, userTypeId, userActivationStatus)" +
                    "values('" + firstName + "','" + lastName + "','" + dob + "','" + address + "','" + contactNumber + "','" + email + "'," +
                    "'" + username + "','" + password + "'," + userTypeId + ",0)";
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool validateUser(String username, String email, String contactNumber)
        {
            bool userStatus = false;

            String sql = "select userId from User_tbl where userUsername = '" + username + "' and userEmail = '" + email + "'" + 
                            " and userContact = '" + contactNumber + "';";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dataTable.Rows.Count > 0)
            {
                userStatus = true;
            }

            return userStatus;
        }

        public void resetUserPassword(String username, String email, String contactNumber, String newPassword)
        {
            String sql = "update User_tbl set userPassword = '" + newPassword + "' where userUsername = '" + username + "'" + 
                        " and userEmail = '" + email + "' and userContact = '" + contactNumber + "';";
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void resetUserPassword(String username, String newPassword)
        {
            String sql = "update User_tbl set userPassword = '" + newPassword + "' where userUsername = '" + username + "';";
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public DataTable getUserDetails(String username)
        {
            String sql = "select u.userFName, u.userLName, ut.userTypeName from User_tbl u, UserType_tbl ut where " + 
                            "u.userTypeId = ut.userTypeId and u.userUsername = '" + username + "'";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dataTable;
        }

        public int getUserId(String username)
        {
            String sql = "select userId from User_tbl where userUsername = '" + username + "';";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return int.Parse(dataTable.Rows[0][0].ToString());
        }

        public String getUserUsername(int userId)
        {
            String sql = "select userUsername from User_tbl where userId=" + userId;
            DataTable dataTable = dbRetrieve(sql);
            String username = dataTable.Rows[0][0].ToString();
            return username;
        }

        public bool isAdmin(String username)
        {
            bool status = false;

            String sql = "select u.userId from User_tbl u, UserType_tbl ut where u.userTypeId = ut.userTypeId and " + 
                            "ut.userTypeName = 'Admin' and u.userUsername = '" + username + "';";
            int count = 0;
            try
            {
                count = dbRetrieve(sql).Rows.Count;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if(count > 0)
            {
                status = true;
            }

            return status;
        }

        public DataTable loadUsers(String username)
        {
            String sql = "select u.userId, u.userFName, u.userLName, u.userDOB, u.userAddress, u.userContact, u.userEmail, " + 
                            "u.userUsername, ut.userTypeName, u.userActivationStatus from User_tbl u, UserType_tbl ut where " + 
                            "u.userTypeId = ut.userTypeId and u.userUsername = '" + username + "';";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dbRetrieve(sql);
        }

        public DataTable loadAllUsers()
        {
            String sql = "select u.userId, u.userFName, u.userLName, u.userDOB, u.userAddress, u.userContact, u.userEmail, " + 
                            "u.userUsername, ut.userTypeName, u.userActivationStatus from User_tbl u, UserType_tbl ut where " + 
                            "u.userTypeId = ut.userTypeId;";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dbRetrieve(sql);
        }

        public DataTable loadUserForAdmin(int userId)
        {
            String sql = "select userFName + ' ' + userLName, userTypeId, userActivationStatus from User_tbl where userId =" + userId;
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return dbRetrieve(sql);
        }

        public void updateUser(int userId)
        {
            String sql = "update User_tbl set userFName = '" + firstName + "', userLName = '" + lastName + "', userDOB = '" + dob + "'," + 
                            " userAddress = '" + address + "', userContact = '" + contactNumber + "', userEmail = '" + email + "'," + 
                            " userUsername = '" + username + "' where userId = " + userId;
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updateByAdmin(int userTypeId, int activationStatus, int userId)
        {
            String sql = "update User_tbl set userTypeId = " + userTypeId + ", userActivationStatus = " + activationStatus + " where " + 
                            "userId = " + userId;
            try
            {
                dbManipulate(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void deleteUser(int userId)
        {
            // two queries since two on delete cascade in same table is prohibited in database
            String sql = "delete from StickyNote_tbl where userId = " + userId;
            String sql1 = "delete from User_tbl where userId = " + userId;
            try
            {
                dbManipulate(sql);
                dbManipulate(sql1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
