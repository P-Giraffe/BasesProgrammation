import NePasToucher.readDouble
import NePasToucher.readInt
import java.util.*
import kotlin.math.min

fun main(args: Array<String>) {

    // Exercice 1
//    print("Entrez votre prénom : ")
//    val firstname = readString()
//    println("Bonjour ${firstname} !")


    //Exercice 2
//    print("Entrez la note 1 : ")
//    val n1 = readDouble()
//    print("Entrez la note 2 : ")
//    val n2 = readDouble()
//    print("Entrez la note 3 : ")
//    val n3 = readDouble()
//    val average = (n1 + n2 + n3) / 3
//    println("Moyenne : ${average}")

    // Exercice 3
//    print("Base du triangle : ")
//    val base = readDouble()
//    print("Hauteur du triangle : ")
//    val height = readDouble()
//    val area = (base * height) / 2
//    println("Aire : ${area}")

// Exercice 4
//    print("Rayon du cercle : ")
//    val ray = readDouble()
//    val area = Math.PI * ray * ray
//    println("Aire : ${area}")

    // Exercice 5  - Carre plein
//    val size = 4
//    for (ligne in 1..size) {
//        for (colonne in 1..size) {
//            print("* ")
//        }
//        println()
//    }

    // Exercice 5  - Carre vide
//    val size = 4
//    for (ligne in 1..size) {
//        for (colonne in 1..size) {
//            if (ligne == 1 || ligne == size || colonne == 1 || colonne == size) {
//                print("* ")
//            } else {
//                print("  ")
//            }
//        }
//        println()
//    }

    // Ex 6 : Moyenne - v1
//    val nbNotes = 3
//    var somme:Double = 0.0
//    val moyenne:Double
//
//    for (numeroNote in 1..nbNotes) {
//        print("Entrez la note ${numeroNote} : ")
//        val note = readDouble()
//        somme = somme + note
//    }
//    moyenne = somme / nbNotes
//    println("Moyenne : ${moyenne}")

    // Ex 6 - v2
//    var nbNotes = 0
//    var somme:Double = 0.0
//    val moyenne:Double
//    do {
//        print("Entrez la note ${nbNotes + 1}  (ou -1 pour arreter): ")
//        val note = readDouble()
//        if (note != -1.0) {
//            somme = somme + note
//            nbNotes++
//        }
//    } while (note != -1.0)
//
//    if (nbNotes != 0) {
//        moyenne = somme / nbNotes
//        println("Moyenne : ${moyenne}")
//    }


    // Ex 7 : Factorielle
//    val n = 8
//    var factorielle:Int = 1
//
//    for (compteur in 1..n) {
//        factorielle = factorielle * compteur
//        println("x ${compteur} = " + factorielle)
//    }
//
//    println("= ${factorielle}")

    // Ex 8 - nombre mystère
//    val generateur = Random()
//    val nombreMystere = generateur.nextInt(100) + 1
//    var tentative:Int
//    var nbTentatives:Int = 0
//
//    do {
//        println("Trouvez le nombre mystère compris entre 1 et 100 : ")
//        tentative = readInt()
//        if (tentative < nombreMystere) {
//            println("C'est plus")
//        } else if (tentative > nombreMystere) {
//            println("C'est moins")
//        }
//        nbTentatives++
//    } while (tentative != nombreMystere)
//
//    println("Bravo vous avez trouvé le nombre mystère en ${nbTentatives} tentative(s)")

// Ex 9 : jeu de nim

    var nbAllumettes = 20
    var joueurEnCours = 1
    val generateurIA = Random()

    do {
        var saisieJoueur:Int
        val saisieMax = min(3, nbAllumettes)
        do {
            println("Il reste ${nbAllumettes} allumette${if (nbAllumettes > 1) "s" else ""}, Joueur ${joueurEnCours} c'est à vous.")
            if (saisieMax == 1) {
                println("Désolé, la dernière est pour vous, prenez-la")
            } else {
                println("Prenez entre 1 et ${saisieMax} allumettes :")
            }
            if (joueurEnCours == 2) {
                saisieJoueur = generateurIA.nextInt(saisieMax) + 1
                println("L'IA prend ${saisieJoueur} allumette${if (saisieJoueur > 1) "s" else ""}")
            } else {
                saisieJoueur = readInt()
            }
            if (saisieJoueur < 1 || saisieJoueur > saisieMax) {
                println("Saisie incorrecte")
            }
        } while (saisieJoueur < 1 || saisieJoueur > saisieMax)

        nbAllumettes = nbAllumettes - saisieJoueur

        if (joueurEnCours == 1) {
            joueurEnCours = 2
        } else {
            joueurEnCours = 1
        }

    } while (nbAllumettes > 0)

    println("Bravo joueur ${joueurEnCours}! Vous avez gagné")












}

