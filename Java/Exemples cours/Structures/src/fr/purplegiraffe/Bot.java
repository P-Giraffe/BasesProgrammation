package fr.purplegiraffe;

public class Bot extends Personnage {
    private int vitesse = 1;

    public Bot(int force) {
        super(force);
    }

    @Override
    public String toString() {
        String resultatParent = super.toString();
        return "Bot{" +
                "vitesse=" + vitesse +
                "} --> " + resultatParent;
    }

}
