using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DbModels
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        public string Lyric { get; set; }

        public string Chord { get; set; }

        public string Note { get; set; }

        public string Audio { get; set; }

        public string Lycho { get; set; }

        public long Likes { get; set; }

        public long Dislike { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public Composer Composer { get; set; }
        public int ComposerId { get; set; }

        public Keym Keym { get; set; }
        public int KeymId { get; set; }

        public Poet Poet { get; set; }
        public int PoetId { get; set; }

        public Singer Singer { get; set; }
        public int SingerId { get; set; }

        public Typem Typem { get; set; }
        public int TypemId { get; set; }

    }
}
