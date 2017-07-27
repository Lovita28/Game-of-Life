using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public interface IArcherAttack
    {
        void AttackRange(Monster enemy);
        void Heal();
    }
}
