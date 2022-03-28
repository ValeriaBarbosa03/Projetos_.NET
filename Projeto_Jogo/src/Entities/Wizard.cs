using Projeto_Jogo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Jogo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return Name + "Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + "lançou magia super eficiente com bônus de ataque de " + Bonus;

            }
            else
            {
                return this.Name + "lançou magia com força fraca com bônus de ataque de " + Bonus;
            }
        }
    }
}
