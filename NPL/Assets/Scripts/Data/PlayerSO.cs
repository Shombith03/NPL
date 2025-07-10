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
        /// <summary>
        /// Possible playing roles for a cricket player.
        /// </summary>
        public enum PlayerRole { Batsman, Bowler, Allrounder, WicketKeeper }

        /// <summary>
        /// Nested ratings container as required by the design spec.
        /// </summary>
        [Serializable]
        public class PlayerRatings
        {
            public int batting;
            public int bowling;
            public int fielding;
        }

        [Header("Basic Info")]
        public string playerName;
        public string country;
        public PlayerRole role;

        [Header("Skill Ratings")]
        public PlayerRatings ratings = new();
    }
}
