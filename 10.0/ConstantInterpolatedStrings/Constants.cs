namespace ConstantInterpolatedStrings
{
    public static class Chsarp9Constants
    {
        //Allowed
        public const string S1 = "Hello world";
        public const string S2 = "Hello" + " " + "World";
        public const string S3 = S1 + " Kevin, welcome to the team!";

        //Error
        //const string S1 = $"Hello world";
        //const string S2 = $"Hello{" "}World";
        //const string S3 = $"{S1} Kevin, welcome to the team!";
    }

    public static class CSharp10Constants
    {
        //Allowed both above implementations
        public const string S1 = $"Hello world";
        public const string S2 = $"Hello{" "}World";
        public const string S3 = $"{S1} Kevin, welcome to the team!";
    }
}
