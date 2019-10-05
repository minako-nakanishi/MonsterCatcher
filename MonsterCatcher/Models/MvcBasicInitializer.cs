using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MonsterCatcher.Models
{
    public class MvcBasicInitializer: DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var monsters = new List<Monster>
            {
                new Monster
                {
                    name = "フシギダネ",
                    number = 001,
                    type = "くさ",
                    secondType = "どく"
                },
                new Monster
                {
                    name = "フシギソウ",
                    number = 002,
                     type = "くさ",
                    secondType = "どく"
                }
            };
            monsters.ForEach(x => context.Monsters.Add(x));
            context.SaveChanges();
        }
    }
}