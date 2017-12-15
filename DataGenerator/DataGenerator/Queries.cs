using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class Queries
    {

        public void CreateFact(int productId, double price, int quantity, DateTime date)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Connector con = new Connector();

            int day = ((int)date.DayOfWeek == 0) ? 7 : (int)date.DayOfWeek;
            int dayOfWeekIndex = 0;
            con.SelectOneIntRecordRow("weekday_id", "Weekday", "weekday_number = " + day.ToString(), ref dayOfWeekIndex);

            int month = date.Month;
            int monthIndex = 0;
            con.SelectOneIntRecordRow("month_id", "Month", "month_number = " + month.ToString(), ref monthIndex);

            int year = date.Year;
            int yearIndex = 0;
            con.SelectOneIntRecordRow("year_id", "Year", "year_number = " + year.ToString(), ref yearIndex);

            Convert.ToDateTime(date.ToString("u"));
            con.InsertInto("Time", "'" + date.ToString("u") + "'", monthIndex.ToString(), yearIndex.ToString(), dayOfWeekIndex.ToString());

            int dateIndex = con.GetScopeIndentity("Time");
            int storeIndex = Common.GetRandInt(1, 6);
            int employeeIndex = Common.GetEmployeeIndex(storeIndex);
            double expiryDays = (int)(Common.GetRandInt(0, 100) * Common.GetRandDouble());

            con.InsertInto("FactSales",
                productId.ToString(),
                dateIndex.ToString(),
                storeIndex.ToString(),
                ((float)expiryDays).ToString(),
                employeeIndex.ToString(),
                  price.ToString(),
                 quantity.ToString());

        }
    }
}
