using System.ComponentModel.DataAnnotations;

namespace Hangman.Models
{
    public class Score
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int LivesLeft { get; set; }

        public string Word { get; set; }
    }
}
