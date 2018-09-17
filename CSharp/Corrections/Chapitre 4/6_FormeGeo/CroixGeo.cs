using System;
class CroixGeo : FormeGeo
{
    private int _largeur;
    private int _hauteur;

    public CroixGeo()
        : this(10, 30)
    {
    }

    public CroixGeo(int largeurDepart, int hauteurDepart)
        : this(0, 0, largeurDepart, hauteurDepart)
    {
    }

    public CroixGeo(int x, int y, int largeurDepart, int hauteurDepart) : base(x,y)

    {
        this._largeur = largeurDepart;
        this._hauteur = hauteurDepart;
    }


    public new void dessiner()
    {
        base.dessiner();
        Console.WriteLine("Croix : " + _largeur + "x" + _hauteur);
        for (int ligne = 0; ligne < obtenirY() + _hauteur; ligne++)
        {
            for (int curseurLargeur = 0; curseurLargeur < obtenirX() + _largeur; curseurLargeur++)
            {
                if (curseurLargeur >= obtenirX() && ligne >= obtenirY())
                {
                    if (curseurLargeur == (_largeur / 2) + obtenirX() || ligne == (_hauteur / 2) + obtenirY())
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                else
                {
                    Console.Write(" .");
                }
            }
            Console.WriteLine();
        }
    }
}