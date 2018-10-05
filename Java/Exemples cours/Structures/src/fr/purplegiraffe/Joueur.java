package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

public class Joueur {
    public String pseudo;
    public int score = 0;

    public Joueur() {
        this.pseudo = ConsoleReader.readString("Pseudo");
    }

    public Joueur(String nvPseudo) {
        this.pseudo = nvPseudo;
    }

    public Joueur(String prenom, String nom) {
        this(prenom + " " + nom);
    }

    public Joueur(String nvPseudo, int nvScore) {
        this(nvPseudo);
        this.score = nvScore;
    }
}
