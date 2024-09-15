using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InheritanceGame_GameLogic
{
    // Interface defining damage-related functionality
    public interface IDamagable
    {
        void TakeDamage(int amount);
    }
}
