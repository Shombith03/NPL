using System.Collections.Generic;
using UnityEngine;

namespace CricketManager.Data
{
    /// <summary>
    /// Container ScriptableObject holding a list of manager profiles.
    /// </summary>
    [CreateAssetMenu(fileName = "ManagerList", menuName = "CricketManager/ManagerList", order = 5)]
    public class ManagerListSO : ScriptableObject
    {
        // TODO: Populate this list with generated ManagerSO assets
        public List<ManagerSO> managers = new();
    }
}
