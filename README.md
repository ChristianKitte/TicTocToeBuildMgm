(Editor: https://stackedit.io/)

Verfahren und Werkzeuge moderner Softwareentwicklug
Wintersemester 20/21
Einsendeaufgabe CCD und GitHub

## Aufgabe

 - Erstellen eines CDD Cheat Sheet 
 - Erstellen eines (unsauberen) Programms und Umwandlung in CleanCode
 - Begründen, warum dies Clean Code ist

## Lösung

[CDD Cheat Sheet ](https://github.com/ChristianKitte/TicTocToe/blob/master/CCD%20Cheat%20Sheet.pdf)

Aktuell ist die Überarbeitung des Codes im Gange, aber dank Corona noch nicht ganz abgeschlossen :(

Alle Variablen haben sprechende Namen und geben so Ihre Bedeutung an
Alle Mehtoden haben sprechende NAmen und geben so die ausgeführte Aktion deutlich an
Die Methoden sind zu einem großen Teil bereits kommentiert

Innerhalb der Funktionen erfolgt keine Kommentierung
Alle Methoden sind kurz gehalten

Der Code folgt zum größten Teil der offizielen CheckStyle Eppfehlung für C#
Der Code ist überall gleichartig formatiert in Anlehnung an die offizielle Empfehlung für c#

Die reine Spielefunktion ist in eine externe Assembly (TicTocLib) ausgelagert worden. So kann diese auch für andere Oberflächen etc. verwendet werden.
Die Einstiegsroutine im Hauptprogramm (TikTokToe) ist bis auf das nötigste leer
Über eine Klasse Spiel erfolgt die Steuerung des Spiel auf Konsolenbasis

Bereits in einigen Fällen (noch nicht fertig) wird statt Klassen nur eine minimale Schnittstelle verwendet
Spielzug oder Feld werden als semantische Werteobjekte übergeben statt als String.
Feldnamen (es gibt nur neun) sind als Enumeration verfügbar statt als Texte
Spieler (es gibt nur zwei) sin dals Enumeration verfügbar statt als Texte 

Klassen haben nach Möglichkeit nur eine Aufgabe, Sie werden als minimale Schnittstelle übergeben



