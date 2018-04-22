using System;

namespace isJoeyBirthday
{
    public class JoeyBirthirday
    {
        protected DateTime _dateTime;

        public JoeyBirthirday()
        {
            _dateTime = DateTime.Today;
        }

        public JoeyBirthirday(DateTime date)
        {
            _dateTime = date;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string isBirthday()
        {
            GetDate();

            if(_dateTime.ToString("MM/dd") == "11/28")
            {
                return "Happy Birthday";
            }
            return "No, Sorry";
        }

        protected virtual void GetDate()
        {
            _dateTime = DateTime.Today;
        }

    }
}