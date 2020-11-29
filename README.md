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

## Lösung GitHub (zum 29.11.)

- Seit der Programmierung des TicTocSpiels habe ich mich entsprechend der Aufgabe mit GitHub wieder mehr beschäftigt. Die geforderten methoden wie push, pull, add, commit, diff und andere habe ich heirbei angewendet. Dies Repository sollte heirfür als Beleg dienen. 

- Am 29.11.2020 habe ich edlich/education geforkt, geändert und anschließend ein PullRequest gemacht, der auch angenommen wurde (https://github.com/edlich/education/blob/master/Plaetzchen-Folder/EinfacherChriststollen.txt , https://github.com/edlich/education/pull/260 , Christian Kitte, ). Ich hoffe, die Angaben reichen zum wiederfinden.

-  Zudem habe ich mich im Repository TicTocToe mal näher mit den Möglichkeiten Issues, Wiki, Erstellen eines Branches im eigenen Projekt und Übernahme mit Pull Request beschäftigt.

## Lösung CCD (zum 22.11. und nicht ganz pünktlich abgegeben)

[CDD Cheat Sheet ](https://github.com/ChristianKitte/TicTocToe/blob/master/CCD%20Cheat%20Sheet.pdf)

#### Programm:
Als Programm dient das bekannte Programm TikTakToe in einer Konsolenversion ohne KI-Spieler. Die Bedienung ist daher sehr einfach. Spieler 1 beginnt mit der Eingabe eines Feldes. Dann ist der zweite Spieler an der Reihe und macht seine Eingabe. Fehlerhafte Abgaben werden abgelehnt. Wenn ein Gewinner drei Felder vertikal, horizontal oder diagonal nebeninander belegt, so hat der Spieler gewonnen.

Der Anfangszustand beinhaltete nur eine "schlechte", aber lauffähige Programmversion. Diese wurde und wird aktuell stetig verbessert (siehe Historie der Commits), so dass er zunehmend zu einem CleanCode wird.

#### Aktuell ist die Überarbeitung des Codes im Gange, aber dank Corona noch nicht ganz abgeschlossen :(

- Der Code wird auf GitHub gehostet (Praktik: Ein Versionskontrollsystem einsetzen)

- Das gesamte Klassenmodell lehnt sich von der Namengebung an ein konkretes Spiel an (Spielfeld, Spieler, Spielzug) und wirkt so selbst ohne Kommentierung in sich konsistent und erklärend.

- Die Methoden und Klassen enthalten das, was drauf steht (z.B. Spielzug stellt einen Spielzug dar). (Principle of Least Astonishment)

- Es wurden nur die für das Spiel und die Ausgabe notwendigen Funktionalitäten implementiert (KISS, YAGNI).

- Alle Variablen und Methoden haben sprechende Namen und geben so Ihre Bedeutung bzw. Funktion klar an (selbsterklärend).

- Die Methoden sind in der Regel im Standard von C# und Visual Studio kommentiert. Innerhalb der Funktionen erfolgt in der Regel keine Kommentierung. Hierfür wurden die Methoden kurz gehalten und darauf geachtet, dass sich der Code selbst erklärt.

- Der Code folgt in der Regel der offizielen CheckStyle Eppfehlung für C# und ist überall in Anlehnung an die offizielle Empfehlung für C# gleich formatiert.

- Die auch für eine Windowsanwendung des Spieles verwendbaren Funktionen sind in einer externe Assembly (TicTocLib) mit einem eigenen Namespace ausgelagert worden. So kann diese auch für andere Oberflächen etc. verwendet werden. Es ist also physisch und logisch getrennt. (SOC)

- Im Hauptprogramm ist der Programmeinstieg (Main) sauber vom Spiel (Application) gekapselt. Helferklassen für die Konsole sind in einen eigenen Ordner (Konsolenhelfer) mit eigenen Namespace ausgelagert. Hierdurch ist Einstiegsroutine main im Hauptprogramm (TikTokToe) bis auf das nötigste leer. (SOC)

- Die Spiellogik selbst ist in einer Klasse (Spiel) des Projekts TicTocToe gekapselt. (SOC)

- Klassen und Interfaces werden in jeweils eigenen Dateien mit dem Namen des Typs abgelegt. Das erhöht die Übersichtlichkeit besonders in Verbindung mit der Nutzung von sprechenden Namen.

- Es werden Interfaces (hier nur 1) verwendet, welche nicht alle öffentlichen Methoden einer Klasse offenlegen, sondern nur genau die benötigte Methode: Interface ISpielerZuFeldZuordnung in TicTocLib (wird hier von Spielfeld implementiert). (ISP, Information Hiding Principle)

- Spielzug wird beispielsweise als Klasse statt als einfacher Wert übergeben und erhält hierdurch eine Semantik (siehe TikTokLib).

- Feldnamen (es gibt nur neun) sind als Enumeration verfügbar statt als Texte und erhalten so eine Semantik (siehe Ordner Enumerationen)

- Spieler (es gibt nur zwei) sind als Enumeration verfügbar statt als Texte und erhalten so eine Semantik (siehe Ordner Enumerationen) 

- Alle Werte werden in einer zentralen Klasse Konsolenwerte (in Konsolenhelfer) gehalten, um magische Nummern zu umgehen und einen zentralen Platz für die Konfiguration zu haben und diese zu kapseln. Der eigentlich bevorzugte Weg über eine Settingsdatei führte interessanterweise zu einem Problem, wahrscheinlich in Zusammenhang mit den Zielframework .NET Core 5.

- Um die Kopplung der Klassen zu verringern, verwende ich - Premiere - einen DI Container (Autofac, https://autofac.org/) und bin entzückt. (DIP)

- In der Regel werden benötigte Objekte als Interfaces übergeben, statt dass sie selbst erzeugt werden (siehe Konstruktoren der Klasse Spiel (hier zusätzlich mit DIC) oder Spielzug). (DIP, )

- Ein Test mit Designite zeigte mir ein zu meißt gutes Ergebnis. Einige wenige Schlechte Werte konnte auf den Einsatz der zentralen Klasse Konsolenwerte trotz DIC zurück geführt werden. In drei Methoden wird eine erhöhte zyklische Komplexität angezeigt, welches durch mehrstufige If bzw. Case Anweisungen entstehen. Hier bin ich noch am überlegen.




