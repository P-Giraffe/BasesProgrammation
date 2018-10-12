package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

import java.util.ArrayList;

public class Application {
    public void fonctionPrincipale() {
        Joueur j = new Joueur("Thibert", 1);
        Bot b = new Bot(20);
        j.attaquer(b);
        b.attaquer(j);

        System.out.println(j);
        System.out.println(b);

//        int[] notes = new int[10];
//        for (int indexNote = 0; indexNote < notes.length; indexNote++) {
//            notes[indexNote] = -1;
//        }
//
//        notes[0] = 10;
//        notes[1] = 18;
//
//        for (int note : notes) {
//            System.out.println(note);
//        }


//        ArrayList<String> listeNoms = new ArrayList<>();
//        listeNoms.add("Tokyo");
//        listeNoms.add("Nairobi");
//        listeNoms.add(1,"Moscou");
//        listeNoms.set(1,"Berlin");
//        System.out.println(listeNoms.get(0));
//        listeNoms.remove(0);
//        System.out.println(listeNoms.get(0));



//        Joueur j1 = new Joueur("Sheldon");
//
//        Joueur j2 = new Joueur("Leonard", 100);
//
//        j1.afficheToi();
//        j1.partieGagnee();
//        j1.afficheToi();
//        j1.partiePerdue();
//        j1.afficheToi();
//        j1.partiePerdue();
//
//        j1.afficheToi();
//        j2.afficheToi();


    }

//    Joueur creerJoueur() {
//        String pseudo = ConsoleReader.readString("Entrez votre pseudo");
//        Joueur nouveauJoueur = new Joueur(pseudo);
//        do {
//            nouveauJoueur.score = ConsoleReader.readInt("Entrez votre score");
//        } while (nouveauJoueur.score < 0);
//
//        return nouveauJoueur;
//    }


}
