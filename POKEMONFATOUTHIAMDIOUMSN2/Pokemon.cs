using System;

namespace POKEMONFATOUTHIAMDIOUMSN2;

public class Pokemon
{
    public string Nom { get; set; }
    public int HP { get; set; }
    public int Atk { get; set; }

    public Pokemon(string nom, int hp, int atk)
    {
        Nom = nom;
        HP = hp;
        Atk = atk;
    }

    public bool IsDead()
    {
        return HP <= 0;
    }

    public virtual void Attaque(Pokemon p)
    {
        p.HP -= Atk;
    }

    public override string ToString()
    {
        return $"Nom : {Nom}, HP : {HP}, Atk : {Atk}";
    }
}