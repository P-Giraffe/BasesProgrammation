using System;
class RectangleGeo : FormeGeo
{
    private int _largeur;
    private int _hauteur;

    public RectangleGeo()
    {
        _largeur = 10;
        _hauteur = 30;
    }

    public RectangleGeo(int x, int y, int largeurDepart, int hauteurDepart) : base(x,y)
    {
        setLargeur(largeurDepart);
        setHauteur(hauteurDepart);
    }

    public new void dessiner()
    {
        base.dessiner();
        Console.WriteLine("rectangle : " + _largeur + "x" + _hauteur);
        for (int ligne = 0; ligne < _hauteur + obtenirY(); ligne++)
        {
            for (int curseurLargeur = 0; curseurLargeur < _largeur + obtenirX(); curseurLargeur++)
            {
                if (curseurLargeur < obtenirX() || ligne < obtenirY())
                {
                    Console.Write(" .");
                }
                else
                {
                    Console.Write(" *");
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
}