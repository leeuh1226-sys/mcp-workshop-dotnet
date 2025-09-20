using System.Collections.Generic;
using MonkeyConsoleApp.Models;

namespace MonkeyConsoleApp.Data
{
    public static class SeedData
    {
        public static List<Monkey> GetMonkeys() => new List<Monkey>
        {
            new Monkey
            {
                Name = "Bongo",
                Species = "Capuchin",
                Age = 4,
                Description = "A curious capuchin who loves bananas.",
                AsciiArt = @" (\_/)
 (•_•)
 / >🍌"
            },
            new Monkey
            {
                Name = "Mika",
                Species = "Spider Monkey",
                Age = 6,
                Description = "Playful and energetic, swings through the trees.",
                AsciiArt = @"  .-""-.
 / .===. \\
 \ 6 6 /
 (  \_/  )
  \     /
   `---'"
            },
            new Monkey
            {
                Name = "Nori",
                Species = "Mandrill",
                Age = 5,
                Description = "Brightly colored and bold.",
                AsciiArt = @" (\__/)
 (o^-^)
 / \ 
/   /"
            }
        };
    }
}