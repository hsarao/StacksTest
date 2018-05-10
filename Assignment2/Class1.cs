using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment2
{
    /// </summary>
    [TestFixture]
    public class Class1
    {
        #region Constructor Tests
        /// <summary>
        /// Test the parameter constructor to ensure the values are being set properly in the created instance.
        /// </summary>
        [Test]
        public void Point_Constructor_Test()
        {
            int row = 3;
            int column = 2;
            Point point = new Point(row, column);

            Assert.That(point, Is.Not.Null);
            Assert.That(point.Column, Is.EqualTo(column));
            Assert.That(point.Row, Is.EqualTo(row));
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void ToString_Test()
        {
            int row = 3;
            int column = 2;
            Point point = new Assignment2.Point(row, column);

            string expectedString = $"[{row}, {column}]";
            Assert.That(point.ToString, Is.EqualTo(expectedString));
        }
        #endregion
    }
}
