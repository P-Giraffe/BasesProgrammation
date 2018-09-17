using System;
class CroixGeo
{
    private int _largeur;
    private int _hauteur;
    private int _x = 0, _y = 0;

    public CroixGeo()
        : this(10, 30)
    {
    }

    public CroixGeo(int largeurDepart, int hauteurDepart)
        : this(0, 0, largeurDepart, hauteurDepart)
    {
    }

    public CroixGeo(int x, int y, int largeurDepart, int hauteurDepart)

    {
        this._x = x;
        this._y = y;

        this._largeur = largeurDepart;
        this._hauteur = hauteurDepart;
    }


    public void dessiner()
    {
        Console.WriteLine("Croix : " + _largeur + "x" + _hauteur);
        for (int ligne = 0; ligne < _y + _hauteur; ligne++)
        {
            for (int curseurLargeur = 0; curseurLargeur < _x + _largeur; curseurLargeur++)
            {
                if (curseurLargeur >= _x && ligne >= _y)
                {
                    if (curseurLargeur == (_largeur / 2) + _x || ligne == (_hauteur / 2) + _y)
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

    public void deplacerHorizontalement(int xDelta)
    {
        _x = _x + xDelta;
    }

    public void deplacerVerticalement(int yDelta)
    {
        _y += yDelta;
    }
}