using Model;

namespace View
{
    public interface IWindowView
    {
        void SetView(ShopWindowData windowData);
        void Hide();
    }
}