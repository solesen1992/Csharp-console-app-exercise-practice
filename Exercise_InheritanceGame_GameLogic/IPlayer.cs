using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Interface defining player-related methods and properties
    public interface IPlayer
    {
        bool IsAlive { get; set; }
        decimal Hitpoints { get; set; }
        void Die();
        void Respawn();
    }
}
