namespace InitOnlySetters
{
    public class Base
    {
        public bool Value { get; init; }
    }

    public class Derived : Base
    {
        public Derived()
        {
            // Not allowed with get only properties but allowed with init
            Value = true;
        }
    }

    class Consumption
    {
        void Example()
        {
            var d = new Derived() { Value = true };
        }
    }
}