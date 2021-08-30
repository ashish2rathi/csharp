using System;

namespace SwitchExpressions
{
    class TuplePattern
    {
        public static string ReturnWinner(string team1, string team2)
            => (team1, team2) switch
            {
                ("India", "Australia") => "Australia is covered by India. India wins.",
                ("Australia", "England") => "Australia breaks England. Australia wins.",
                ("India", "England") => "India covers England. India wins.",
                (_, _) => "tie"
            };

        public static string ReturnWinner(string team1, string team2, string team3)
            => (team1, team2, team3) switch
            {
                ("India", "Australia", "England") => "India first and England last",
                ("Australia", "England", "India") => "Australia first and India last",
                ("India", "England", "Australia") => "India first and Australia last",
                (_, _, _) => "tie"
            };
    }
}
