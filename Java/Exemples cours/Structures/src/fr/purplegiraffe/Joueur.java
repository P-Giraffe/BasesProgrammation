package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

public class Joueur extends Personnage {
    private String pseudo;
    private int score = 0;


    @Override
    public String toString() {
        String resultatParent = super.toString();
        return  "Joueur{" +
                "pseudo='" + pseudo + '\'' +
                ", score=" + score +
                "} --> " + resultatParent;
    }

    void afficheToi() {
        System.out.println("Bonjour " + this.pseudo + " votre score est de " + this.score);
    }

    void partieGagnee() {
        this.score += 1;
    }

    void partiePerdue() {
        if (this.score > 0) {
            this.score = this.score - 1;
        }
    }









    public Joueur() {
        super(1);
        this.pseudo = ConsoleReader.readString("Pseudo");
    }

    public Joueur(String nvPseudo, int force) {
        super(force);
        this.pseudo = nvPseudo;
    }

    public Joueur(String nvPseudo, int nvScore, int force) {
        this(nvPseudo, force);
        this.score = nvScore;
    }
}
