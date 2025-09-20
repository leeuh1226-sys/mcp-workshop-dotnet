using System;

namespace MonkeyConsoleApp.Models
{
    public class Monkey
    {
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;
        public string AsciiArt { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{AsciiArt}\nName: {Name}\nSpecies: {Species}\nAge: {Age}\n{Description}";
        }
    }
}