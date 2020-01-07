import NePasToucher.readDouble
import NePasToucher.readInt
import NePasToucher.readString

fun main(args: Array<String>) {
    var f4:Int = factorielle(4)
    dessinerCarre(f4, '.')
    dessinerCarre(5, '+')
    dessinerCarre(factorielle(3))
}

fun dessinerCarre(size:Int, character:Char = '*') {
    for (ligne in 1..size) {
        for (colonne in 1..size) {
            if (ligne == 1 || ligne == size || colonne == 1 || colonne == size) {
                print(character + " ")
            } else {
                print("  ")
            }
        }
        println()
    }
    println()
}

fun factorielle(n:Int) : Int {
    if (n <= 0) {
        return 1
    }
    var factorielle:Int = 1

    for (compteur in 1..n) {
        factorielle = factorielle * compteur
        println("x ${compteur} = " + factorielle)
    }

    return factorielle
}

