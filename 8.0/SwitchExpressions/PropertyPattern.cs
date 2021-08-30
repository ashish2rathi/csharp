using System;
// ReSharper disable All

namespace SwitchExpressions
{
    class Address
    {
        public string State { get; set; }
        public string City { get; set; }
    }


    class PropertyPattern
    {
        #region PropertyPattern
        //Calculate tax depending on state(location)
        public static void CalculateTaxBasedOnState(string state)
        {
            var address = new Address { State = state };
            Console.WriteLine($"Overall price (including tax) of { address.State} is: { ComputeOverallPrice(address, 2.4M)}");
        }

        private static decimal ComputeOverallPrice(Address adrress, decimal price)
            =>
                adrress switch
                {
                    { State: "MH" } => price + price * 0.78M,
                    { State: "BIHAR" } => price + price * 0.06M,
                    { State: "RAJASTHAN" } => price + price * 0.07M,
                    _ => 0M
                };

        #endregion PropertyPattern

        #region PropertyPattern2
        public static void CalculateTaxBasedOnStateAndCity(Address address)
        {
            Console.WriteLine($"Overall price (including tax) of state { address.State} and city {address.City} is: { ComputeOverallPrice2(address, 2.4M)}");
        }

        private static decimal ComputeOverallPrice2(Address location, decimal price)
            =>
                location switch
                {
                    { State: "MH", City: "MUMBAI" } => price + price * 0.06M,
                    { State: "BIHAR", City: "AURANGABAD" } => price + price * 0.07M,
                    { State: "MH", City: _ } => price + price * 0.78M
                    //_ => 0M
                };

        #endregion PropertyPattern2
    }
}
