using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Interface defining healing-related functionality
    public interface IHealable
    {
        void Heal(int amount);
    }
}
