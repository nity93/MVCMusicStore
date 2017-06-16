using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int SongNumbers { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        //after eah new change to the model, do add-migrations ___ and update database
    }
}