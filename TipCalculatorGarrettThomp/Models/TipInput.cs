namespace TipCalculatorGarrettThomp.Models
{
    public class TipInput
    {
        public double MealCost { get; set; }
        public double tipFifteen { get; set; }
        public double tipTwenty { get; set; }
        public double tipTwentyFive { get; set; }


        public void CalculateTip()
        {
            double cost = MealCost;
            tipFifteen = cost * .15;
            tipTwenty = cost * .2;
            tipTwentyFive = cost * .25;
        }


    }
}
