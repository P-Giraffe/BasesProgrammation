using System;
abstract class FormeGeo
{
    private int _x = 0, _y = 0;

    public FormeGeo()
    {
        _x = 0;
        _y = 0;
    }

    public FormeGeo(int x, int y) : this()
    {
        deplacerHorizontalement(x);
        deplacerVerticalement(y);
    }

        public void deplacerHorizontalement(int xDelta)
    {
        _x = _x + xDelta;
    }

    public void deplacerVerticalement(int yDelta)
    {
        _y += yDelta;
    }

    public int obtenirX() {
        return _x;
    }

    public int obtenirY() {
        return _y;
    }

    public void dessiner()
    {
        Console.WriteLine("X : " + _x + ", Y : " + _y);
    }
}