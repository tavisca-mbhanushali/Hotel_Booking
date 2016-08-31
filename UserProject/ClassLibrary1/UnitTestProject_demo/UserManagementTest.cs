using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Linq;
//using LinqData;
using UserManagementLibrary;
using UserManagementOperation;

namespace UnitTestProject_demo
{
    [TestClass]
    public class UserManagementTest
    {
        [TestMethod]
        public void TestCreateUser()
        {
            User user = new User();
             user.Id = 1100;
             user.FirstName = "John";
             user.LastName = "Thomas";
             user.EmailId = "jt@gmail.com";
             user.PhoneNumber = "7894551230";
             

            UserOperationDB userOperationDB = new UserOperationDB();
            userOperationDB.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);
            
        }



        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateUserExceptionOnInvalidUserId()
        {
            User user = new User();
            user.Id = 425;
            user.FirstName = "Mohnish";
            user.LastName = "Behl";
            user.EmailId = "mp@gmail.com";
            user.PhoneNumber = "7964551233";
            
            UserOperationDB userOperationDB = new UserOperationDB();
            userOperationDB.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);
            

           // Assert.IsNotNull(new User());
           // Assert.IsTrue(new User().Id > 0);

        }

       

        }
    }

