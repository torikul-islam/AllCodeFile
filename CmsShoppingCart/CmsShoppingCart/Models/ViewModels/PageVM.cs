using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;
using CmsShoppingCart.Models.Data;

namespace CmsShoppingCart.Models.ViewModels
{
    public class PageVM
    {
        public PageVM()
        {
            
        }

        public PageVM(PageDto row)
        {
            Id = row.Id;
            Title = row.Title;
            Slug = row.Slug;
            Body = row.Body;
            Sorting = row.Sorting;
            HasSlidebar = row.HasSlidebar;
        }
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        public string Slug { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        public string Body { get; set; }
        public int Sorting { get; set; }
        public string HasSlidebar { get; set; }
    }
}