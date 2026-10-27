public class Room : Tile
{
    public Room(ICollectable? item = null)
    {
        Item = item;
    }

    public ICollectable? Item { get; private set; }

    public override bool IsTraversable => true;

    public override bool Pass() => true;

    public ICollectable? TakeItem()
    {
        var item = Item;
        Item = null;
        return item;
    }
}
