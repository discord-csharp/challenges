> This is a challenge developed for the C# discord server.
> Want to Participate? Join the C# discord: <sub><a href="https://discord.gg/csharp"><img src="https://img.shields.io/discord/143867839282020352?logo=discord&logoColor=ffffff&color=7389D8" title="C# Discord Server" /></a></sub>

# Wire Ends

You are writing a software that allows users to design electrical circuits. You need to add a feature
that will count the number of loose wire ends in the current design. The wire layout data is currently
stored in a `string` with the characters ` `, `║`, `╠`, `╩, `╦`, `═`, `╬`, `╣`, `╚`, `╝`, `╔`, `╗`, and `\n`.
The `\n` character represents the end of the current horizontal dimension, the ' ' character represents a 
coordinate with no wires, and the rest `║ ╠ ╩ ╦ ═ ╬ ╣ ╚ ╝ ╔ ╗` represent various wire configurations.

### Sample input

```cs
string input =
    "╔══╗\n" +
    "║╚╝║\n" +
    "║╔╗║\n" +
    "╚══╝";
// contains 4 disconnected wires
```

```cs
string input =
    "║╔╗║\n" +
    "║║║║\n" +
    "║║║║\n" +
    "╚╝╚╝";
// contains 2 disconnected wires
```

```cs
string input =
    " ╔╗\n" +
    "╔╝╚═╗\n" +
    "╚╗  ╚═╗\n" +
    " ╚════╝";
// contains 0 disconnected wires
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

[Read full challenge information on GitHub](https://github.com/discord-csharp/challenges/blob/main/src/2021-01-01-sample-challenge.md)

Take part in this challenge by meeting the specification, golfing your answer or providing the best performing code by benchmarking it (using Benchmark.NET). Post solutions to the solutions thread, and discuss anything else in the discussion thread.