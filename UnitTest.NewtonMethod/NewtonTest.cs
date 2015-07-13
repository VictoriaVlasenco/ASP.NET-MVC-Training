using System;
using ClassLibrary.Task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.NewtonMethod
{
    [TestClass]
    public class NewtonTest
    {
        [TestMethod]
        public void NewtonBase8_Degreee2()
        {
            double number = 8;
            int degree = 2;
            double newtonRes = Newton.GetRoot(number, degree);
            double root = 1.0/degree;
            double res = Math.Pow(number, root);
            Assert.AreEqual(newtonRes, res, 0.00001);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Newton_EvenBaseMinus8_Degreee2_ExpectedException()
        {
            double number = -8;
            int degree = 2;
            double newtonRes = Newton.GetRoot(number, degree);
        }

        [TestMethod]
        public void NewtonBase0dot8_DegreeeMinus2()
        {
            double number = 0.8;
            int degree = -2;
            double newtonRes = Newton.GetRoot(number, degree);
            double root = 1.0 / degree;
            double res = Math.Pow(number, root);
            Assert.AreEqual(newtonRes, res, 0.00001);
        }
        [TestMethod]
        public void NewtonBase0_Degreee0()
        {
            double number = 0;
            int degree = 0;
            double newtonRes = Newton.GetRoot(number, degree);
            double root = 1.0 / degree;
            double res = Math.Pow(number, root);
            Assert.AreEqual(newtonRes, res, 0.00001);
        }
    }
}
