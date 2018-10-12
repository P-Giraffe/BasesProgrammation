package fr.purplegiraffe;

public abstract class Personnage {
    private int sante = 100;
    private int force;

    public Personnage(int force) {
        this.force = force;
    }

    public void attaquer(Personnage autrePersonnage) {
        autrePersonnage.recevoirCoup(force);
        force++;
    }

    public void recevoirCoup(int forceDuCoup) {
        sante = sante - forceDuCoup;
        if (sante < 0) {
            sante = 0;
        }
    }

    @Override
    public String toString() {
        return "Personnage{" +
                "sante=" + sante +
                ", force=" + force +
                '}';
    }
}
