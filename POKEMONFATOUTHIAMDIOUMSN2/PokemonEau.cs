using POKEMONFATOUTHIAMDIOUMSN2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONFATOUTHIAMDIOUMSN2;

public class PokemonEau : Pokemon
{
    public PokemonEau(string nom, int hp, int atk) : base(nom, hp, atk)
    {
    }

    public override void Attaque(Pokemon p)
    {
        if (p is PokemonFeu)
        {
            p.HP -= 2 * Atk;
        }
        else if (p is PokemonPlante)
        {
            p.HP -= Atk / 2;
        }
        else
        {
            base.Attaque(p);
        }
    }
}
