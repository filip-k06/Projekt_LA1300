# Projekt-Dokumentation

Kritzner, Bytyqi, JW, Sacher, Tuma

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 27.11-28.11.22 | 0.0.1   | Schritte 1-3 ausgefüllt. |
| 29.11.22 | 0.0.2 | grafische Oberfläche fertig gstellt. |


## 1 Informieren

### 1.1 Ihr Projekt

Wir erstellen ein Spiel wie Hangman, bei dem man ein Wort, mit begrenzter Anzahl Versuchen, erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1 | muss | funktional | Als ein User möchte ich sehen wie viele Versuche ich noch habe, damit ich weiss wie oft ich noch raten kann. |
| 2 | muss | funktional | Als ein User möchte ich wissen wie lange das Wort ist, damit ich besser abschätzen kann, welche Buchstaben darin vorkommen. |
| 3 | muss | funktional | Als ein User möchte ich sehen, welche Buchstaben ich schon verwendet habe, damit ich keinen Buchstaben doppelt wähle. |
| 4 | muss | funktional | Als ein User möchte ich, dass es mindestens 20 verschiedene Wörter gibt zum Erraten, damit es eine grosse Vielfalt hat. |
| 5 | muss | funktional | Als ein User möchte ich, dass alle Wörter, die ich erraten habe, nicht mehr drankommen, damit es keine doppelten Wörter hat. |
| 6 | muss | funktional | Als ein User möchte ich mich nach einem erratenen Wort entscheiden können, ob ich weiterspielen will, damit ich das Spiel beenden kann. |
| 7 | muss | funktional | Als ein User möchte ich nach einem beendeten Spiel sehen wie viele Wörter ich richtig erraten habe, damit ich weiss, ob ich besser war als vorher |
| 8 | kann | Qualität | Als ein User möchte ich nach einem beendeten Spiel einen Highscore sehen. |
| 9 | kann | Qualität | Als ein User möchte ich eine visuelle Darstellung sehen, damit ich weiss wie viele Versuche ich gebraucht habe. |
| 10 | kann | funktional | Als User möchte ich selber gewählte/geschriebene Wörter in das Programm schreiben, damit die Wörter in eine Datenbank speichern.|
| 11 | kann | funktional | Als User möchte ich Wörter in der Datenbank auswählen, damit es mehr Spass macht.| 
| 12 | muss | Qualität | Als User möchte ich Schwierigkeitsstufen bevor das Spiel startet, damit es schwerer werden kann. |
| 13 | kann | funktional | Als User möchte ich einen Timer haben, damit ich sehe wie lange ich pro wort gebraucht habe.|
| 14 | kann | Qualität | Als User möchte ich den Timer einstellen, damit ich mehr oder weniger Zeit habe. |
| 15 | kann | funktional | Als User möchte ich eine Zeitbegrenzung haben, damit ich unter Zeitdruck stehe. |
| 16 | muss | Qualität | Als User möchte ich lustige Soundeffekt wenn ich ein Buchstabe richtig oder falsch ist, damit es mehr spassig ist. |
| 17 | muss | funktional| Als User möchte ich einen Multiplayer Modus haben, damit ich mit freunden spielen kann. |
| 18 | muss | funktional| Als User möchte ich im Main Menu den Multiplayer Modus auswählen können, damit ich den Multiplayer Modus benutzen kann.
| 19| muss | funktional| Als User möchte ich das beim Multiplayer Modus Spieler eins auswählen kann welche Rolle er will sein, damit mann nicht immer etwas anderes muss sein. |
| 20| kann | Qualität | Als User möchte ich einstellen im Multiplayer Modus wie viele Runden es gibt, damit man schnellere oder längere Partien haben kann.|
| 21| kann | Qualität | Als User möchte ich im Multiplayer Modus einen Timer einstellen können, damit mein gegner keine Zeitverschwendet.|
| 22 | muss | Qualität | Als Programmierer möchte ich, dass das Programm schliesst wenn man Raus tabt, damit mann nicht Wörter googeln kann. |
| 23 | muss | Qualität | Als Programmierer möchte ich, dass das Programm ausnahmebehandlungen selbst auflösen kann, damit es kein crash gibt. |
| 24 | muss | Qualität | Als User möchte ich, im Programm mit Buttons Navigieren können, damit wenn ich keine programmische Kenntnisse habe, dass es einfacher ist. |
| 25 | kann | Rahmen | Als Programmierer möchte ich Easter Eggs im Programm haben, damit die User die suchen können.  |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1   |Programm wird gestrartet | Buchstabe | Wenn falsch wird das Diagramm erweitert |
|  2   |Programm wird gestartet  | Zahl | Fehlermeldung |
|  3   |Programm wird gestartet  | Mausclick auf 1   |  Leichter Modus   |
|  4   |Programm wird gestartet  | Mausclick auf 2   |  mittlerer Modus   |
|  5   |Programm wird gestartet  | Mausclick auf 3   |  schwerer Modus  |
|  6   |Programm wird gestartet  | Buchstabe   |  Wenn der Buchstabe falsch ist und der User keine Versuche mehr hat, wird das Spiel beendet.   |
|  7   | Spiel wurde verloren  |  |   Willst du nochmal spielen?  |
|  8   |Programm wird gestartet  | Tab |   Programm wird geschlossen   |
|  9   |Programm wird gestartet  | Wörter werden eingelesen   |  Wörter werden in einer Liste gespeichert    |
|  10  |Programm wird gestartet  | Buchstabe |  Wenn alle Buchstaben eines Wortes richtig erraten wurden, wird das Wort nicht mehr vorkommen. (keine Duplikate) |
|  11  |Programm wird gestartet  | Buchstabe |  Wenn der Buchstabe falsch ist -1 Versuch   |
|  12  |Programm wird gestartet  | Buchstabe |  Wenn der Buchstabe richtig ist -> Pluspunkte    |
|  13  |Programm wird gestartet  | Buchstabe (schwerer Modus) | Wenn der Buchstabe falsch ist -> -1 Versuch + Minuspunkte   |
|  14  |Programm wird gestartet  | Buchstabe | Wenn richtig wird das Wort mit dem Buchstaben erweitert |
|  15  |Programm wird gestartet  | windowstaste | Progamm wird geschlossen  |
|  16  |Programm wird gestartet  | ALT+TAB | Spiel wird beendet |
|  17  |Programm wird gestartet  | | |
|  18  |Programm wird gestartet  | | |
|  19  |Programm wird gestartet  | | |
|  20  |Programm wird gestartet  | | |
|  21  |Programm wird gestartet  | | |
|  22  |Programm wird gestartet  | | |
|  23  |Programm wird gestartet  | | |
|  24  |Programm wird gestartet  | | |
|  25  |Programm wird gestartet  | | |

### 1.4 Diagramme

![Hangman](https://user-images.githubusercontent.com/110892683/204347838-8f3922c5-1713-4f36-b9be-e3f671a0830b.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       | JW  | Die Versuche und Raten angezeigt werden. | 25 min |
| 1.B  |       | JW  | Einen Counter für Anzahl Versuche und Raten soll addieren und subtraktieren.  | 55 min |
| 2.A  |       | JW  | Das Wort wird gezählt.| 30min |
| 2.B  |       | JW  | Die Anzahl Buchstaben im Wort sollen im Programm angezeigt werden. | 60min |
| 3.A  |       | JW  | Buchstaben sollen gespeichert werden die schon gewählt wurden. | 90 min |
| 3.B  |       | JW  | Die schon gewählten Buchstaben sollen auf dem Bild schirn angezeigt sein. | 45 min |
| 4.A  |       | Kritzner | Alle Wörter sind in einer Datei gespeichert. | 30min |
| 4.B  |       | Kritzner | Die Wörter werden eingelesen. | 30min |
| 4.C  |       | Kritzner | Nach Zufallsprinzip wird ein Wort zum Erraten gewählt. | 20min |
| 4.D  |       | Kritzner | Nach einer Eingabe eines Buchstabens, soll dieser mit dem gewählten Wort verglichen werden. | 45min |
| 5.A  |       | Kritzner | Wenn ein Wort erraten wird, soll es in einer Liste gespeichert werden. | 15min |
| 5.B  |       | Kritzner | Wenn ein Wort gewählt wird, muss es zuerst mit der Liste verglichen werden. | 30min |
| 5.C  |       | Kritzner | Wenn ein Wort bereits erraten wurde, muss ein neues zufällig generiert werden. | 30min |
| 6.A  |       | Artur | Wenn ein Wort erraten wird, soll das Programm fragen, ob man weiterspielen will. | 30min |
| 6.B  |       | Artur | Wenn ein Wort erraten wird, soll das Programm fragen, ob es das Spiel beenden soll. | 15min |
| 7.A  |       | Artur | Wenn das Spiel beendet wird, soll ein Counter, der zeigt, wie viele Wörter man richtig erraten hat, da stehen| 20min |
| 7.B  |       | Artur | Wenn das Spiel beendet wird, soll es die Punktzahl in einer Liste speichern| 50min |
| 7.C  |       | Artur |Wenn das Spiel beendet wird, soll es mir sagen, ob ich besser als letztes Mal war | 50min |
| 8.A  |       | Artur |Während man spielt, soll es am Schluss die höchste erreichte Punktzahl anzeigen. | 25min |
| 9.A  |       | Artur |Am Schluss des Spiels, soll es anzeigen, wie viele Versuche man gebraucht hat. | 15min |
| 10.A  |       | Artur |Man soll in einem Fenster eigene Wörter eingeben und diese sollen in einer Liste gespeichert werden. | 40min |
| 11.A  |       | Artur |Es soll einen Modus geben, wo man Wörter aus der Liste einzeln auswählen kann. | 120min |
| 12.A  |       | Robin |Man soll am Anfang vom Spiel auswählen können ob man einfache Wörter will. | 40min |
| 12.B  |       | Robin |Man soll am Anfang vom Spiel auswählen können ob man mittlere Wörter will. | 40min |
| 12.C  |       | Robin |Man soll am Anfang vom Spiel auswählen können ob man schwere Wörter will. | 40min |
| 13.A  |       | Robin | Es soll einen Timer geben | 20min |
| 13.B  |       | Robin | Dieser Timer soll jedes Wort einzeln timen. | 35min |
| 14.A  |       | Robin | Man soll eine eigene Zeit einstellen können, wie lange man Zeit für ein Wort hat. | 30min |
| 15.A  |       | Luca | Es soll einen Modus geben, wo man weniger Zeit pro Fehler hat, sodass man unter Druck steht | 20min |
| 16.A  |       | Luca | Das Programm soll einen lustigen Soundeffekt abspielen, wenn ein Buchstabe richtig oder falsch ist.| 20min |
| 17.A  |       | Luca | Man soll mit Freunden in einem Multiplayer-Modus zusammenspielen können. | 15min |
| 18.A  |       | Luca | Es soll eine Auswahl mit Einstellungen für den Multiplayer-Modus. | 200min |
| 19.A  |       | Luca | Man soll im Multiplayer-Modus auswählen können, welche Rolle man hat.| 120min |
| 20.A  |       | Luca | Man soll im Multiplayer-Modus einstellen können, wie viele Runden es gibt, damit man schnellere oder längere Spiele spielen kann. | 150min |
| 21.A  |       | Cedric | Im Multiplayer-Modus soll man auch eine bestimmte Zeit einstellen können. | 40min |
| 22.A  |       | Cedric |Das Spiel soll beendet werden, falls man die Tastenkombination ALT+TAB benutzt, sodass man nicht googlen kann.  | 30min |
| 23.A  |       | Cedric | Das Programm soll Ausnahmebehandlungen selber auflösen, damit es keinen Crash gibt | 90min |
| 24.A  |       | Cedric | Das GUI soll so benutzerfreundlich wie möglich werden, damit es nicht zu kompliziert wird für jemanden, der keine programmische Kenntnisse hat.| 70min |
| 25.A  |       | Cedric | Es soll versteckte Puzzles im Programm geben, die jemandem eine versteckte Einstellung oder andere Art von Belohnung gibt. | 90min |



Total: 

## 3 Entscheiden


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
