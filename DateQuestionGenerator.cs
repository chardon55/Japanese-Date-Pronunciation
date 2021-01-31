using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Japanese_Date_Pronunciation
{
    /// <summary>
    /// Date Generator
    /// </summary>
    public class DateQuestionGenerator
    {
        protected static Dictionary<string, string> months = new Dictionary<string, string>
        {
            {"１月", "いちがつ"},
            {"２月", "にがつ"},
            {"３月", "さんがつ"},
            {"４月", "しがつ"},
            {"５月", "ごがつ"},
            {"６月", "ろくがつ"},
            {"７月", "しちがつ"},
            {"８月", "はちがつ"},
            {"９月", "くがつ"},
            {"１０月", "じゅうがつ"},
            {"１１月", "じゅういちがつ"},
            {"１２月", "じゅうにがつ"},
        };

        protected static List<string> monthNames = new List<string>(months.Keys);

        protected static Dictionary<string, string> days = new Dictionary<string, string>
        {
            {"１日", "ついたち"},
            {"２日", "ふつか"},
            {"３日", "みっか"},
            {"４日", "よっか"},
            {"５日", "いつか"},
            {"６日", "むいか"},
            {"７日", "なのか"},
            {"８日", "ようか"},
            {"９日", "ここのか"},
            {"１０日", "とおか"},
            {"１１日", "じゅういちにち"},
            {"１２日", "じゅうににち"},
            {"１３日", "じゅうさんにち"},
            {"１４日", "じゅうよっか"},
            {"１５日", "じゅうごにち"},
            {"１６日", "じゅうろくにち"},
            {"１７日", "じゅうしちにち"},
            {"１８日", "じゅうはちにち"},
            {"１９日", "じゅうくにち"},
            {"２０日", "はつか"},
            {"２１日", "にじゅういちにち"},
            {"２２日", "にじゅうににち"},
            {"２３日", "にじゅうさんにち"},
            {"２４日", "にじゅうよっか"},
            {"２５日", "にじゅうごにち"},
            {"２６日", "にじゅうろくにち"},
            {"２７日", "にじゅうしちにち"},
            {"２８日", "にじゅうはちにち"},
            {"２９日", "にじゅうくにち"},
            {"３０日", "さんじゅうにち"},
            {"３１日", "さんじゅういちにち"},
        };

        protected ushort[] monthLimits = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };

        protected static List<string> dayNames = new List<string>(days.Keys);

        public DateQuestion Generate()
        {
            var monthIndex = new Random().Next(0, 11);

            var q = new DateQuestion
            {
                Month = monthNames[monthIndex],
                Day = dayNames[new Random().Next(0, monthLimits[monthIndex] - 1)]
            };

            q.TheAnswer = new DateQuestion.Answer
            {
                Month = months[q.Month],
                Day = days[q.Day]
            };

            return q;
        }
    }
}
