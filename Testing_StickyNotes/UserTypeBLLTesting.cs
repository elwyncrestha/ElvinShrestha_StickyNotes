using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElvinShrestha_StickyNotes;

namespace Testing_StickyNotes
{
    [TestClass]
    public class UserTypeBLLTesting
    {
        UserTypeBLL userTypeBLL = new UserTypeBLL();

        [TestMethod]
        public void verifyUserType()
        {
            bool expectedStatus = true;
            bool actualStatus = userTypeBLL.verifyUserType("User");

            Assert.AreEqual(expectedStatus, actualStatus);
        }

        [TestMethod]
        public void insertUserType()
        {
            int expectedCount = userTypeBLL.countUserType() + 1;

            userTypeBLL.insertUserType("UserTypeTestInsert3");
            int actualCount = userTypeBLL.countUserType();

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void deleteUserType()
        {
            int expectedCount = userTypeBLL.countUserType() - 1;

            userTypeBLL.deleteUserType(2);
            int actualCount = userTypeBLL.countUserType();

            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
