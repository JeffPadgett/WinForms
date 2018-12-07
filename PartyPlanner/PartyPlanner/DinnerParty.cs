using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int _numberOfPeople;
        public decimal CostOfBeveragesPerPerson { get; set; }
        public decimal CostOfDecorations { get; set; }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            if (fancyDecorations)
                CostOfDecorations = (_numberOfPeople * 15M) + 50.00M;
            else
                CostOfDecorations = (_numberOfPeople * 7.50M) + 30.00M;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * _numberOfPeople);

            if (healthyOption)
                return totalCost * .95M;
            else
                return totalCost;

        }

        public void SetPartyOptions(int people, bool fancy)
        {
            _numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return _numberOfPeople;
        }
    }
}
