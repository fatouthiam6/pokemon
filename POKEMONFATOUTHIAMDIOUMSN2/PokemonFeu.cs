using POKEMONFATOUTHIAMDIOUMSN2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONFATOUTHIAMDIOUMSN2;

public class PokemonFeu : Pokemon
{
    public PokemonFeu(string nom, int hp, int atk) : base(nom, hp, atk)
    {
    }

    public override void Attaque(Pokemon p)
    {
        if (p is PokemonPlante)
        {
            p.HP -= 2 * Atk;
        }
        else if (p is PokemonEau)
        {
            p.HP -= Atk / 2;
        }
        else
        {
            base.Attaque(p);
        }
    }
}

