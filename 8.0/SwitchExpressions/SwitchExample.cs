using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchExpressions
{
    class Cheque
    {
        public ChequeStatus Status { get; set; }
    }

    enum ChequeStatus
    {
        Cleared,
        InProgress,
        Bounced,
        OnHold
        //Invalid
    }

    class SwitchExample
    {

        public static string IsCheckClearedSwitchBlock(Cheque cheque)
        {
            switch (cheque.Status)
            {
                case ChequeStatus.Cleared:
                    return "Cheque cleared";

                case ChequeStatus.InProgress:
                    return "Cheque clear is in progress";

                case ChequeStatus.Bounced:
                    return "Cheque bounced due to insufficient balance";

                case ChequeStatus.OnHold:
                    return "Cheque on hold";

                //Not optional
                //default:
                //    return "Cheque on hold";
            }

            return "Cheque on hold";
        }


        public static string IsCheckClearedSwitchExpression(Cheque cheque)
        {
            return cheque.Status switch
            {
                ChequeStatus.Cleared => "Cheque cleared",
                ChequeStatus.InProgress => "Cheque clear is in progress",
                ChequeStatus.Bounced => "Cheque bounced due to insufficient balance",
                ChequeStatus.OnHold => "Cheque on hold"
                //_ => "Cheque is invalid" //optional
            };
        }



        public static void IsCheckClearedNotificationSwitchBlock(Cheque cheque)
        {
            switch (cheque.Status)
            {
                case ChequeStatus.Cleared:
                    Console.WriteLine("Cheque cleared");
                    break;

                case ChequeStatus.InProgress:
                    Console.WriteLine("Cheque clear is in progress");
                    break;

                case ChequeStatus.Bounced:
                    Console.WriteLine("Cheque bounced due to insufficient balance");
                    break;

                case ChequeStatus.OnHold:
                    Console.WriteLine("Cheque on hold");
                    break;

                default:
                    Console.WriteLine("Cheque on hold");
                    break;
            }
        }

        public static void IsCheckClearedNotificationSwitchExpression(Cheque cheque)
        {
            //cheque.Status switch
            //{
            //    ChequeStatus.Cleared => Console.WriteLine("Cheque cleared"),
            //    ChequeStatus.InProgress => Console.WriteLine("Cheque clear is in progress"),
            //    ChequeStatus.OnHold => Console.WriteLine("Cheque on hold"),
            //    ChequeStatus.Bounced => Console.WriteLine("Cheque bounced due to insufficient balance"),
            //    _ => Console.WriteLine("Cheque on hold")
            //};
        }
    }
}
