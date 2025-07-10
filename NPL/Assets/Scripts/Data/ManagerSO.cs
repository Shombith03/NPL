using System;
using UnityEngine;

namespace CricketManager.Data
{
    /// <summary>
    /// ScriptableObject representing a manager profile.
    /// </summary>
    [CreateAssetMenu(fileName = "Manager", menuName = "CricketManager/Manager", order = 1)]
    public class ManagerSO : ScriptableObject
    {
        [Header("Profile")]
        public string managerName;
        public string nationality;

        [Tooltip("Short description or coaching style.")]
        [TextArea]
        public string style;
    }
}
