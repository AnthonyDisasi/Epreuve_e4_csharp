<h1>Rallye Lecture</h1>
Le principe était de réaliser une application Windows Form en C# permettant à un professeur d'alimenter une base de données avec un fichier csv. Le fichier csv contient donc une liste d'élève (prénom et nom). Par la suite après avoir lancé le programme, des identifiants de connexion à notre site sont donc créées.

Le projet est divisé en 3 grandes parties :

Lecture des informations d'un fichier csv.
Ecriture d'un fichier csv avec les informations de connection de chaques eleves.
Alimentation d'une base de données.
Les outils mis en oeuvre :

Git
Visual Studio
C#
Windows Form
<h2>Cas d'utilisation</h2>
<a href="http://zupimages.net/viewer.php?id=19/15/d7m5.png"><img src="https://zupimages.net/up/19/15/d7m5.png" alt="" /></a>

<h2>Diagrammes de classe</h2>
<a href="http://zupimages.net/viewer.php?id=19/15/723o.png"><img src="https://zupimages.net/up/19/15/723o.png" alt="" /></a>
<a href="http://zupimages.net/viewer.php?id=19/15/nf78.png"><img src="https://zupimages.net/up/19/15/nf78.png" alt="" /></a>
Développement
Nous retrouvons donc deux interfaces Windows Forms :


La première permet à un enseignant (et uniquement à un enseignant) de se connecter à l'application.
<a href="http://zupimages.net/viewer.php?id=19/15/fhyo.png"><img src="https://zupimages.net/up/19/15/fhyo.png" alt="" /></a>
Capture2.png
La seconde est donc l'interface principale. Nous y retrouvons :

Choix d'un répertoire contenant des csv.
Choix du csv à utiliser.
Choix de l'année scolaire.
Choix du niveau scolaire.
Choix de la génération du mot de passe.
Schéma de la base de données
Capture.png
Capture.png
