using System.Collections.Generic;
using UnityEngine;

namespace CricketManager.Data
{
    /// <summary>
    /// Container ScriptableObject holding a list of player profiles.
    /// </summary>
    [CreateAssetMenu(fileName = "PlayerList", menuName = "CricketManager/PlayerList", order = 4)]
    public class PlayerListSO : ScriptableObject
    {
        // TODO: Populate this list with generated PlayerSO assets
        public List<PlayerSO> players = new();
    }
}
