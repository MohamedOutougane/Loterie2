using System.ComponentModel.DataAnnotations;

namespace Loterie.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int SessionID { get; set; }
        public string shortGUID { get; set; }
        public string Game { get; set; }

        public Session? Session { get; set; }
    }
}
