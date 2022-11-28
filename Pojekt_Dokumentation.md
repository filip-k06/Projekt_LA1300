# Projekt-Dokumentation

Kritzner, Bytyqi, JW, Sacher, Tuma

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 27.11-28.11.22 | 0.0.1   | Schritte 1-3 ausgefüllt. |


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
| 9 | kann | Qualität | Als ein User möchte ich, dass mein Highscore gespeichert wird, damit ich mich mit vorherigen Runden vergleichen kann. |
| 10 | kann | Qualität | Als ein User möchte ich eine visuelle Darstellung sehen, damit ich weiss wie viele Versuche ich gebraucht habe. |
| 11 | kann | funktional | Als User möchte ich selber gewählte/geschriebene Wörter in das Programm schreiben, damit die Wörter in eine Datenbank speichern.|
| 12 | kann | funktional | Als User möchte ich Wörter in der Datenbank auswählen, damit ich es mehr Spass macht.| 
| 13 | muss | Qualität | Als User möchte ich schwierigkeitsstufen bevor das Spiel aussuche, damit es schwerer werden kann. |
| 14 | kann | funktional | Als User möchte ich einen Timer haben, damit ich sehe wie lange ich pro wort gebraucht habe.|
| 15 | kann | Qualität | Als User möchte ich den Timer einstellen, damit ich mehr oder weniger Zeit habe. |
| 16 | kann | funktional | Als User möchte ich eine Zeitbegrenzung haben, damit ich unter Zeitdruck stehe. |
| 17 | kann | Qualität | Als User möchte ich die Zeitbegrenzung einstellen, damit ich mehr oder weniger Zeit habe. |
| 18 | muss | Qualität | Als User möchte ich lustige Soundeffekt wenn ich ein Buchstabe richtig oder falsch ist, damit es mehr spassig ist. |
| 19 | muss | funktional| Als User möchte ich einen Multiplayer Modus haben, damit ich mit freunden spielen kann. |
| 20 | muss | funktional| Als User möchte ich im Main Menu den Multiplayer Modus auswählen können, damit ich den Multiplayer Modus benutzen kann.
| 21| muss | funktional| Als User möchte ich das beim Multiplayer Modus Spieler eins auswählen kann welche Rolle er will sein, damit mann nicht immer etwas anderes muss sein. |
| 22| muss | funktional| Als User möchte ich ein Wort aus der Datenbank hollen kann, damit ich mich entscheiden kann.|
| 23| kann | Qualität | Als User möchte ich selber neue Wörter schreiben die nicht in der Datenbank zu finden sind, damit keine Repetition stattfindet.|
| 24| kann | Qualität | Als User möchte ich einstellen im Multiplayer Modus wie viele Runden es gibt, damit man schnellere oder längere Partien haben kann.|
| 25| kann | Qualität | Als User möchte ich im Multiplayer Modus einen Timer einstellen können, damit mein gegner keine Zeitverschwendet.|
| 26| kann | Qualität | Als User möchte ich im Multiplayer Modus eine Buchstaben grösse einstellen können, damit nicht Hunderte von Buchstaben einfach reinfgeschrieben werden die ich herausfinden muss. |
| 27 | muss | Qualität | Als Programmierer möchte ich, dass das Programm schliesst wenn man Raus tabt, damit mann nicht Wörter googeln kann. |
| 28 | muss | Qualität | Als Programmierer möchte ich, dass das Programm ausnahmebehandlungen selbst auflösen kann, damit es kein crash gibt. |
| 29 | muss | Qualität | Als User möchte ich, im Programm mit Buttons Naviegieren, damit wenn ich keine programmische Kenntnisse habe es einfacher ist. |
| 30 | kann | Rahmen | Als Programmierer möchte ich Easter Eggs im Programm haben, damit die User die suchen können.  |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|  1   |Programm wird gestrartet | Buchstabe | Ist der Buchstabe richtig oder Falsch |
|  2   |Programm wird gestartet  | Zahl | Fehlermeldung |
|  3   |Programm wird gestartet  | Mausclick auf 1   |  Leichter Modus   |
|  4   |Programm wird gestartet  | Mausclick auf 2   |  mittlerer Modus   |
|  5   |Programm wird gestartet  | Mausclick auf 3   |  schwerer Modus  |
|  6   |Programm wird gestartet  | zu viele versuche   |  Spiel wird beendet   |
|  7   |Programm wird gestartet  | Spiel wird beendet    |   Willst du nochmal spielen?  |
|  8   |Programm wird gestartet  | Tab   |   Programm wird geschlossen   |
|  9   |Programm wird gestartet  | Wörter werden eingelesen   |  Wörter werden in einer Liste gespeichert    |
|  10  |Programm wird gestartet  | Wort ist korrekt  |  Wort wird in einer neuen Liste gespeicher   |
|  11  |Programm wird gestartet  | Buchstabe ist Falsch oder richtig  |  -1 Versuch   |
|  12  |Programm wird gestartet  | Buchstabe ist richtig | Pluspunkte    |
|  13  |Programm wird gestartet  | Buchstabe ist Falsch in schwerem Modus    |  Minuspunkte   |
|  14  |Programm wird gestartet  | Wort ist falsch  | Pech gehabt   |
|  15  |Programm wird gestartet  | windowstaste | Progamm wird geschlossen  |

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
| 28.A  |       | Robin | Ausnahmebehandlung| 20min |
| 28.B  |       | Robin | Programm wird fortgesetzt, nachdem Fehler abgefangen wurde| 10min
| 29.A  |       | Robin | Grafische Oberfläche | 50min |
| 29.B  |       | Robin | Spielmenü | 20Min |
| 29.C |       | Robin | Funktionale Buttons programmieren | 50min|
| 13.A |       | Robin | Verschiedene Schwierigkeitsgrade | 20min |   
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
