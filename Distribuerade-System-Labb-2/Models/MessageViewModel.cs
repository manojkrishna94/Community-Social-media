﻿using Distribuerade_System_Labb_2.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Distribuerade_System_Labb_2.Models
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Body { get; set; }
        public Boolean Read { get; set; }
        public Boolean Deleted { get; set; }
        public DateTime SentDate { get; set; }
        public string ReceiverId { get; set; }
        public string SenderId  { get; set; }
        public List<Distribuerade_System_Labb_2User> Users { get; set; }
    }
}
