using System;
using System.Drawing;

namespace SwitchExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PropertyPattern1

            //PropertyPattern.CalculateTaxBasedOnState("MH");
            //PropertyPattern.CalculateTaxBasedOnState("BIHAR");
            //PropertyPattern.CalculateTaxBasedOnState("RAJASTHAN");
            //PropertyPattern.CalculateTaxBasedOnState("KASHMIR");
            //Console.Read();

            #endregion

            #region PropertyPattern2
            //PropertyPattern.CalculateTaxBasedOnStateAndCity(new Address { City = "PUNE", State = "MH" });
            //PropertyPattern.CalculateTaxBasedOnStateAndCity(new Address { City = "MUMBAI", State = "MH" });
            //PropertyPattern.CalculateTaxBasedOnStateAndCity(new Address { City = "AURANGABAD", State = "BIHAR" });
            //PropertyPattern.CalculateTaxBasedOnStateAndCity(new Address { City = "NAGPUR", State = "MH" });
            //Console.Read();

            #endregion

            #region TuplePattern1

            //var counties = ("India", "Australia", "England");
            //var india = counties.Item1;
            //var australia = counties.Item2;
            //var england = counties.Item3;
            //Console.WriteLine($"Result of the match between {india} and {australia} is: {TuplePattern.ReturnWinner(india, australia)}");
            //Console.WriteLine($"Result of the match between {australia} and {england} is: {TuplePattern.ReturnWinner(australia, england)}");
            //Console.WriteLine($"Result of the match between {india} and {england} is: {TuplePattern.ReturnWinner(india, england)}");
            //Console.WriteLine($"Result of the match between {england} and {australia} is: {TuplePattern.ReturnWinner(england, australia)}");
            //Console.Read();

            #endregion

            #region TuplePattern2

            //Console.WriteLine($"Result of the match between {india} and {australia} and {england} is: {TuplePattern.ReturnWinner(india, australia, england)}");
            //Console.WriteLine($"Result of the match between {australia} and {england} and {india} is: {TuplePattern.ReturnWinner(australia, england, india)}");
            //Console.WriteLine($"Result of the match between {india} and {england} and {australia} is: {TuplePattern.ReturnWinner(india, england, australia)}");
            //Console.WriteLine($"Result of the match between {england} and {australia} and {india} is: {TuplePattern.ReturnWinner(england, australia, india)}");
            //Console.Read();

            #endregion

            #region SwitchExample
            //SwitchExample.IsCheckClearedSwitchBlock(cheque);
            var message = SwitchExample.IsCheckClearedSwitchExpression(new Cheque { Status = ChequeStatus.Cleared });
            Console.WriteLine(message);

            message = SwitchExample.IsCheckClearedSwitchExpression(new Cheque { Status = ChequeStatus.OnHold });
            Console.WriteLine(message);

            message = SwitchExample.IsCheckClearedSwitchExpression(new Cheque { Status = ChequeStatus.InProgress });
            Console.WriteLine(message);

            //message = SwitchExample.IsCheckClearedSwitchExpression(new Cheque { Status = ChequeStatus.Invalid });
            //Console.WriteLine(message);

            Console.Read();

            #endregion
        }

    }


}