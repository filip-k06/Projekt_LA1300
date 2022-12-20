# Projekt-Dokumentation

Kritzner, Bytyqi, JW, Sacher, Tuma

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 27.11-28.11.22 | 0.0.1   | Schritte 1-3 ausgefüllt. |
| 29.11.22 | 0.0.2 | Grafische Oberfläche fertig gestellt. |
| 6.12.22 | 0.0.3 | Präsentation vorbereitet und am Programm weitergearbeitet. |
| 13.12.22 | 0.0.4 | Dokumentation erweitert und probiert möglichst viele Fehler im Programm zu beheben. |


## 1 Informieren

### 1.1 Ihr Projekt

Wir erstellen ein Spiel wie Hangman, bei dem man ein Wort, mit begrenzter Anzahl Versuchen, erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1 | muss | funktional | Als ein User möchte ich sehen wie viele Versuche ich noch habe, damit ich weiss, wie oft ich noch raten kann. |
| 2 | muss | funktional | Als ein User möchte ich wissen wie lange das Wort ist, damit ich besser abschätzen kann, welche Buchstaben darin vorkommen. |
| 3 | muss | funktional | Als ein User möchte ich sehen, welche Buchstaben ich schon verwendet habe, damit ich keinen Buchstaben doppelt wähle. |
| 4 | muss | funktional | Als ein User möchte ich, dass es mindestens 20 verschiedene Wörter gibt zum Erraten, damit es eine grosse Vielfalt hat. |
| 5 | muss | funktional | Als ein User möchte ich, dass alle Wörter, die ich erraten habe, nicht mehr drankommen, damit es keine doppelten Wörter hat. |
| 6 | muss | funktional | Als ein User möchte ich mich nach einem erratenen Wort entscheiden können, ob ich weiterspielen will, damit ich das Spiel beenden kann. |
| 7 | muss | funktional | Als ein User möchte ich nach einem beendeten Spiel sehen wie viele Wörter ich richtig erraten habe, damit ich weiss, ob ich besser war als vorher |
| 8 | kann | Qualität | Als ein User möchte ich nach einem beendeten Spiel einen Highscore sehen. |
| 9 | kann | Qualität | Als ein User möchte ich eine visuelle Darstellung sehen, damit ich weiss, wie viele Versuche ich gebraucht habe. |
| 10 | kann | funktional | Als User möchte ich selber gewählte/geschriebene Wörter in das Programm schreiben, damit die Wörter in eine Datenbank speichern.|
| 11 | kann | funktional | Als User möchte ich Wörter in der Datenbank auswählen, damit es mehr Spass macht.| 
| 12 | muss | Qualität | Als User möchte ich Schwierigkeitsstufen bevor das Spiel startet, damit es schwerer werden kann. |
| 13 | kann | funktional | Als User möchte ich einen Timer haben, damit ich sehe wie lange ich pro Wort gebraucht habe.|
| 14 | kann | Qualität | Als User möchte ich den Timer einstellen, damit ich mehr oder weniger Zeit habe. |
| 15 | kann | funktional | Als User möchte ich eine Zeitbegrenzung haben, damit ich unter Zeitdruck stehe. |
| 16 | muss | Qualität | Als User möchte ich lustige Soundeffekt, wenn ich ein Buchstabe richtig oder falsch ist, damit es spassiger ist. |
| 17 | muss | funktional| Als User möchte ich einen Multiplayer Modus haben, damit ich mit Freunden spielen kann. |
| 18 | muss | funktional| Als User möchte ich im Main Menu den Multiplayer Modus auswählen können, damit ich den Multiplayer Modus benutzen kann.
| 19| muss | funktional| Als User möchte ich das beim Multiplayer Modus Spieler eins auswählen kann welche Rolle er will sein, damit man nicht immer etwas anderes muss sein. |
| 20| kann | Qualität | Als User möchte ich einstellen im Multiplayer Modus wie viele Runden es gibt, damit man schnellere oder längere Partien haben kann.|
| 21| kann | Qualität | Als User möchte ich im Multiplayer Modus einen Timer einstellen können, damit mein Gegner keine Zeit verschwendet. |
| 22 | muss | Qualität | Als User möchte ich, dass das Programm schliesst wenn man Raus tabt, damit man nicht Wörter Googlen kann. |
| 23 | muss | Qualität | Als User möchte ich, dass das Programm Ausnahme Behandlungen selbst auflösen kann, damit es kein crash gibt. |
| 24 | muss | Qualität | Als User möchte ich, im Programm mit Buttons Navigieren können, damit wenn ich keine programmische Kenntnisse habe, dass es einfacher ist. |
| 25 | kann | Rahmen | Als User möchte ich Easter Eggs im Programm haben, damit die User die suchen können.  |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1   |Programm wird gestartet | Nichts |Startseite des Spiels |
|  2   |Programm wurde gestartet und ist im Main Menu  | Mausclick auf Schwierigkeiten | Zeigt die drei Schwierigkeiten |
|  3   |Programm wurde gestartet und ist im Schwierigkeitsmenu  | Mausclick auf Einfach   |  Leichter Modus   |
|  4   |Programm wurde gestartet und ist im Schwierigkeitsmenu  | Mausclick auf Mittel   |  Mittlerer Modus   |
|  5   |Programm wurde gestartet und ist im Schwierigkeitsmenu  | Mausclick auf Schwierig  |  Schwerer Modus  |
|  6   |Programm wurde gestartet und sucht sich ein Wort aus der Liste | Nichts  | Zeigt Anzahl Buchstaben des Wortes.    |
|  7   |Programm wurde gestartet und ist im Spiel | Mausclick A |  "Korrekt! Sie haben richtig erraten." |
|  8   |Programm wurde gestartet und ist im Spiel | Nichts |  Buchstabe A ist an der zweiten Stelle.  |
|  9   |Programm wurde gestartet und ist im Spiel | Mausclick B  | "Falsch! Sie haben falsch erraten."  |
|  10  |Programm wurde gestartet und ist im Spiel | Nichts | Teil der Person im Hangman erscheint und minus ein Leben.  |
|  11  |Programm wurde gestartet und ist im Spiel | Mausclick O |  "Korrekt! Sie haben richtig erraten." |
|  12  |Programm wurde gestartet und ist im Spiel | Nichts |  Buchstabe O ist an der fünften Stelle.  |
|  13  |Programm wurde gestartet und ist im Spiel | Mausclick T |  "Korrekt! Sie haben richtig erraten." |
|  14  |Programm wurde gestartet und ist im Spiel | Nichts |  Buchstabe T ist an der vierten Stelle.  |
|  15  |Programm wurde gestartet und ist im Spiel | Mausclick M |  "Falsch! Sie haben falsch erraten." |
|  16  |Programm wurde gestartet und ist im Spiel | Nichts |  Teil der Person im Hangman erscheint und minus ein Leben.   |
|  17  |Programm wurde gestartet und ist im Spiel | Mausclick L |  "Korrekt! Sie haben richtig erraten." |
|  18  |Programm wurde gestartet und ist im Spiel | Nichts |  Buchstabe L ist an der ersten Stelle.  |
|  19  |Programm wurde gestartet und ist im Spiel | Mausclick N |   "Falsch! Sie haben falsch erraten." |
|  20  |Programm wurde gestartet und ist im Spiel | Nichts |    Teil der Person im Hangman erscheint und minus ein Leben.  |
|  21  |Programm wurde gestartet und ist im Spiel | Mausclick I |   "Falsch! Sie haben falsch erraten." |
|  22  |Programm wurde gestartet und ist im Spiel | Nichts |  Buchstabe L ist an der ersten Stelle.  |
|  23  |Programm wurde gestartet und ist im Spiel | Mausclick H |   "Falsch! Sie haben falsch erraten." |
|  24  |Programm wurde gestartet und ist im Spiel | Nichts |  Buchstabe L ist an der ersten Stelle.  |
|  25  |Programm wurde gestartet und ist im Spiel | Mausclick P |   "Korrekt! Sie haben richtig erraten." |
|  26  |Programm wurde gestartet und ist im Spiel | Nichts |  Buchstabe P ist an der dritten und sechster Stelle. |
|  27  |Programm wurde gestartet und ist im Spiel | Nichts | "Kongratulation  Sie haben gewonnen." |
|  28  |Programm wurde gestartet und man hat keine Leben mehr | Nichts | Volles Hangman wird angezeigt. |
|  29  |Programm wurde gestartet und man hat keine Leben mehr | Nichts | Spielt Sound von Robin. |
|  30  |Programm wurde gestartet und ist im Menu | Alt + Tab | Programm schließt. |

### 1.4 Diagramme

![Hangman](https://user-images.githubusercontent.com/110892683/204347838-8f3922c5-1713-4f36-b9be-e3f671a0830b.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |13.12.2022     | JW  | Die Versuche und Raten angezeigt werden. | 25 min |
| 1.B  |13.12.2022       | JW  | Einen Counter für Anzahl Versuche und Raten soll addieren und subtraktieren.  | 55 min |
| 2.A  |13.12.2022       | JW  | Das Wort wird gezählt.| 30min |
| 2.B  |13.12.2022       | JW  | Die Anzahl Buchstaben im Wort sollen im Programm angezeigt werden. | 60min |
| 3.A  |13.12.2022       | JW  | Buchstaben sollen gespeichert werden die schon gewählt wurden. | 90 min |
| 3.B  |13.12.2022       | JW  | Die schon gewählten Buchstaben sollen auf dem Bildschirm angezeigt sein. | 45 min |
| 4.A  |13.12.2022       | Kritzner | Alle Wörter sind in einer Datei gespeichert. | 30min |
| 4.B  |13.12.2022       | Kritzner | Die Wörter werden eingelesen. | 30min |
| 4.C  |13.12.2022       | Kritzner | Nach Zufallsprinzip wird ein Wort zum Erraten gewählt. | 20min |
| 4.D  | 13.12.2022      | Kritzner | Nach einer Eingabe eines Buchstabens, soll dieser mit dem gewählten Wort verglichen werden. | 45min |
| 5.A  | 13.12.2022      | Kritzner | Wenn ein Wort erraten wird, soll es in einer Liste gespeichert werden. | 15min |
| 5.B  | 13.12.2022      | Kritzner | Wenn ein Wort gewählt wird, muss es zuerst mit der Liste verglichen werden. | 30min |
| 5.C  | 13.12.2022      | Kritzner | Wenn ein Wort bereits erraten wurde, muss ein neues zufällig generiert werden. | 30min |
| 6.A  |  13.12.2022     | Artur | Wenn ein Wort erraten wird, soll das Programm fragen, ob man weiterspielen will. | 30min |
| 6.B  |  13.12.2022     | Artur | Wenn ein Wort erraten wird, soll das Programm fragen, ob es das Spiel beenden soll. | 15min |
| 7.A  |  13.12.2022     | Artur | Wenn das Spiel beendet wird, soll ein Counter, der zeigt, wie viele Wörter man richtig erraten hat, da stehen| 20min |
| 7.B  |   13.12.2022    | Artur | Wenn das Spiel beendet wird, soll es die Punktzahl in einer Liste speichern| 50min |
| 7.C  |   13.12.2022    | Artur |Wenn das Spiel beendet wird, soll es mir sagen, ob ich besser als letztes Mal war | 50min |
| 8.A  |   13.12.2022    | Artur |Während man spielt, soll es am Schluss die höchste erreichte Punktzahl anzeigen. | 25min |
| 9.A  |  13.12.2022     | Artur |Am Schluss des Spiels, soll es anzeigen, wie viele Versuche man gebraucht hat. | 15min |
| 10.A  | 13.12.2022      | Artur |Man soll in einem Fenster eigene Wörter eingeben und diese sollen in einer Liste gespeichert werden. | 40min |
| 11.A  |13.12.2022       | Artur |Es soll einen Modus geben, wo man Wörter aus der Liste einzeln auswählen kann. | 120min |
| 12.A  | 13.12.2022      | Robin |Man soll am Anfang vom Spiel auswählen können ob man einfache Wörter will. | 40min |
| 12.B  |  13.12.2022     | Robin |Man soll am Anfang vom Spiel auswählen können ob man mittlere Wörter will. | 40min |
| 12.C  |  13.12.2022     | Robin |Man soll am Anfang vom Spiel auswählen können ob man schwere Wörter will. | 40min |
| 13.A  | 13.12.2022      | Robin | Es soll einen Timer geben | 20min |
| 13.B  | 13.12.2022      | Robin | Dieser Timer soll jedes Wort einzeln timen. | 35min |
| 14.A  | 13.12.2022      | Robin | Man soll eine eigene Zeit einstellen können, wie lange man Zeit für ein Wort hat. | 30min |
| 15.A  | 13.12.2022      | Luca | Es soll einen Modus geben, wo man weniger Zeit pro Fehler hat, sodass man unter Druck steht | 20min |
| 16.A  | 13.12.2022      | Luca | Das Programm soll einen lustigen Soundeffekt abspielen, wenn ein Buchstabe richtig oder falsch ist.| 20min |
| 17.A  | 13.12.2022      | Luca | Man soll mit Freunden in einem Multiplayer-Modus zusammenspielen können. | 15min |
| 18.A  | 13.12.2022      | Luca | Es soll eine Auswahl mit Einstellungen für den Multiplayer-Modus. | 200min |
| 19.A  | 13.12.2022      | Luca | Man soll im Multiplayer-Modus auswählen können, welche Rolle man hat.| 120min |
| 20.A  | 13.12.2022      | Luca | Man soll im Multiplayer-Modus einstellen können, wie viele Runden es gibt, damit man schnellere oder längere Spiele spielen kann. | 150min |
| 21.A  |13.12.2022       | Cedric | Im Multiplayer-Modus soll man auch eine bestimmte Zeit einstellen können. | 40min |
| 22.A  | 13.12.2022      | Cedric |Das Spiel soll beendet werden, falls man die Tastenkombination ALT+TAB benutzt, sodass man nicht Googlen kann.  | 30min |
| 23.A  | 13.12.2022      | Cedric | Das Programm soll Ausnahmebehandlungen selber auflösen, damit es keinen Crash gibt | 90min |
| 24.A  | 13.12.2022      | Cedric | Das GUI soll so benutzerfreundlich wie möglich werden, damit es nicht zu kompliziert wird für jemanden, der keine programmische Kenntnisse hat.| 70min |
| 25.A  | 13.12.2022      | Cedric | Es soll versteckte Puzzles im Programm geben, die jemandem eine versteckte Einstellung oder andere Art von Belohnung gibt. | 90min |



Total: 1820 Minuten

## 3 Entscheiden
Wir haben uns entschieden, dass wir keinen Multiplayer, keinen Timer und keine Datenbank wo man selbst ausgewählte Wörter einschreiben und nachher benutzen kann. Ausserdem lassen wir die verschiedenen Spielmodi weg.
Diesen Entscheid haben wir durchgeführt, weil wir Zeitmangel hatten und eher Priorität für ein Programm, das funktioniert.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 29.12.22 | JW  | 25min | 50min |
| 1.B  | 29.12.22 | JW  | 55min | 60min |
| 2.A  |29.12.22 | JW  | 30min | 45min|
| 2.B  |29.12.22 | JW  | 60min | 70min |
| 3.A  | 6.12.22 | JW  | 90min | 80min |
| 3.B  |6.12.22| JW  |  45min | 60min |
| 4.A  |29.12.22 | Kritzner | 30min | 40min |
| 4.B  |29.12.22 | Kritzner |   30min |80min |
| 4.C  |29.12.22| Kritzner |   20min |25min |
| 4.D  |29.12.22 | Kritzner |   45min |70min |
| 5.A  |29.12.22 | Kritzner |   15min | 15min|
| 5.B  |29.12.22 | Kritzner |   30min |30min |
| 5.C  |6.12.22| Kritzner |   30min |40min |
| 6.A  |29.12.22 | Artur |   30min |50min |
| 6.B  | 29.12.22| Artur |   15min |15min |
| 7.A  | 29.12.22| Artur |   20min |20min |
| 7.B  |29.12.22| Artur |  50min | 100min|
| 7.C  |29.12.22 | Artur |  50min | 50min|
| 8.A  |29.12.22| Artur | 25min |25min |
| 9.A  |6.12.22| Artur |  15min |25min|
| 11.A  |6.12.22 | Artur |  120min |200min|
| 12.A  |29.12.22 | Robin |  40min |60min|
| 12.B  | 29.12.22 | Robin |  40min |45min |
| 12.C  |29.12.22| Robin |  40min |50min|
| 14.A  |6.12.22| Robin |   30min |60min|
| 15.A  |29.12.22 | Luca |   20min |25min|
| 16.A  |29.12.22 | Luca |  20min |25min|
| 22.A  |29.12.22| Cedric |   30min |35min|
| 23.A  |29.12.22| Cedric |   90min |100min|
| 24.A  |6.12.22| Cedric |  70min |80min|
| 25.A  |6.12.22 | Cedric |  90min |120min|

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
|  1  |   20.12.2022    |    Funktioniert      |    Tuma + Sacher    |
|  2  |   20.12.2022    |    Funktioniert nicht      |     Tuma + Sacher   |
|  3  |   20.12.2022    |    Funktioniert nicht      |     Tuma + Sacher   |
|  4  |   20.12.2022    |    Funktioniert nicht      |     Tuma + Sacher   |
|  5  |   20.12.2022    |    Funktioniert nicht      |     Tuma + Sacher   |
|  6  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
|  7  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
|  8  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
|  9  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
| 10  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
| 11  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 12  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
| 13  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 14  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
| 15  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 16  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
| 17  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 18  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 19  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 20  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
| 21  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 22  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 23  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 24  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 25  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 26  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 27  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 28  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |
| 29  |   20.12.2022    |    Funktioniert      |     Tuma + Sacher   |
| 30  |   20.12.2022    |    Funktioniert nicht     |     Tuma + Sacher   |

## 6 Auswerten
