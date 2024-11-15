using System;
using Controller;
using Fabric;
using Model;
using UnityEngine;
using View;

namespace Infrastructure
{
    public class GameBootstrap:MonoBehaviour
    {
        [SerializeField] private WindowController _windowController;
        [SerializeField] private WindowView _windowView;
        [SerializeField] private ResourceMappingContainer _resourceMappingContainer;
        private void Awake()
        {
            _resourceMappingContainer.Init();
            _windowView.Init(_resourceMappingContainer);
            _windowController.Init(_windowView, new WindowDataStorage());
        }
    }
}