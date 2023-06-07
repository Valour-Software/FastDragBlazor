namespace FastDragBlazor;

public class DragChangeData<T>
{
    public T Identifier { get; set; }
    public List<DragChangeData<T>> Children { get; set; } = new();
    
    public DragChangeData(T identifier, List<DragChangeData<T>> children)
    {
        Identifier = identifier;
        Children = children;
    }
}

public class DragEventData<T>
{
    public T MovedItem { get; set; }
    public T TargetContainer { get; set; }
    public int Index { get; set; }
}