# Implement Monkey Console Application

## Summary
Create a C# console app that can list all available monkeys, get details for a specific monkey by name, and pick a random monkey.

## Requirements
- Create a `Monkey` model class with properties such as `Name`, `Species`, `Age`, `Description`, and `AsciiArt` (string).
- Create a console application (new project under `src/` or `tools/`) that exposes these commands:
  - `list` - lists all monkey names available.
  - `get <name>` - prints detailed information for the monkey with the given name.
  - `random` - picks and prints a random monkey's details.
- Include ASCII art for each monkey in the `AsciiArt` property to make the output more fun.
- Provide a small in-memory repository (e.g. `List<Monkey>`) seeded with a handful of example monkeys to get started. Later this can be swapped for a JSON file or database.
- Add clear README lines explaining how to run the console app (dotnet run in project folder) and examples of each command.

## Implementation notes
- Use modern C# (target the repo's global.json SDK) and a minimal console style (top-level statements or a small Program.cs with command parsing).
- Provide a `MonkeyRepository` class that abstracts retrieval, listing and random selection.
- Keep the sample data in a single `SeedData.cs` or embedded JSON for ease of extension.
- Consider using a small argument parser (e.g. `System.CommandLine` or a simple manual switch-case) depending on desired complexity.
- Include unit tests for the repository methods and for command parsing where practical.

## Checklist
- [ ] Add new console project under `src/` or `tools/` called `MonkeyConsoleApp`.
- [ ] Implement `Monkey` model class and `MonkeyRepository` with seed data.
- [ ] Implement commands: `list`, `get <name>`, `random`.
- [ ] Add ASCII art for each sample monkey.
- [ ] Add README with run instructions and examples.
- [ ] Add basic unit tests.
- [ ] Add project to solution file if applicable (`McpTodo.sln` or create new solution for tools).

## Notes
Label suggestions: `enhancement`, `good first issue`.

Please create this issue and add the suggested labels and checklist.  
