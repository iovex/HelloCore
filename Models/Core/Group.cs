using System;

namespace HelloCore.Models.Core
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public byte ValidStatus { get; set; }
    }


}