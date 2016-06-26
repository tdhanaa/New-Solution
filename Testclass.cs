using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ClassLibrary1;

namespace ClassLibrary2.Test
{
    [TestFixture]
    public class Testclass
    {
        [Test]
        public void Magic()
        {
            MagicSquare obj = new MagicSquare();
            Boolean  expected = true;
            int[,] ip = new int[,]{ { 2, 7, 9}, { 9, 5, 1}, { 4, 3, 0 } };
            Boolean actual = obj.ChkMatrix(ip);
            Boolean test;

            if (expected==actual)
                        test = true;
            else
                test = false;
           // Assert.IsTrue(test);

            Assert.IsTrue(test, "Magic Square");
        }
    }
}
