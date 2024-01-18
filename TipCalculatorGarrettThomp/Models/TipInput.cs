using System.ComponentModel.DataAnnotations;

namespace TipCalculatorGarrettThomp.Models
{
    public class TipInput
    {
        [Required(ErrorMessage = "You must enter a meal cost.")]
        [Range (0, int.MaxValue, ErrorMessage = "You must enter a number greater than zero.")]
        public double? MealCost { get; set; }


        public double tipFifteen(double? cost)
        {
            if (cost.HasValue)
            {
                    return (double)(cost * .15);
            }
            else
            {
                return 0;
            }
        }

        public double tipTwenty(double? cost)
        {
            if (cost.HasValue)
            {
                return (double)(cost * .2);
            }
            else
            {
                return 0;
            }
        }

        public double tipTwentyFive(double? cost)
        {
            if (cost.HasValue)
            {
                    return (double)(cost * .25);
            }
            else
            {
                return 0;
            }
        }


    }
}
