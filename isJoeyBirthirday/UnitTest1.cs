using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace isJoeyBirthday
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsJoeyBirtdayShouldBeReturnHannpyBirthday()
        {
            //arrang
            var date = new DateTime(2018, 11, 28);
            var jeoyBirtday = new FakeJoey();
            jeoyBirtday.setDate(date);
            //act
            var result = jeoyBirtday.isBirthday();
            //assert
            Assert.AreEqual("Happy Birthday", result);
        }

        [TestMethod]
        public void NotIsJoeyBirtdayShouldBeReturnHannpyBirthday()
        {
            //arrang
            var date = new DateTime(2018, 11, 27);
            var jeoyBirtday = new JoeyBirthirday(date);
            //act
            var result = jeoyBirtday.isBirthday();
            //assert
            Assert.AreEqual("No, Sorry", result);
        }
    }

    public class FakeJoey : JoeyBirthirday
    {
        private DateTime _date;

        internal void setDate(DateTime date)
        {
            _date = date;
        }

        protected override void GetDate()
        {
            _dateTime = _date;
        }
    }
}