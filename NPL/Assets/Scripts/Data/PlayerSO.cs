using System;
using UnityEngine;

namespace CricketManager.Data
{
    /// <summary>
    /// ScriptableObject representing a player.
    /// </summary>
    [CreateAssetMenu(fileName = "Player", menuName = "CricketManager/Player", order = 0)]
    public class PlayerSO : ScriptableObject
    {
        public string playerName;
        public string role;
        public int rating;
    }
}
