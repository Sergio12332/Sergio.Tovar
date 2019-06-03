using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
namespace Repositorio.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=login; Uid=root;");
            var user = "Admin";
            var pass = "12345";
            bool corre = user == "select nombre from login.usuario" && pass == "select password from login.usuario";
        }
    }
}
