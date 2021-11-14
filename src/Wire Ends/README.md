> This is a challenge developed for the C# discord server.<br/>
> Want to Participate? Join the C# discord: <sub><a href="https://discord.gg/csharp"><img src="https://img.shields.io/discord/143867839282020352?logo=discord&logoColor=ffffff&color=7389D8" title="C# Discord Server" /></a></sub>

# Wire Ends

You are writing a software that allows users to design electrical circuits. You need to add a feature
that will count the number of loose wire ends in the current design. The wire layout data is currently
stored in a `string` with the characters ` `, `║`, `╠`, `╩`, `╦`, `═`, `╬`, `╣`, `╚`, `╝`, `╔`, `╗`, and `\n`.
The `\n` character represents the end of the current horizontal dimension, the `' '` character represents a 
coordinate with no wires, and the rest `║ ╠ ╩ ╦ ═ ╬ ╣ ╚ ╝ ╔ ╗` represent various wire configurations.

### Sample input

```cs
string input =
    "╔══╗\n" +
    "║╚╝║\n" +
    "║╔╗║\n" +
    "╚══╝";
// contains 4 disconnected wire ends
```

```cs
string input =
    "║╔╗║\n" +
    "║║║║\n" +
    "║║║║\n" +
    "╚╝╚╝";
// contains 2 disconnected wire ends
```

```cs
string input =
    " ╔╗\n" +
    "╔╝╚═╗\n" +
    "╚╗  ╚═╗\n" +
    " ╚════╝";
// contains 0 disconnected wire ends
```

### Quick start

```cs
public int CountWireEnds(string s)
{
    string chars = "║╠╩╦═╬╣╚╝╔╗ \n";

    // -----------------------
    // complete challenge here
    // -----------------------
}
```

Unit tests are included here: [WireEndsTests.cs](WireEndsTests.cs)

### Challenge Yourself

After you successfully complete the challenge, consider challenging yourself further...
- golf: minimize the source code for the solution as much as possible while keeping it fully functional
- optimization: optimize your solution as much as possible using [Benchmark.NET](https://github.com/dotnet/BenchmarkDotNet)

### Feedback

If you have any feedback on this challenge, please open an issue on this repository, mention this challenge, and ping the contributor(s) of this challenge.

### Contributor(s)

- [@zacharypatten](https://github.com/ZacharyPatten)

### Source

This was an original challege. :)