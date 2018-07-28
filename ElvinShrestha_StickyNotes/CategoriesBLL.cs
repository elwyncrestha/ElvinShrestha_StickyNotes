using System;
using System.Data;

namespace ElvinShrestha_StickyNotes
{
    public class CategoriesBLL : DbConnection
    {
        UserBLL userBLL = new UserBLL();
       
        public bool verifyCategory(String username, String categoryName)
        {
            int userId = userBLL.getUserId(username);
            String sql;
            sql = "select categoryId from Category_tbl where userId = " + userId + " and categoryName = '" + categoryName + "';";

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

        public void insertCategory(String username, String categoryName)
        {
            int userId = userBLL.getUserId(username);
            String sql = "insert into Category_tbl(categoryName,userId) values('" + categoryName + "'," + userId+ ");";
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public DataTable loadCategories(String username)
        {
            String sql = "select categoryId, categoryName from Category_tbl c, User_tbl u where c.userId = u.userId and " + 
                            "u.userUsername = '" + username + "' order by categoryName asc;";
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

        public DataTable loadCategories(int categoryId)
        {
            String sql = "select categoryId, categoryName from Category_tbl where categoryId = " + categoryId + " order by categoryName asc;";
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

        public void deleteCategory(int categoryId)
        {
            String sql = "delete from Category_tbl where categoryId = " + categoryId;
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updateCategory(int categoryId, String categoryName)
        {
            String sql = "update Category_tbl set categoryName = '" + categoryName + "' where categoryId = " + categoryId;
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int countCategories()
        {
            String sql = "select COUNT(categoryId) from Category_tbl where userId = " + userBLL.getUserId(FormLoaderClass._username);
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return Convert.ToInt16(dataTable.Rows[0][0].ToString());
        }

        public int countCategories(String username)
        {
            String sql = "select COUNT(categoryId) from Category_tbl where userId = " + userBLL.getUserId(username);
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return Convert.ToInt16(dataTable.Rows[0][0].ToString());
        }
    }
}