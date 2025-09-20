using System;
using System.Collections.Generic;
using System.Linq;
using MonkeyConsoleApp.Models;
using MonkeyConsoleApp.Data;

namespace MonkeyConsoleApp.Repositories
{
    public class MonkeyRepository
    {
        private readonly List<Monkey> _monkeys;
        private readonly Random _rnd = new Random();

        public MonkeyRepository()
        {
            _monkeys = SeedData.GetMonkeys();
        }

        public IEnumerable<string> ListNames() => _monkeys.Select(m => m.Name);

        public Monkey? GetByName(string name) => _monkeys.FirstOrDefault(m => string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));

        public Monkey GetRandom() => _monkeys[_rnd.Next(_monkeys.Count)];
    }
}