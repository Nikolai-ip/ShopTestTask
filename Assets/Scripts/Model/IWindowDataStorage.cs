namespace Model
{
    public interface IWindowDataStorage
    {
        bool TryGetData(string windowName, int itemsCount, out ShopWindowData shopWindowData);
    }
}