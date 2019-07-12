using System;
using System.Collections;
using System.Collections.Generic;
using JsonApiDotNetCore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JsonApiExample.Models
{
    public class Post : Identifiable
    {
        public DateTime CreatedDate { get; set; }
        public bool IsDraft { get; set; }
        public bool IsActive { get; set; }

        [Attr("title")]
        public string Title { get; set; }
        [Attr("content")]
        public string Content { get; set; }
        public string Image { get; set; }
        [HasMany("comments")]
        public ICollection<Comment> Comments { get; set; }
    }

}

