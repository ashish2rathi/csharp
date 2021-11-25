namespace PatternMatching
{
    public class PatternCobinators
    {
        public static User TypeCheckingPattern(User user)
        {
            if (user is not null)
            {
                return user;
            }
            else
            {
                return new User();
            }
        }


        #region RelationalPatternInIfStatement
        //Older C#
        public static bool IsLetterCSharp8(char c)
        {
            return c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
        }

        //C# 9
        public static bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        //C# 9
        public static bool IsLetterWithParanthesis(char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

        #endregion RelationalPatternInIfStatement
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}