using System;
using System.Collections.Generic;
using UnityEngine;
using CricketManager.Data;

namespace CricketManager.UI.TeamSelection
{
    /// <summary>
    /// Interface for team selection view implementations.
    /// </summary>
    public interface ITeamSelectionView
    {
        event Action<Vector2> OnNavigate;
        event Action OnSelect;

        void Setup(List<TeamSO> teams);
        void ShowTeam(TeamSO team);
    }
}
