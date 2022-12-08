using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UserManagerTest
{
    [TestClass]
    public class UserManagerTest
    {
        public TestContext TestContext { get; set; }

        private UserManager manager = new UserManager();


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "User.xml",
            "User",
            DataAccessMethod.Sequential)]


        [TestMethod]
        public void User_Add_FromXML()
        {
            string userName = Convert.ToString(TestContext.DataRow["userid"]);
            string telephone = Convert.ToString(TestContext.DataRow["telephone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);

            bool result = manager.Add(userName, telephone, email);

            Assert.IsTrue(result, "Неверный пользователь!");
        }
    }
}
