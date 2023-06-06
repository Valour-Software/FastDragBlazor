namespace FastDragBlazor;

public class DragEventItem<T>
{
    public T Identifier { get; set; }
    public List<DragEventItem<T>> Children { get; set; } = new();
    
    public DragEventItem(T identifier, List<DragEventItem<T>> children)
    {
        Identifier = identifier;
        Children = children;
    }
}