using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagementLibrary;
using UserManagementOperation;

namespace UnitTestProject_demo
{

    [TestClass]
    public class DeleteManagementTest
    {
        [TestMethod]
        public void TestUpdateUser()
        {
            User user = new User();
            user.Id = 110;
           

            userDeleteOperation userDelete = new userDeleteOperation();
            userDelete.DeleteUser(user.Id);

        }
    }
}
