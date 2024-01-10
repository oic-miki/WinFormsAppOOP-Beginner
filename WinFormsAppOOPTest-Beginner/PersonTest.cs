using System;

namespace WinFormsAppOOPTest_Beginner
{

    [TestClass]
    public class PersonTest
    {

        private Person person = new Person();

        [TestMethod]
        public void getNameTest()
        {

            Assert.IsNotNull(person.getName());

        }

        [TestMethod]
        public void setNameTest()
        {

            Assert.IsNotNull(person.setName("Name"));

        }

    }

}