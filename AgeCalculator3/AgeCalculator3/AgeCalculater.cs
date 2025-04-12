using System;

namespace AgeCalculator3
{
   public class AgeCalculater
    {
        private int bDay;
        private int bMonth;
        private int bYear;

        public AgeCalculater(int day, int month, int year)
        {
            bDay = day;
            bMonth = month;
            bYear = year;
        }

        public string CalculateAge()
        {
            int cDay = DateTime.Now.Day;
            int cMonth = DateTime.Now.Month;
            int cYear = DateTime.Now.Year;

            int aDay = cDay - bDay;
            int aMonth = cMonth - bMonth;
            int aYear = cYear - bYear;

            if (aDay < 0)
            {
                aMonth--;
                aDay += 30;
            }
            if (aMonth < 0)
            {
                aYear--;
                aMonth += 12;
            }

            return string.Format("Year: {0}, Month: {1}, Day: {2}", aYear, aMonth, aDay);
        }
    }
}
