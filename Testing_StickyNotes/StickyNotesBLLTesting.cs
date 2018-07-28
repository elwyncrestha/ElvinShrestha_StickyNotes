using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElvinShrestha_StickyNotes;
using System.Data;

namespace Testing_StickyNotes
{
    [TestClass]
    public class StickyNotesBLLTesting
    {
        StickyNotesBLL stickyNotesBLL = new StickyNotesBLL();

        [TestMethod]
        public void loadStickyOrCompletedorAll()
        {
            bool isSearch = false;
            String searchDate = "null";
            String noteTitle = "null";
            String isStickyOrCompletedorAll = "Sticky";
            int status = 1;

            stickyNotesBLL._username = "admin";
            DataTable dataTable = stickyNotesBLL.loadStickyOrCompletedorAll(isSearch, searchDate, 
                                    noteTitle, isStickyOrCompletedorAll,status);

            String expected = "Loaded";
            String actual = "Unloaded";

            if(dataTable.Rows.Count > 0)
            {
                actual = "Loaded";
            }

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addNote()
        {
            // expected count
            bool isSearch = false;
            String searchDate = "null";
            String searchTitle = "null";
            String isStickyOrCompletedorAll = "Sticky";
            int status = 1;
            int userId = 1;
            int expectedCount = stickyNotesBLL.countNotes(isSearch, searchDate,
                                    searchTitle, isStickyOrCompletedorAll, status, userId) + 1;

            // add note
            String noteTitle = "TestNoteTitle1";
            int noteCategory = 1;
            String noteContent = "TestNoteContent1";
            int stickyStatus = 1;
            stickyNotesBLL.addNote(noteTitle, noteCategory, noteContent, stickyStatus, userId);

            // actual count
            int actualCount = stickyNotesBLL.countNotes(isSearch, searchDate, 
                                searchTitle, isStickyOrCompletedorAll, status, userId);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void deleteNote()
        {
            // expected count
            bool isSearch = false;
            String searchDate = "null";
            String searchTitle = "null";
            String isStickyOrCompletedorAll = "All";
            int status = 1;
            int userId = 1;
            int expectedCount = stickyNotesBLL.countNotes(isSearch, searchDate, 
                                    searchTitle, isStickyOrCompletedorAll, status, userId) - 1;

            // delete note
            int noteId = 3;
            stickyNotesBLL._username = "admin";
            stickyNotesBLL.deleteNote(noteId);

            // actual count
            int actualCount = stickyNotesBLL.countNotes(isSearch, searchDate, 
                                searchTitle, isStickyOrCompletedorAll, status, userId);

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void updateNoteStickyStatus()
        {
            bool isSearch = false;
            String searchDate = "null";
            String searchTitle = "null";
            String isStickyOrCompletedorAll = "Sticky";
            int status = 1;
            int userId = 1;

            // before update
            int countStickyOld = stickyNotesBLL.countNotes(isSearch, searchDate, 
                                    searchTitle, isStickyOrCompletedorAll, status, userId);

            // after update
            int noteId = 1;
            bool isSticky = true;
            stickyNotesBLL.updateNoteStickyStatus(noteId, isSticky);
            int countStickyNew = stickyNotesBLL.countNotes(isSearch, searchDate, 
                                    searchTitle, isStickyOrCompletedorAll, status, userId);

            Assert.AreNotEqual(countStickyOld, countStickyNew);
        }
    }
}
