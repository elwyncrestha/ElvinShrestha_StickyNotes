using System;
using System.Data;

namespace ElvinShrestha_StickyNotes
{
    public class StickyNotesBLL : DbConnection
    {

        private String username;
        
        public String _username
        {
            get { return username; }
            set { this.username = value; }
        }

        private int getUserId() {
            UserBLL userBLL = new UserBLL();
            return userBLL.getUserId(username);
        }

        public DataTable loadStickyOrCompletedorAll(bool isSearch, String searchDate, String noteTitle, String isStickyOrCompletedorAll, int status)
        {
            // if isSearch == false then searchDate and noteTitle are useless
            // options: Sticky, Completed, All

            String sql = null;

            if (isSearch)
            {
                if (searchDate != "null" && noteTitle == "null")
                {
                    if (isStickyOrCompletedorAll == "Sticky")
                    {
                        // for stickied - main interface
                        // 0 for non-sticky notes
                        // 1 for sticky-notes
                        sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus," + 
                                " c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteStickyStatus = " + status + " and s.noteDate = '" + searchDate + "'" + 
                                " order by noteCompletionStatus asc, noteDate asc";
                    }
                    else if (isStickyOrCompletedorAll == "Completed")
                    {
                        // 0 for incomplete notes
                        // 1 for complete notes
                        sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus," + 
                                " c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteCompletionStatus = " + status + " and s.noteDate = '" + searchDate + "'" +
                                "order by noteDate asc";
                    }
                    else if (isStickyOrCompletedorAll == "All")
                    {
                        sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus," + 
                                " c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteDate = '" + searchDate + "' order by noteDate asc";
                    }
                }
                else if(searchDate == "null" && noteTitle != "null")
                {
                    if (isStickyOrCompletedorAll == "Sticky")
                    {
                        // for stickied - main interface
                        // 0 for non-sticky notes
                        // 1 for sticky-notes
                        sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus, " + 
                                "c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteStickyStatus = " + status + " and " + 
                                "s.noteTitle like '" + noteTitle + "' order by noteCompletionStatus asc, noteDate asc";
                    }
                    else if (isStickyOrCompletedorAll == "Completed")
                    {
                        // 0 for incomplete notes
                        // 1 for complete notes
                        sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus, " + 
                                "c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteCompletionStatus = " + status + " and " + 
                                "s.noteTitle like '" + noteTitle + "' order by noteDate asc";
                    }
                    else if (isStickyOrCompletedorAll == "All")
                    {
                        sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus, " + 
                                "c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteTitle like '" + noteTitle + "' order by noteDate asc";
                    }
                }
            }
            else
            {
                if (isStickyOrCompletedorAll == "Sticky")
                {
                    // for stickied - main interface
                    // 0 for non-sticky notes
                    // 1 for sticky-notes
                    sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus, " + 
                            "c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId() + " and s.noteStickyStatus = " + status + " order by noteCompletionStatus asc, noteDate asc";
                }
                else if (isStickyOrCompletedorAll == "Completed")
                {
                    // 0 for incomplete notes
                    // 1 for complete notes
                    sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus, " + 
                            "c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId() + " and s.noteCompletionStatus = " + status + " order by noteDate asc";
                }
                else if (isStickyOrCompletedorAll == "All")
                {
                    sql = "select s.noteId, s.noteDate, s.noteTitle, s.noteContent, s.noteCompletionStatus, s.noteStickyStatus, " + 
                            "c.categoryName from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId() + " order by noteDate asc";
                }
            }

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

        public int countNotes(bool isSearch, String searchDate, String searchTitle, String isStickyOrCompletedorAll, int status)
        {
            // if isSearch == false, then searchDate is useless

            String sql = null;

            if (isSearch)
            {
                if (searchDate != "null" && searchTitle == "null")
                {
                    if (isStickyOrCompletedorAll == "Sticky")
                    {
                        // for stickied - main interface
                        // 0 for non-sticky notes
                        // 1 for sticky-notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteStickyStatus = " + status + " and s.noteDate = '" + searchDate + "';";
                    }
                    else if (isStickyOrCompletedorAll == "Completed")
                    {
                        // 0 for incomplete notes
                        // 1 for complete notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteCompletionStatus = " + status + " and s.noteDate = '" + searchDate + "';";
                    }
                    else if (isStickyOrCompletedorAll == "All")
                    {
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteDate = '" + searchDate + "';";
                    }
                }
                else if(searchDate == "null" && searchTitle != "null")
                {
                    if (isStickyOrCompletedorAll == "Sticky")
                    {
                        // for stickied - main interface
                        // 0 for non-sticky notes
                        // 1 for sticky-notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId() + " and s.noteStickyStatus = " + status + " and s.noteTitle like '" + searchTitle + "';";
                    }
                    else if (isStickyOrCompletedorAll == "Completed")
                    {
                        // 0 for incomplete notes
                        // 1 for complete notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId() + " and s.noteCompletionStatus = " + status + " and s.noteTitle like '" + searchTitle + "';";
                    }
                    else if (isStickyOrCompletedorAll == "All")
                    {
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + getUserId() + " and s.noteTitle like '" + searchTitle + "';";
                    }
                }
            }
            else
            {
                if (isStickyOrCompletedorAll == "Sticky")
                {
                    // for stickied - main interface
                    // 0 for non-sticky notes
                    // 1 for sticky-notes
                    sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId() + " and s.noteStickyStatus = " + status;
                }
                else if (isStickyOrCompletedorAll == "Completed")
                {
                    // 0 for incomplete notes
                    // 1 for complete notes
                    sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId() + " and s.noteCompletionStatus = " + status;
                }
                else if (isStickyOrCompletedorAll == "All")
                {
                    sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + getUserId();
                }
            }

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

        public int countStickyNotes(int status)
        {
            DataTable dataTable = null;
            String sql = "select COUNT(noteId) from StickyNotes_tbl where noteStickyStatus = " + status + " and userId = " + getUserId();

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
         
        public int countNotes(bool isSearch, String searchDate, String searchTitle, String isStickyOrCompletedorAll, int status, int userId)
        {
            // if isSearch == null, then searchDate is useless

            String sql = null;

            if (isSearch)
            {
                if (searchDate != "null" && searchTitle == "null")
                {
                    if (isStickyOrCompletedorAll == "Sticky")
                    {
                        // for stickied - main interface
                        // 0 for non-sticky notes
                        // 1 for sticky-notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + userId + " and s.noteStickyStatus = " + status + " and s.noteDate = '" + searchDate + "';";
                    }
                    else if (isStickyOrCompletedorAll == "Completed")
                    {
                        // 0 for incomplete notes
                        // 1 for complete notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + userId + " and s.noteCompletionStatus = " + status + " and s.noteDate = '" + searchDate + "';";
                    }
                    else if (isStickyOrCompletedorAll == "All")
                    {
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + userId + " and s.noteDate = '" + searchDate + "';";
                    }
                }
                else if (searchDate == "null" && searchTitle != "null")
                {
                    if (isStickyOrCompletedorAll == "Sticky")
                    {
                        // for stickied - main interface
                        // 0 for non-sticky notes
                        // 1 for sticky-notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + userId + " and s.noteStickyStatus = " + status + " and s.noteTitle like '" + searchTitle + "';";
                    }
                    else if (isStickyOrCompletedorAll == "Completed")
                    {
                        // 0 for incomplete notes
                        // 1 for complete notes
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + userId + " and s.noteCompletionStatus = " + status + " and s.noteTitle like '" + searchTitle + "';";
                    }
                    else if (isStickyOrCompletedorAll == "All")
                    {
                        sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                                "s.userId = " + userId + " and s.noteTitle like '" + searchTitle + "';";
                    }
                }
            }
            else
            {
                if (isStickyOrCompletedorAll == "Sticky")
                {
                    // for stickied - main interface
                    // 0 for non-sticky notes
                    // 1 for sticky-notes
                    sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + userId + " and s.noteStickyStatus = " + status;
                }
                else if (isStickyOrCompletedorAll == "Completed")
                {
                    // 0 for incomplete notes
                    // 1 for complete notes
                    sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + userId + " and s.noteCompletionStatus = " + status;
                }
                else if (isStickyOrCompletedorAll == "All")
                {
                    sql = "select COUNT(s.noteId) from StickyNote_tbl s, Category_tbl c where s.categoryId = c.categoryId and " + 
                            "s.userId = " + userId;
                }
            }

            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return int.Parse(dataTable.Rows[0][0].ToString());
        }

        public void addNote(String noteTitle, int noteCategory, String noteContent, int stickyStatus, int userId)
        {
            String sql = "insert into StickyNote_tbl(noteDate,noteTitle,noteContent,noteCompletionStatus,noteStickyStatus,userId,categoryId)"
                        + "values ('" + DateTime.Now + "','" + noteTitle + "','" + noteContent + "',0," + stickyStatus + "," + userId + "," + 
                            noteCategory + ");";

            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int countTodayNotes(String isCompletedOrIncompleteOrAll, String todayDate)
        {
            String sql = null;
            if (isCompletedOrIncompleteOrAll == "Completed")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate = '" + todayDate + "' and noteCompletionStatus = 1 and " + 
                        "userId = " + getUserId();
            }
            else if (isCompletedOrIncompleteOrAll == "Incomplete")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate = '" + todayDate + "' and noteCompletionStatus = 0 and " + 
                        "userId = " + getUserId();
            }
            else if(isCompletedOrIncompleteOrAll == "All")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate = '" + todayDate + "' and userId = " + getUserId();
            }

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

        public int countWeekNotes(String isCompletedOrIncompleteOrAll, String startDate, String endDate)
        {
            String sql = null;
            if (isCompletedOrIncompleteOrAll == "Completed")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "noteCompletionStatus = 1 and userId = " + getUserId();
            }
            else if (isCompletedOrIncompleteOrAll == "Incomplete")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "noteCompletionStatus = 0 and userId = " + getUserId();
            }
            else if (isCompletedOrIncompleteOrAll == "All")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "userId = " + getUserId();
            }

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

        public int countMonthNotes(String isCompletedOrIncompleteOrAll, String startDate, String endDate)
        {
            String sql = null;
            if (isCompletedOrIncompleteOrAll == "Completed")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "noteCompletionStatus = 1 and userId = " + getUserId();
            }
            else if (isCompletedOrIncompleteOrAll == "Incomplete")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "noteCompletionStatus = 0 and userId = " + getUserId();
            }
            else if (isCompletedOrIncompleteOrAll == "All")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "userId = " + getUserId();
            }

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

        public int countYearNotes(String isCompletedOrIncompleteOrAll, String startDate, String endDate)
        {
            String sql = null;
            if (isCompletedOrIncompleteOrAll == "Completed")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "noteCompletionStatus = 1 and userId = " + getUserId();
            }
            else if (isCompletedOrIncompleteOrAll == "Incomplete")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "noteCompletionStatus = 0 and userId = " + getUserId();
            }
            else if (isCompletedOrIncompleteOrAll == "All")
            {
                sql = "select COUNT(noteId) from StickyNote_tbl where noteDate between '" + startDate + "' and '" + endDate + "' and " + 
                        "userId = " + getUserId();
            }

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

        public void deleteNote(int noteId)
        {
            String sql = "delete from StickyNote_tbl where noteId = " + noteId + " and userId = " + getUserId();
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void updateNoteStickyStatus(int noteId, bool isSticky)
        {
            int noteStickyStatus = 1;

            if(!isSticky)
            {
                noteStickyStatus = 0;
            }

            String sql = "update StickyNote_tbl set noteStickyStatus = " + noteStickyStatus + " where noteId = " + noteId;
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void updateNoteCompletionStatus(int noteId, bool isCompleted)
        {
            int noteStickyStatus = 1;

            if (!isCompleted)
            {
                noteStickyStatus = 0;
            }

            String sql = "update StickyNote_tbl set noteCompletionStatus = " + noteStickyStatus + " where noteId = " + noteId;
            try
            {
                dbManipulate(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool verifyNoteByDate(String date)
        {
            String sql = "select noteId from StickyNote_tbl where userId = " + getUserId() + " and CONVERT(date,noteDate) = '" + date + "'";
            DataTable dataTable = null;
            try
            {
                dataTable = dbRetrieve(sql);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if(dataTable.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool verifyNoteByTitle(String title)
        {
            String sql = "select noteId from StickyNote_tbl where userId = " + getUserId() + " and noteTitle like '" + title + "'";
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

        public void updateNote(int noteId, String noteTitle, String noteContent, int categoryId)
        {
            String sql = "update StickyNote_tbl set noteTitle = '" + noteTitle + "', noteContent = '" + noteContent + "'," + 
                        " categoryId = " + categoryId + " where noteId = " + noteId;
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
}
