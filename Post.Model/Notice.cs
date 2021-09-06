using System;
using System.ComponentModel.DataAnnotations;

namespace Post.Model
{
    public class Notice
    {
        [Key]
        public int NoticeNumber { get; set; }

        [Required]
        public String NoticeTitle { get; set; }

        [Required]
        public int NoticeContents { get; set; }

        [Required]
        public DateTime NoticeDate { get; set; }
    }
}
