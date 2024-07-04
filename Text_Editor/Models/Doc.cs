using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Text_Editor.Models
{
    public class Doc
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string? UserId { get; set; }
        [ForeignKey("UserId")]

        public IdentityUser? User { get; set; }
    }
}
