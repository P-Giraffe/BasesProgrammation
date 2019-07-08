import NePasToucher.readInt

fun main(args: Array<String>) {
    ex4()
}

fun ex1() {
    pythagore(2.2,5.0)
}

fun pythagore(coteA:Double, coteB:Double) {
    val carrehyp = coteA*coteA + coteB*coteB
    val hyp = Math.sqrt(carrehyp)
    println("L'hypothénuse mesure ${hyp}")
}

fun ex2() {
    demandeValeurs(7)
    demandeValeurs(4)
    demandeValeurs(2)
}

fun demandeValeurs(diviseur:Int) {
    var nbValeurs = 0
    var nbDivisibles = 0

    do {
        print("Entrez une valeur (ou 0 pour arrêter) : ")
        val valeurSaisie = readInt()
        if (valeurSaisie != 0) {
            if (valeurSaisie % diviseur == 0) {
                nbDivisibles += 1
            }
            nbValeurs += 1
        }
    } while (valeurSaisie != 0)

    println("Vous avez saisi ${nbValeurs} valeur${if (nbValeurs > 1) "s" else ""} dont ${nbDivisibles} divisible(s) par " + diviseur)
}

fun ex3() {
    multiplication(40)
}

fun multiplication(dimension: Int) {
    val nbChiffresMax = Math.ceil(Math.log10((dimension * dimension).toDouble() + 1.0)).toInt()
    for (ligne in 1..dimension) {
        for (colonne in 1..dimension) {
            print("${ligne*colonne}".padStart(nbChiffresMax + 1))
        }
        println()
    }
}

fun ex4() {
    println("0 == ${sommeProcheV2(0)}")
    println("10 == ${sommeProcheV2(10)}")
    println("10 == ${sommeProcheV2(11)}")
    println("15 == ${sommeProcheV2(14)}")
    println("15 == ${sommeProcheV2(18)}")
}

fun sommeProche(cible: Int): Int {
    var borneSup = 0
    var borneInf:Int
    var passage = 0
    do {
        passage += 1
        borneInf = borneSup
        borneSup += passage
    } while(borneSup<cible)
    if (borneSup==cible || cible-borneInf>borneSup-cible) {
        return borneSup
    }else {
        return borneInf
    }
}

fun sommeProcheV2(cible:Int) : Int{
    var sumNb = 0
    var compteur = 0
    do {
        compteur++
        sumNb += compteur
    } while (sumNb < cible)

    if (Math.abs(sumNb - compteur - cible) <= sumNb - cible) {
        sumNb -= compteur
    }

    println("La somme la plus proche est ${sumNb}")
    return sumNb
}

