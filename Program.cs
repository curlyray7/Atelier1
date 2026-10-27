var labyrinth = new Labyrinth("""
    +--+--------+
    |  /        |
    |  +--+--+  |
    |     |k    |
    +--+  |  +--+
       |k       |
    +  +-------/|
    |           |
    +-----------+
    """);

Console.WriteLine($"Width: {labyrinth.Width}, Height: {labyrinth.Height}");
