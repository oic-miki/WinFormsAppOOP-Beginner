using System;

namespace WinFormsAppOOP
{

    [TestClass]
    public class PersonTest
    {

        private Person person = new PersonModel();

        [TestMethod]
        public void getNameTest()
        {

            Assert.IsNotNull(person.getName());

        }

        [TestMethod]
        public void setNameTest()
        {

            Assert.IsTrue(person.setName("Name") is Person);
            Assert.AreEqual("Name", person.getName());

        }

    }

}