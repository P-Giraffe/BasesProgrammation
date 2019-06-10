using System;
public class RectangleGeo
{
    private int _largeur = 0;
    private int _hauteur = 0;

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

    public void dessiner(char character)
    {
        Console.WriteLine("rectangle : " + _largeur + "x" + _hauteur);
        for (int ligne = 0; ligne < _hauteur; ligne++)
        {
            for (int curseurLargeur = 0; curseurLargeur < _largeur; curseurLargeur++)
            {
                if (curseurLargeur == 0 || curseurLargeur == _largeur - 1
                    || ligne == 0 || ligne == _hauteur - 1)
                {
                    Console.Write(" " + character);
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }


    public void dessiner()
    {
        dessiner('*');
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