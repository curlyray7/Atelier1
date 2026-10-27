public class Door : Tile
{
    private bool _isOpen = false;

    public Key Key { get; } = new Key();

    public override bool IsTraversable => _isOpen;

    public override bool Pass() => _isOpen;

    public bool Open(Key key)
    {
        if (ReferenceEquals(key, Key))
        {
            _isOpen = true;
        }
        return _isOpen;
    }

    public bool Close(Key key)
    {
        if (ReferenceEquals(key, Key))
        {
            _isOpen = false;
        }
        return !_isOpen;
    }
}
