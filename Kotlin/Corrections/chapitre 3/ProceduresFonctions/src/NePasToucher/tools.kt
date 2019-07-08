package NePasToucher

fun readString() : String {
	var readLine:String?
	do {
		readLine = kotlin.io.readLine()
		if (readLine == null) {
			println("Veuillez entrer une valeur")
		}
	} while (readLine == null)
	return readLine
}

fun readInt() : Int {
	var readInt:Int? = null
	do {
		val readLine = readString()
		try {
			readInt = readLine.toInt()
		} catch (e: Exception) {
			println("Veuillez entrer une valeur entière")
		}
	} while (readInt == null)

	return readInt
}

fun readDouble() : Double {
	var readDouble:Double? = null
	do {
		val readLine = readString()
		try {
			readDouble = readLine.toDouble()
		} catch (e: Exception) {
			println("Veuillez entrer une valeur réelle")
		}
	} while (readDouble == null)

	return readDouble
}
