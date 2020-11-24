(Editor: https://stackedit.io/)

Verfahren und Werkzeuge moderner Softwareentwicklug
Wintersemester 20/21
Einsendeaufgabe CCD und GitHub

## Aufgabe CCD

 - Erstellen eines CDD Cheat Sheet 
 - Erstellen eines (unsauberen) Programms und Umwandlung in CleanCode
 - Begründen, warum dies Clean Code ist
 
## Aufgabe GitHub
 - Beschäftigen Sie sich mit GitHub und den Möglichkeiten, am besten in Vebindung mit einem Konkreten Projekt
 - Mit dem Repro https://github.com/edlich/education einen PullRequest erstellen
 
## Lösung

[CDD Cheat Sheet ](https://github.com/ChristianKitte/TicTocToe/blob/master/CCD%20Cheat%20Sheet.pdf)

#### Programm:
Als Programm dient das bekannte Programm TikTakToe in einer Konsolenversion ohne KI-Spieler. Die Bedienung ist daher sehr einfach. Spieler 1 beginnt mit der Eingabe eines Feldes. Dann ist der zweite Spieler an der Reihe und macht seine Eingabe. Fehlerhafte Abgaben werden abgelehnt. Wenn ein Gewinner drei Felder vertikal, horizontal oder diagonal nebeninander belegt, so hat der Spieler gewonnen.

Der Anfangszustand beinhaltete nur eine "schlechte", aber lauffähige Programmversion. Diese wurde und wird aktuell stetig verbessert (siehe Historie der Commits), so dass er zunehmend zu einem CleanCode wird.

#### Aktuell ist die Überarbeitung des Codes im Gange, aber dank Corona noch nicht ganz abgeschlossen :(

- Alle Variablen haben sprechende Namen und geben so Ihre Bedeutung an
- Alle Methoden haben sprechende Namen und geben so die ausgeführte Aktion deutlich an
- Die Methoden sind zu einem großen Teil bereits kommentiert

- Innerhalb der Funktionen erfolgt keine Kommentierung. Diese ist nicht nötig, da die Methoden klein und Namen sprechend sind
- Alle Methoden sind kurz gehalten

- Der Code folgt zum größten Teil der offizielen CheckStyle Eppfehlung für C#
- Der Code ist überall gleichartig formatiert in Anlehnung an die offizielle Empfehlung für c#

- Die reine Spielefunktion ist in eine externe Assembly (TicTocLib) mit einem eigenen Namespace ausgelagert worden. So kann diese auch für andere Oberflächen etc. verwendet werden. Es ist also physisch und logisch getrennt.
- Das Hauptprogramm verfügt über einen eigenen Namespace und nutzt TicTocLib.
- Die Einstiegsroutine main im Hauptprogramm (TikTokToe) ist bis auf das nötigste leer
- Über eine Klasse Spiel erfolgt die Steuerung des Spiel auf Konsolenbasis (siehe TikTakToe)
- Klassen und andere Typen werden in jeweils eigenen Dateien mit dem Namen des Typs abgelegt. Das erhöht die Übersichtlichkeit besonders in Verbindung mit der Nutzung von sprechenden Namen.

- Bereits in einigen Fällen (noch nicht fertig) wird statt Klassen nur eine minimale Schnittstelle verwendet
- Spielzug oder Spielfeld werden als semantische Werteobjekte übergeben statt als String (siehe TikTokLib).
- Feldnamen (es gibt nur neun) sind als Enumeration verfügbar statt als Texte (siehe Ordner Enumerationen)
- Spieler (es gibt nur zwei) sind als Enumeration verfügbar statt als Texte (siehe Ordner Enumerationen) 

Klassen haben nach Möglichkeit nur eine Aufgabe, Sie werden als minimale Schnittstelle übergeben



