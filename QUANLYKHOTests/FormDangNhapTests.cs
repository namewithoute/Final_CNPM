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
    public class FormDangNhapTests
    {
        [TestMethod()]
        public void kiemTraTaiKhoanTest()
        {
            FormDangNhap fdn = new FormDangNhap();
            bool dangnhap;
            dangnhap = fdn.kiemTraTaiKhoan("nvkho1", "123");

            Assert.AreEqual(true, dangnhap);
        }
    }
}