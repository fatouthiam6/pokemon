using POKEMONFATOUTHIAMDIOUMSN2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POKEMONFATOUTHIAMDIOUMSN2;


public class PokemonPlante : Pokemon
{
    public PokemonPlante(string nom, int hp, int atk) : base(nom, hp, atk)
    {
    }

    public override void Attaque(Pokemon p)
    {
        if (p is PokemonEau)
        {
            p.HP -= 2 * Atk;
        }
        else if (p is PokemonFeu)
        {
            p.HP -= Atk / 2;
        }
        else
        {
            base.Attaque(p);
        }
    }
}