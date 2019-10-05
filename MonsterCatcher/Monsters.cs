namespace MonsterCatcher
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Monsters
    {
        public int id { get; set; }

        public int number { get; set; }

        public string name { get; set; }

        public string type { get; set; }

        public string secondType { get; set; }
    }
}
