//
//  main.swift
//  AppConsole
//
//  Created by Maxime Britto on 02/05/2017.
//  Copyright © 2017 mbritto. All rights reserved.
//

import Foundation

func exercice1() {
    print("Quel est votre prénom : ")
    let prenom = Utilisateur.saisirTexte()
    print("Bonjour \(prenom)")
}

func exercice2() {
    let note1:Double, note2:Double, note3:Double
    print("Entrez la note 1 : ")
    note1 = Utilisateur.saisirReel()
    
    print("Entrez la note 2 : ")
    note2 = Utilisateur.saisirReel()
    
    print("Entrez la note 3 : ")
    note3 = Utilisateur.saisirReel()
    
    let moyenne = (note1 + note2 + note3) / 3
    print("Moyenne : \(moyenne)")
}

func exercice3() {
    print("Base du triangle :")
    let base = Utilisateur.saisirReel()
    
    print("Hauteur du triangle : ")
    let hauteur = Utilisateur.saisirReel()
    
    print("L'aire du triangle vaut \(base * hauteur / 2)")
}

func exercice4() {
    let PI = 3.14
    print("Rayon du cercle : ")
    let rayon = Utilisateur.saisirReel()
    print("L'aire du cercle vaut \(PI * pow(rayon, 2))")
}


func carre(taille:Int)  {
    if taille > 0 {
        for ligne in 0..<taille {
            for colonne in 0..<taille {
                if ligne == 0 || ligne == taille - 1
                    || colonne == 0 || colonne == taille - 1
                {
                    print("* ", terminator:"")
                } else {
                    print("  ", terminator:"")
                }
            }
            print("")
        }
    } else {
        print("Je ne sais pas dessiner un carré de taille \(taille)")
    }
}

func exercice5() {
    print("Taille du carré : ")
    carre(taille: Utilisateur.saisirEntier())
}

func exercice6() {
    var somme:Double = 0
    var nbNotes:Int = 0
    var note:Double = 0
    let moyenne:Double
    
    repeat {
        print("Saisir la note \(nbNotes + 1) (ou -1 pour arrêter) : ")
        note = Utilisateur.saisirReel()
        if note >= 0 {
            somme = somme + note
            nbNotes = nbNotes + 1
        }
    } while note >= 0
    
    moyenne = somme / Double(nbNotes)
    print("Moyenne \(moyenne)")
    
}

func exercice7()  {
    print("Entrez un chiffre entier positif : ")
    let n = Utilisateur.saisirEntier()
    var factorielle = 1
    if n > 0 {
        for compteur in 1...n {
            factorielle = factorielle * compteur
        }
    }
    if n >= 0 {
        print("Factorielle de \(n) : \(factorielle)")
    }
    
    
    
}

func exercice8() {
    let nbMystere = Math.nombreAleatoire(comprisEntre: 1, et: 100)
    var saisieUtilisateur:Int = 0
    var nbTentatives = 0
    
    repeat {
        print("Quel est le nombre mystère ? ")
        saisieUtilisateur = Utilisateur.saisirEntier()
        nbTentatives += 1
        
        if saisieUtilisateur < nbMystere {
            print("C'est plus")
        } else if saisieUtilisateur > nbMystere {
            print("C'est moins")
        }
    } while saisieUtilisateur != nbMystere
    
    print("Bravo vous avez trouvé en \(nbTentatives) tentative\(nbTentatives > 1 ? "s" : "" )")
}

func exercice9() {
    var nbAllumettes = 20
    var saisieUtilisateur:Int
    var joueurEnCours = 1
    
    repeat {
        print("Il reste \(nbAllumettes) allumette(s)")
        //choix nb allumettes pour saisie
        repeat {
            print("Joueur \(joueurEnCours) : Combien d'allumette voulez-vous retirer ? ")
            saisieUtilisateur = Utilisateur.saisirEntier()
        } while saisieUtilisateur < 1 || saisieUtilisateur > 3 || saisieUtilisateur > nbAllumettes
        
        //retirer nb allumettes du stock total
        nbAllumettes = nbAllumettes - saisieUtilisateur
        
        //préparer le tour du prochain joueur
        if joueurEnCours == 1 {
            joueurEnCours = 2
        } else {
            joueurEnCours = 1
        }
    } while nbAllumettes > 0
    
    //le dernier joueur a perdu
    //le prochain jour a gagné
    print("Le joueur \(joueurEnCours) a gagné la partie")
}



exercice9()



/*
 for i in 0...100 {
 print(Math.nombreAleatoire(comprisEntre: 1, et: 100))
 }
 
 let texte:String
 texte = Utilisateur.saisirTexte()
 print("Hello, World!")
 
 let age:Int
 age = Utilisateur.saisirEntier()
 print("Age : \(age)")
 
 let note:Double
 note = Utilisateur.saisirReel()
 print("Note : \(note)")
 */


