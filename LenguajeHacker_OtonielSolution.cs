/*
 * Escribe un programa que reciba un texto y transforme lenguaje natural a
 * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
 *  se caracteriza por sustituir caracteres alfanuméricos.
 * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
 *   con el alfabeto y los números en "leet".
 *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
 */
 
Dictionary<String, String> myDiccionary  = new Dictionary<String,String>{

				{"A", "4"},
				{"B", "I3"},
				{"C", "["},
				{"D", ")"},
				{"E", "3"},
				{"F", "|="},
				{"G", "&"},
				{"H", "#"},
				{"I", "1"},
				{"J", ",_|"},
				{"K", ">|"},
				{"L", "1"},
				{"M", @"/\/\"},
				{"N", "^/"},
				//He añadido la ñ porque puede ser curioso el resultado sin esta letra :D
				{"Ñ", "Na4" },
				{"O", "0"},
				{"P", "|*"},
				{"Q", "(_,)"},
				{"R", "I2"},
				{"S", "5"},
				{"T", "7"},
				{"U", "(_)"},
				{"V", @"\/"},
				{"W", @"\/\/"},
				{"X", "><"},
				{"Y", "j"},
				{"Z", "2"}
};

System.Console.WriteLine("iNTRODUCE LA PALABRA QUE DESEAS ENCRIPTAR");

String cadenaTexto = Console.ReadLine();

if(cadenaTexto == null){

	System.Console.WriteLine("La caden no puede estar vacia");
}
String resultado = "";
for (int i = 0; i < cadenaTexto.Length; i++)
{
	foreach(var iterador in myDiccionary ){

		if (iterador.Key == cadenaTexto[i].ToString().ToUpper())
		{
			resultado += iterador.Key;
			
		}
	}
}

System.Console.WriteLine("Esta es la traduccion correcta : {0}",resultado);