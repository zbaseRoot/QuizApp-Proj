using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Database
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public string OptionRed { get; set; }
        public string OptionBlue { get; set; }
        public string OptionYellow { get; set; }
        public string OptionGreen { get; set; }
        public string CorrectOption { get; set; }

        public int QuizId { get; set; }

        [ForeignKey(nameof(QuizId))]
        public Quiz Quiz { get; set; }
    }
}