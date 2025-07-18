using System.Collections.Generic;
using UnityEngine;

namespace CricketManager.Data
{
    /// <summary>
    /// ScriptableObject representing a cricket team.
    /// </summary>
    [CreateAssetMenu(fileName = "Team", menuName = "CricketManager/Team", order = 2)]
    public class TeamSO : ScriptableObject
    {
        public string teamName;
        public Sprite teamLogo;
        public List<PlayerSO> players = new();
        public int battingStrength;
        public int bowlingStrength;
        public int fieldingStrength;
        [TextArea]
        public string recentPerformance;
        public int budget;
        public string rivals;
        public int leaguePosition;
        public string leagueName;
        public List<string> seasonObjectives = new();
    }
}
