using System.ComponentModel.DataAnnotations;

namespace Loterie.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string? Draw { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Jackpot { get; set; }

        public ICollection<Ticket>? Tickets { get; set; }
    }
}
