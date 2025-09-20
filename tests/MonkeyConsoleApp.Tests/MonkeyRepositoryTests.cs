using System.Linq;
using MonkeyConsoleApp.Repositories;
using Xunit;

namespace MonkeyConsoleApp.Tests
{
    public class MonkeyRepositoryTests
    {
        [Fact]
        public void ListNames_ReturnsSomeNames()
        {
            var repo = new MonkeyRepository();
            var names = repo.ListNames().ToList();
            Assert.NotEmpty(names);
        }

        [Fact]
        public void GetByName_IsCaseInsensitive()
        {
            var repo = new MonkeyRepository();
            var m = repo.GetByName("bongo");
            Assert.NotNull(m);
            Assert.Equal("Bongo", m.Name);
        }

        [Fact]
        public void GetRandom_ReturnsAMonkey()
        {
            var repo = new MonkeyRepository();
            var m = repo.GetRandom();
            Assert.NotNull(m);
        }
    }
}
