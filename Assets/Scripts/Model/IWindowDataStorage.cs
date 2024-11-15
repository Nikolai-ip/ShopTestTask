namespace Model
{
    public interface IWindowDataStorage
    {
        bool TryGetWindow(string windowName, out ShopWindowData shopWindowData);
    }
}