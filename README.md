# LeetPrint

Write to the console, but cooler.
This library is one of the projects i came up with for my internship. It's inspired by the text effect in the show "The Blacklist".

---
# Example

```csharp
using LeetPrint;

Printer printer = new Printer();

Console.WriteLine("Regular console output is boring, right?");

Thread.Sleep(7000);

printer.Print(
    "But what about this one? This looks way cooler.",
    delay: 3,
    rounds: 1,
    newLine: true,
    symbols: "▒"
);


Thread.Sleep(7000);

printer.Print(
    "Or maybe this? Inspired by 'The Blacklist'",
    delay: 1,
    rounds: 10,
    newLine: true
);
```
