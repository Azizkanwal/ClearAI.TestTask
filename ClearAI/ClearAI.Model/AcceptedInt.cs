using System.ComponentModel.DataAnnotations;

namespace ClearAI.Model
{
    public class AcceptedInt
    {
        [Required]
        public int Num1 { get; set; }

        [Required]
        public int Num2{ get; set; }
    }
}