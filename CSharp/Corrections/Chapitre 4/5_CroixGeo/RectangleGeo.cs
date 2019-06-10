using System;
public class RectangleGeo
{
    private int _largeur;
    private int _hauteur;

    private int _x = 0, _y = 0;

    public RectangleGeo()
    {
        _largeur = 10;
        _hauteur = 30;
    }

    public RectangleGeo(int largeurDepart, int hauteurDepart)
    {
        setLargeur(largeurDepart);
        setHauteur(hauteurDepart);
    }

    public void dessiner()
    {
        Console.WriteLine("rectangle : " + _largeur + "x" + _hauteur);
        for (int ligne = 0; ligne < _hauteur + _y; ligne++)
        {
            if (ligne >= _y) {
            for (int curseurLargeur = 0; curseurLargeur < _largeur + _x; curseurLargeur++)
            {
                if (curseurLargeur < _x)
                {
                    Console.Write(" .");
                }
                else
                {
                    Console.Write(" *");
                }
            }
            }
            Console.WriteLine();
        }
    }

    public int getLargeur()
    {
        return _largeur;
    }

    public int getHauteur()
    {
        return _hauteur;
    }

    public void setHauteur(int nouvelleHaut)
    {
        if (nouvelleHaut >= 0)
        {
            _hauteur = nouvelleHaut;
        }
    }
    public void setLargeur(int nouvelleLargeur)
    {
        if (nouvelleLargeur >= 0)
        {
            _largeur = nouvelleLargeur;
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