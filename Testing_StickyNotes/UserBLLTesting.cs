using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElvinShrestha_StickyNotes;

namespace Testing_StickyNotes
{
    [TestClass]
    public class UserBLLTesting
    {
        UserBLL userBLL = new UserBLL();

        [TestMethod]
        public void validateUserLogin()
        {
            userBLL._username = "admin";
            userBLL._password = "admin";
            int remark = userBLL.validateUserLogin();
            // return values:
            // 0 for invalid
            // 1 for valid
            // 2 for inactive

            int valid = 1;

            Assert.AreEqual(valid, remark);
        }

        [TestMethod]
        public void resetUserPassword()
        {
            String username = "admin";
            String newPassword = "admin";
            String actualResult = "PasswordNotChanged";
            String expectedResult = "PasswordChanged";

            userBLL.resetUserPassword(username, newPassword);
            userBLL._username = username;
            userBLL._password = newPassword;
            int userIsActive = userBLL.validateUserLogin();

            if(userIsActive == 1)
            {
                actualResult = "PasswordChanged";
            }

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void getUserId()
        {
            String expectedUsername = "admin";
            int userId = userBLL.getUserId(expectedUsername);

            String actualUsername = userBLL.getUserUsername(userId);

            Assert.AreEqual(expectedUsername, actualUsername);
        }
    }
}
