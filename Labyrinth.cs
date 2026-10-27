public class Labyrinth
{
    private readonly Tile[,] _tiles;

    public Labyrinth(string ascii)
    {
        var lines = ascii.Split('\n');

        Width = lines[0].TrimEnd('\r').Length;
        Height = lines.Length;
        _tiles = new Tile[Width, Height];

        var keys = new Queue<Key>();
        var keyRooms = new List<(int X, int Y)>();

        for (int y = 0; y < Height; y++)
        {
            var line = lines[y].TrimEnd('\r');
            for (int x = 0; x < Width; x++)
            {
                char c = x < line.Length ? line[x] : ' ';
                switch (c)
                {
                    case '+':
                    case '-':
                    case '|':
                        _tiles[x, y] = new Wall();
                        break;
                    case '/':
                        var door = new Door();
                        keys.Enqueue(door.Key);
                        _tiles[x, y] = door;
                        break;
                    case 'k':
                        keyRooms.Add((x, y));
                        break;
                    default:
                        _tiles[x, y] = new Room();
                        break;
                }
            }
        }

        foreach (var (x, y) in keyRooms)
        {
            _tiles[x, y] = new Room(keys.Count > 0 ? keys.Dequeue() : null);
        }
    }

    public int Width { get; }

    public int Height { get; }

    public Tile this[int x, int y] => _tiles[x, y];
}
