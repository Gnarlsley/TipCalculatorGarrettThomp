namespace TipCalculatorGarrettThomp.Models
{
    public class TipInput
    {
        public double MealCost { get; set; }

        public double[] CalculateTip()
        {
            double cost = MealCost;
            double tipFifteen = cost * .15;
            double tipTwenty = cost * .2;
            double tipTwentyFive = cost * .25;
            double[] tipAmounts = {tipFifteen, tipTwenty, tipTwentyFive};
            return tipAmounts;
        }


    }
}
