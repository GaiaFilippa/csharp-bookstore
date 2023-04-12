/* BONUS:
 * Richiedi informazioni del libro direttamente all'utente

- Titolo
- Autore
- ISBN
- Numero pagine
- Peso del libro
- Larghezza, Altezza e Profondità del libro
- Valutazione media
- Numero di recensioni
- se è disponibile in versione Kindle
- se la copertina flessibile è disponibile

Stampa poi in console l'informazione ottenuta dall'utente.
*/

Console.WriteLine("Inserisci le informazioni del libro che vorresti aquistare su Amazon!");
Console.WriteLine();

Console.Write("Inserisci il titolo del libro: ");
string imputTitoloLibro = (Console.ReadLine());

Console.Write("Inserisci l'autore del libro: ");
string imputAutoreLibro = (Console.ReadLine());

Console.Write("Inserisci l'ISBN: ");
long imputISBN = int.Parse(Console.ReadLine());

Console.Write("Inserisci il numero delle pagine: ");
int imputNumeroPagine = int.Parse(Console.ReadLine());

Console.Write("Inserisci il peso del libro in grammi: ");
int imputPesoLibro = int.Parse(Console.ReadLine());

Console.Write("Inserisci la larghezza del libro: ");
float imputLarghezzaLibro = float.Parse(Console.ReadLine());

Console.Write("Inserisci l'altezza del libro: ");
float imputAltezzaLibro = float.Parse(Console.ReadLine());

Console.Write("Inserisci la profondità del libro: ");
float imputProfonditàLibro = float.Parse(Console.ReadLine());

Console.Write("Inserisci la valutazione media del libro: ");
float imputValutazioneMediaLibro = float.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di recensioni del libro: ");
int imputNumeroRecensioni = int.Parse(Console.ReadLine());

Console.Write("Il libro è disponibile in versione Kindle? ");
string imputDisponibileVersioneKindle = (Console.ReadLine());

Console.Write("Il libro è disponibile con la copertina flessibile? ");
string imputDisponibileCopertinaFlessibile = (Console.ReadLine());

// Stampa ordinatamente in console

Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Il libro che presento oggi è " + imputTitoloLibro + " di " + imputAutoreLibro);
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Informazioni generiche:");
Console.WriteLine();
Console.WriteLine("ISBN: " + imputISBN);
Console.WriteLine("Numero Pagine: " + imputNumeroPagine);
Console.WriteLine("Peso del libro: " + imputPesoLibro + "g");
Console.WriteLine("Dimensioni del libro: " + imputLarghezzaLibro + "cm" + " x " + imputAltezzaLibro + "cm" + " x " + imputProfonditàLibro + "cm");
Console.WriteLine();
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine();
Console.WriteLine("Numero recensioni: " + imputNumeroRecensioni);
Console.WriteLine("Valutazione media: " + imputValutazioneMediaLibro + "/5 stelline");
Console.WriteLine("Kindle disponibile: " + imputDisponibileVersioneKindle);
Console.WriteLine("Copertina flessibile disponibile: " + imputDisponibileCopertinaFlessibile);
Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");