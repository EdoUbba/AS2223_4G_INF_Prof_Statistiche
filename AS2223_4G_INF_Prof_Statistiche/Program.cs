using AS2223_4G_INF_Prof_Statistiche;

// Note per lo sviluppo :
// - non cambiare cioò che è stato fornito della classe, aggiungere il codice e aggiungere gli attributi/proprietà/metodi necessari
// - attenzione alla visibilità che deve essere limitata a solo ciò che è strettamente necessario
// - attenzione alla convenzione dei nomi (PascalCase e camelCase)
// - non cambiare il main

// Griglia Valutazione
// 2 voto di partenza
// 2 scrittura del codice, organizzazione della classe e rispetto delle convenzioni
// 1 AddValue(int)
// 1 AddValue(int, double)
// 1 ClearData()
// 1 MediaAritmetica() 
// 2 MediaPonderata()

// note specifiche dell'esercizio
// - non usare array
// - sviluppare il codice seguendo le indicazioni :
//     a) DRY (Don't repeat yourself) : non deve esserci codice ripetuto
//     b) KISS (Keep it simple, stupid!) : il codice deve esere semplice e lineare
//     c) Separation of concerns : ogni oggetto deve fare solo quello che è giusto e necessario che faccia
// - Consegnare lo zip su classroom senza obj/exe con nome AS2223_4G_INF_CognomeNome_Statistiche.zip (-1)
// - Consegnare il nome del repository pubblico github del progetto con almeno 5 commit intercalati nel tempo


Console.WriteLine("Prof; 4G INF; AS 22/23 07/11/22; Gestione statistiche");

Statistiche s = new Statistiche();

// inserisci valori senza peso
s.AddValue(15);
s.AddValue(6);
s.AddValue(7);
s.AddValue(18);
s.AddValue(9);
s.AddValue(100);
s.AddValue(114);
s.AddValue(121);

Console.WriteLine($"La media aritmetica è {s.MediaAritmetica():0.##}");
Console.WriteLine("*** il risultato deve essere 48.75");
Console.WriteLine();

Console.WriteLine($"Il numero di elementi inseriti è {s.CountValue()}");
Console.WriteLine("*** il risultato deve essere 8");
Console.WriteLine();

// azzera i dati inseriti
s.ClearValue();

// inserisci valore con peso
s.AddValue(8,0.5);
s.AddValue(6, 1);
s.AddValue(8, 1);
s.AddValue(7, 0.25);
s.AddValue(9, 1);

Console.WriteLine($"La media ponderata è {s.MediaPonderata():0.##}");
Console.WriteLine("*** il risultato deve essere 7,67");
Console.WriteLine();

Console.WriteLine($"Il numero di elementi inseriti è {s.CountValue()}");
Console.WriteLine("*** il risultato deve essere 5");
Console.WriteLine();

Console.WriteLine("Elaborazione terminata.");