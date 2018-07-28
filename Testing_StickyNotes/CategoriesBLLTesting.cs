using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElvinShrestha_StickyNotes;

namespace Testing_StickyNotes
{
    [TestClass]
    public class CategoriesBLLTesting
    {
        CategoriesBLL categoriesBLL = new CategoriesBLL();

        [TestMethod]
        public void insertCategory()
        {
            String username = "admin";
            int expectedCount = categoriesBLL.countCategories(username) + 1;

            categoriesBLL.insertCategory("admin", "TestCategory1");
            int actualCount = categoriesBLL.countCategories(username);

            Assert.AreEqual(expectedCount, actualCount);
        }

    }
}
