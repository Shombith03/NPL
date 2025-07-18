using System;
using System.Collections.Generic;
using UnityEngine;
using CricketManager.Data;

namespace CricketManager.UI.ManagerSelection
{
    /// <summary>
    /// Interface for manager selection view implementations.
    /// </summary>
    public interface IManagerSelectionView
    {
        event Action<Vector2> OnNavigate;
        event Action OnSelect;

        void Setup(List<ManagerSO> managers);
        void ShowManager(ManagerSO manager);
    }
}
