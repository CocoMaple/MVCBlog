﻿using MVCBlog.Common;
using MVCBlog.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCBlog.Entities.Models
{
    [Table("PostInfo")]
    public class PostInfo
    {
        public PostInfo()
        {
            CreateTime = DateTime.Now;
            //this.PostType = MVCBlog.Entities.Enums.PostType.文章;
            //this.PostStatus = MVCBlog.Entities.Enums.PostStatus.发布;
            //this.PostCommentStatus= MVCBlog.Entities.Enums.PostCommentStatus.打开;
            //this.CommentCount = 0;

        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [DefaultValue(PostStatus.发布)]
        public PostStatus PostStatus { get; set; }
        [DefaultValue(PostType.文章)]
        public PostType PostType { get; set; }
        [DefaultValue(PostCommentStatus.打开)]
        public PostCommentStatus PostCommentStatus { get; set; }
        [DefaultValue(0)]
        public int CommentCount { get; set; }
        public virtual UserInfo PostAuthor { get; set; }
        public virtual ICollection<PostMetasInfo> PostMetasInfos { get; set; }

        public virtual CategoryInfo PostCategoryInfo { get; set; }
        public DateTime? EditedTime { get; set; }

        public DateTime CreateTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
