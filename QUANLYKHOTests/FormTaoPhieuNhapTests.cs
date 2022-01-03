using Microsoft.VisualStudio.TestTools.UnitTesting;
using QUANLYKHO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHO.Tests
{
    [TestClass()]
    public class FormTaoPhieuNhapTests
    {
        [TestMethod()]
        public void IsValidDecimalNumberTest()
        {
            bool expected;
            FormTaoPhieuNhap fr = new FormTaoPhieuNhap();
            expected = fr.IsValidDecimalNumber("123");

            Assert.AreEqual(true, expected);
        }

        [TestMethod()]
        public void kiemTraDauVaoTest()
        {
            bool expected;
            FormTaoPhieuNhap fr = new FormTaoPhieuNhap();
            expected = fr.kiemTraDauVao("12344", "123");

            Assert.AreEqual(true, expected);
        }
    
    }
}