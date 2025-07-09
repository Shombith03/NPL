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
        public enum Gender { Male, Female, Other }

        public string managerName;
        public Sprite avatar;
        public string nationality;
        public string currentTeam;
        [TextArea]
        public string bio;
        public Gender gender;
    }
}
