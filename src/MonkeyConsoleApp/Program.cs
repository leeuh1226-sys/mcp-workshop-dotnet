using System;
using MonkeyConsoleApp.Repositories;

var repo = new MonkeyRepository();

if (args.Length == 0)
{
    Console.WriteLine("Usage: dotnet run -- [list|get <name>|random]");
    return 0;
}

var cmd = args[0].ToLowerInvariant();

return cmd switch
{
    "list" => ListCmd(repo),
    "get" => GetCmd(repo, args.Length > 1 ? args[1] : string.Empty),
    "random" => RandomCmd(repo),
    _ => UnknownCmd(cmd)
};

int ListCmd(MonkeyRepository repo)
{
    foreach (var name in repo.ListNames())
    {
        Console.WriteLine(name);
    }
    return 0;
}

int GetCmd(MonkeyRepository repo, string name)
{
    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Please provide a monkey name: get <name>");
        return 1;
    }

    var m = repo.GetByName(name);
    if (m is null)
    {
        Console.WriteLine($"Monkey '{name}' not found.");
        return 1;
    }

    Console.WriteLine(m);
    return 0;
}

int RandomCmd(MonkeyRepository repo)
{
    var m = repo.GetRandom();
    Console.WriteLine(m);
    return 0;
}

int UnknownCmd(string cmd)
{
    Console.WriteLine($"Unknown command: {cmd}");
    Console.WriteLine("Usage: dotnet run -- [list|get <name>|random]");
    return 2;
}
