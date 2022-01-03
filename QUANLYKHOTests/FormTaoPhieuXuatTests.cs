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
    public class FormTaoPhieuXuatTests
    {
        [TestMethod()]
        public void IsValidDecimalNumberTest()
        {
            bool expected;
            FormTaoPhieuXuat fr = new FormTaoPhieuXuat();
            expected = fr.IsValidDecimalNumber("123");

            Assert.AreEqual(true, expected);
        }

        [TestMethod()]
        public void kiemTraDauVaoXuatTest()
        {
            bool expected;
            FormTaoPhieuXuat fr = new FormTaoPhieuXuat();
            expected = fr.kiemTraDauVaoXuat("12344", "123");

            Assert.AreEqual(true, expected);
        }
    }
}