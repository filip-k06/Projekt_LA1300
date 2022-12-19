# Lern-Bericht

## Einleitung
Wir haben ein Spiel wie Hangman programmiert.

## Was haben wir gelernt?
Wir haben vieles gelernt aber vorallem hat uns das Abspielen eines Sounds fasziniert.

## Beschreibung
Wir können nun beliebige Sounds in C# abspielen. In unserem Programm hört man Sounds wenn man Punkte bekommt oder verliert. Dies scheint am Anfang kompliziert zu sein, ist es allerdings nicht wirklich. Anhand dem Code unten sieht man, wie man einen Sound mithilfe dem `SoundPlayer` abspielen. Zuerst muss man aber die Bibliothek `System` importieren, dass man den `SoundPlayer` verwenden kann. Bei meinem Code habe ich eine extra Funktion für das Abspielen eines Sounds erstellt. Man kann aber auch direkt im `Main` die Sounds abspielen. In der Funktion habe ich als Erstes den Pfad der Sound Datei definiert. Die Sound Datei muss zwingend eine `.wav` Datei sein. Dabei darf die Datei beliebig lang sein. Am Schluss muss man nur noch die `.Play` Funktion callen um den Sound abzuspielen. Wichtig ist noch zu wissen, dass das Programm genug lange laufen muss, um den Sound ganz abspielen zu können. Deswegen habe ich einen `Thread.Sleep(5000)` eingefügt damit der ganze Sound abgespielt werden kann.
