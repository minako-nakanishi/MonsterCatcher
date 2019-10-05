using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterCatcher.Models
{
    public class Monster
    {
        public int id { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string secondType { get; set; }
    }
}