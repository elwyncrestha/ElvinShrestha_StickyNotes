using System;
using System.Data;

namespace ElvinShrestha_StickyNotes
{
    public class UserTypeBLL : DbConnection
    {
        public DataTable loadUserType()
        {
            String sql = "select userTypeId, userTypeName from UserType_tbl;";
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

        public DataTable loadUserType(int userTypeId)
        {
            String sql = "select userTypeId, userTypeName from UserType_tbl where userTypeId = " + userTypeId;
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dataTable;
        }

        public bool verifyUserType(String userTypeName)
        {
            String sql = "select * from UserType_tbl where userTypeName = '" + userTypeName + "';";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public int countUserType()
        {
            String sql = "select COUNT(userTypeId) from UserType_tbl;";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return Convert.ToInt16(dataTable.Rows[0][0].ToString());
        }

        public void insertUserType(String userTypeName)
        {
            String sql = "insert into UserType_tbl(userTypeName) values('" + userTypeName + "');";
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updateUserType(int userTypeId, String userTypeName)
        {
            String sql = "update UserType_tbl set userTypeName = '" + userTypeName + "' where userTypeId = " + userTypeId;
            try
            {
                dbManipulate(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void deleteUserType(int userTypeId)
        {
            String sql = "delete from UserType_tbl where userTypeId = " + userTypeId;
            try
            {
                dbManipulate(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
