using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PasswordTest
    {
        [TestMethod]
        public void PasswordValidation_password_0()
        {
            var ending = 1;
            var password = "6524138765";
            PracticeTestFir.Password pswrd = new PracticeTestFir.Password();
            var sec = pswrd.PasswordValidation(password);
            Assert.AreEqual(ending, sec);
        }


        [TestMethod]
        public void PasswordValidation_password_1()
        {
            var ending = 1;
            var password = "6524138765";
            PracticeTestFir.Password pswrd = new PracticeTestFir.Password();
            var sec = pswrd.PasswordValidation(password);
            Assert.AreEqual(ending, sec);
        }  
        
        [TestMethod]
        public void PasswordValidation_password_2()
        {
            var ending = 2;
            var password = "819743627649785686928374";
            PracticeTestFir.Password pswrd = new PracticeTestFir.Password();
            var sec = pswrd.PasswordValidation(password);
            Assert.AreEqual(ending, sec);
        }
        
        [TestMethod]
        public void PasswordValidation_password_3()
        {
            var ending = 3;
            var password = "736483g7836482764";
            PracticeTestFir.Password pswrd = new PracticeTestFir.Password();
            var sec = pswrd.PasswordValidation(password);
            Assert.AreEqual(ending, sec);
        } 


        [TestMethod]
        public void PasswordValidation_password_4()
        {
            var ending = 4;
            var password = "DJHSDJSLKJDSLKHJh!";
            PracticeTestFir.Password pswrd = new PracticeTestFir.Password();
            var sec = pswrd.PasswordValidation(password);
            Assert.AreEqual(ending, sec);
        } 


        [TestMethod]
        public void PasswordValidation_password_5()
        {
            var ending = 5;
            var password = "6238736248fG!72398";
            PracticeTestFir.Password pswrd = new PracticeTestFir.Password();
            var sec = pswrd.PasswordValidation(password);
            Assert.AreEqual(ending, sec);
        }
    }
}
