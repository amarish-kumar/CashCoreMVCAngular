using AtmModel;
using System;
using System.Collections.Generic;

namespace AtmRepository
{
    public static class DenominationRepository
    {

        static List<Denomination> initialState = GetAvailableDenomination();
        static List<Denomination> currentState = initialState;

        static List<Denomination> GetAvailableDenomination()
        {
            var availableDenominations = new List<Denomination>();

            var denomination = new Denomination() { DenominationValue = 0.01d, Quantity = 100, Value = 0.01d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 0.02d, Quantity = 100, Value = 0.02d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 0.05d, Quantity = 100, Value = 0.05d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 0.10d, Quantity = 100, Value = 0.10d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 0.20d, Quantity = 100, Value = 0.20d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 0.50d, Quantity = 100, Value = 0.50d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 1.00d,  Quantity = 100, Value = 1.00d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 2.00d, Quantity = 100, Value = 2.00d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 5.00d, Quantity = 50, Value = 5.00d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 10.00d, Quantity = 50, Value = 10.00d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 20.00d, Quantity = 50, Value = 20.00d };
            availableDenominations.Add(denomination);

            denomination = new Denomination() { DenominationValue = 50.00d, Quantity = 50, Value = 50.00d };
            availableDenominations.Add(denomination);

            return availableDenominations;
        }

        public static List<Denomination> InitialState
        {
            get { return initialState; }
            set {; }
        }

        public static List<Denomination> CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }
    }
}
