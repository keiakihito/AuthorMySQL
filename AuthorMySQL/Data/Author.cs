using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorMySQL.Data
{
    [Table("authors")]
    public partial class Author
    {
        [Key]
        [Column("au_id"), Required, MaxLength(11)]
        public string AuthorId { get; set; } = string.Empty;

        [Column("au_fname"), Required, MaxLength(20)]
        public string AuthorFirstName { get; set; } = string.Empty;

        [Column("au_lname"), Required, MaxLength(40)]
        public string AuthorLastName { get; set; } = string.Empty;

        [Column("phone"), Required, MaxLength(12)]
        public string Phone { get; set; } = string.Empty;

        [Column("address"), MaxLength(40)]
        public string? Address { get; set; }

        [Column("city"), MaxLength(20)]
        public string? City { get; set; }

        [Column("state"), MaxLength(2)]
        public string? State { get; set; }

        [Column("zip"), MaxLength(5)]
        public string? Zip { get; set; }

        [Column("contract"), Required]
        public bool Contract { get; set; }

        [Column("rowversion"), Timestamp, ConcurrencyCheck]
        public byte[]? RowVersion { get; set; }
    }
}