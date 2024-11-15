using Model;
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
        }
        
        public void OnShowWindowButton(string windowName)
        {
            if (_windowDataStorage.TryGetWindow(windowName, out var windowData))
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