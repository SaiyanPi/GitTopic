using System.ComponentModel.DataAnnotations;

namespace GitDump.Model
{
    public class Test
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
        public string? Description { get; set; }

    }
}
