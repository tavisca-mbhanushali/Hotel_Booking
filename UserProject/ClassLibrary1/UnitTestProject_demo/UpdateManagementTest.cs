using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagementLibrary;
using UserManagementOperation;

namespace UnitTestProject_demo
{
    
    [TestClass]
    public class UpdateManagementTest
    {
        [TestMethod]
        public void TestUpdateUser()
        {
            User user = new User();
            user.Id = 210;
            user.FirstName = "Dennis";
            user.LastName = "Ritchi";
            user.EmailId = "dr@gmail.com";
            user.PhoneNumber = "7894351230";

            userUpdateOperation userUpdate = new userUpdateOperation();
            userUpdate.UpdateUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);

        }
    }
}
