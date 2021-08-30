//<Nullable>enable</Nullable>
//#nullable enable
using System;
using System.Reflection;



/// <summary>
/// This Example has below listed features in it
/// 1. Nullable Reference Types
/// 2. Null-Coalescing Assignment Operator
/// 3. Null Forgiving Operator
/// 4. Nullable Enable
/// </summary>
namespace NonNullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringExample();
            //MessageObjectExample();
            //MessageExampleWithNullCheck();
            //NullCoalescingOperatorExample();
            NullForgivingOperatorExample();
        }

        static void StringExample()
        {
            string? message = null;
            //string message = null;

            Console.WriteLine(message);
            Console.WriteLine("Press enter to end");
            Console.Read();
        }

        static void MessageObjectExample()
        {
            var message = new Message();
            Console.WriteLine(message.Text);
            Console.WriteLine(message.From);
            Console.WriteLine(message.ToUpperFrom);
            Console.WriteLine("Press enter to end");
            Console.Read();
        }

        static void MessageExampleWithNullCheck()
        {
            var message = new Message()
            {
                Text = "Hi buddy",
                From = null
            };
            Console.WriteLine(message.Text);
            Console.WriteLine(message.From);
            Console.WriteLine(message.ToUpperFrom);
            Console.WriteLine("Press enter to end");
            Console.Read();
        }

        static void NullCoalescingOperatorExample()
        {
            var message = new Message()
            {
                Text = "Hi buddy",
                From = null
            };
            Console.WriteLine(message.Text);
            Console.WriteLine(message.From ?? "Not Available");
            Console.WriteLine(message.ToUpperFrom);
            Console.WriteLine("Press enter to end");
            Console.Read();
        }

        static void NullForgivingOperatorExample()
        {
            Message message = new Message()
            {
                Text = "Hi buddy",
                From = null
            };
            var message2 = MessagePopulator.Populate(message);
            Console.WriteLine(message.Text);
            Console.WriteLine(message.From);
            
            //Uncomment both and see the difference
            var length1 = message2.From.Length; //Without forgiving operator gives warning
            //var length2 = message2.From!.Length; //With forgiving operator doesn't give warning
            
            //Console.WriteLine(message.From.Length);            
            Console.WriteLine(message.ToUpperFrom);
            Console.WriteLine("Press enter to end");
            Console.Read();
        }
    }

    class Message
    {
        public string? From { get; set; }
        public string Text { get; set; } = "";
        public string? ToUpperFrom => From?.ToUpper();

        //public string ToUpperFrom()
        //{
        //    if (From is null)
        //    {
        //        return "";
        //    }

        //    return From.ToUpper();
        //}

        //OR

        //public string? ToUpperFrom => From?.ToUpper();

    }

    static class MessagePopulator
    {
        public static Message Populate(Message message)
        {
            message.From = "Something";
            return message;
            //message.GetType().InvokeMember("From",
            //    BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
            //    Type.DefaultBinder, message, new[] {"Value set using reflection"});
        }
        
    }
}
