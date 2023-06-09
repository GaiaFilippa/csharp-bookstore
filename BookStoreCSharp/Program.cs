﻿/*Inserisci in maniera hardcoded tutte le informazioni trovate su Amazon di un libro e stamparne una sintesi
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

Individua il tipo corretto.
Stampa poi in console l'informazione contenuta nella variabile.
*/

using System;

string titolo = "Clean Code";
string autore = "Robert C. Martin";
long ISBN = 9780132350884;
int numeroPagine = 431;
int pesoDelLibro = 800;
float larghezzaLibro = 17.78f;
float altezzaLibro = 23.37f;
float profonditàLibro = 2.79f;
float valutazioneMediaLibro = 4.7f;
int numeroDiRecensioni = 5413;
string disponibileInVersioneKindle = "Sì";
float prezzoVersioneKindle = 15.28f;
string disponibileCopertinaFlessibile = "Sì";
float prezzoCopertinaFlessibile = 28.27f;

Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Il libro presentato oggi è " + titolo + " di " + autore);
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Informazioni generiche:");
Console.WriteLine();
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero Pagine: " + numeroPagine);
Console.WriteLine("Peso del libro: " + pesoDelLibro + "g");
Console.WriteLine("Dimensioni del libro: " + larghezzaLibro + "cm" + " x " + altezzaLibro + "cm" + " x " + profonditàLibro + "cm");
Console.WriteLine();
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine();
Console.WriteLine("Numero recensioni: " + numeroDiRecensioni);
Console.WriteLine("Valutazione media: " + valutazioneMediaLibro + "/5 stelline");
Console.WriteLine("Kindle disponibile: " + disponibileInVersioneKindle + ", al prezzo di " + prezzoVersioneKindle + " euro");
Console.WriteLine("Copertina flessibile disponibile: " + disponibileCopertinaFlessibile + ", al prezzo di " + prezzoCopertinaFlessibile + " euro");
Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");