namespace PatternMatching
{
    public class RelationalPatterns
    {
        public enum LifeStage
        {
            Prenatal,
            Infant,
            Toddler,
            EarlyChild,
            MiddleChild,
            Adolescent,
            EarlyAdult,
            MiddleAdult,
            LateAdult
        }

        //C# 9.0
        public static LifeStage LifeStageAtAge(int age) => age switch
        {
            < 0 => LifeStage.Prenatal,
            < 2 => LifeStage.Infant,
            < 4 => LifeStage.Toddler,
            < 6 => LifeStage.EarlyChild,
            < 12 => LifeStage.MiddleChild,
            < 20 => LifeStage.Adolescent,
            < 40 => LifeStage.EarlyAdult,
            < 65 => LifeStage.MiddleAdult,
            _ => LifeStage.LateAdult,
        };

        //C# 8.0
        public static LifeStage LifeStageAtAgeInCsharp8(int age)
        {
            return age switch
            {
                var a when a < 0 => LifeStage.Prenatal,
                var a when a < 2 => LifeStage.Infant,
                var a when a < 4 => LifeStage.Toddler,
                var a when a < 6 => LifeStage.EarlyChild,
                var a when a < 12 => LifeStage.MiddleChild,
                var a when a < 20 => LifeStage.Adolescent,
                var a when a < 40 => LifeStage.EarlyAdult,
                var a when a < 65 => LifeStage.MiddleAdult,
                _ => LifeStage.LateAdult,
            };
        }

        //C# 7.0
        public static LifeStage LifeStageAtAgeInCsharp7(int age)
        {
            if (age < 0)
            {
                return LifeStage.Prenatal;
            }
            else if (age < 2)
            {
                return LifeStage.Infant;
            }
            else if (age < 4)
            {
                return LifeStage.Toddler;
            }
            else if (age < 6)
            {
                return LifeStage.EarlyChild;
            }
            else if (age < 12)
            {
                return LifeStage.MiddleChild;
            }
            else if (age < 20)
            {
                return LifeStage.Adolescent;
            }
            else if (age < 40)
            {
                return LifeStage.EarlyAdult;
            }
            else if (age < 65)
            {
                return LifeStage.MiddleAdult;
            }
            else
            {
                return LifeStage.LateAdult;
            }
        }
    }
}