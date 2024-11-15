using Infrastructure;
using Model;
using Signals;
using UnityEngine;
using View;

namespace Controller
{
    public class WindowController:MonoBehaviour
    {
        private IWindowDataStorage _windowDataStorage;
        private IWindowView _view;
        
        public void Init(IWindowView view, IWindowDataStorage windowDataStorage)
        {
            _view = view;
            _windowDataStorage = windowDataStorage;
            EventBus.Subscribe<ShowShopWindow>(OnShowWindowButton);
        }
        
        private void OnShowWindowButton(ShowShopWindow signal)
        {
            if (_windowDataStorage.TryGetData(signal.WindowPackName, signal.ItemsCount, out var windowData))
            {
                _view.SetView(windowData);        
            } 
            
        }

        public void OnExitButton()
        {
            _view.Hide();
        }
    }
}