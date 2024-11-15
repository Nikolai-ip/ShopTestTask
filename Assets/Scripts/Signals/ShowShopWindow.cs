namespace Signals
{
    public class ShowShopWindow:ISignal
    {
        public ShowShopWindow(string windowPackName, int itemsCount)
        {
            WindowPackName = windowPackName;
            ItemsCount = itemsCount;
        }

        public int ItemsCount { get; }

        public string WindowPackName { get; }
    }
}