using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GameWatcher.Models
{
    public class Channel
    {
        [Key]
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
    }
}
