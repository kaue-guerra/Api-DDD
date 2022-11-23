using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIs.Models
{
    public class MessageViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Active { get; set; }

        public DateTime Created_at { get; set; }

        public DateTime Updated_at { get; set; }

        public string UserId { get; set; }

    }
}
