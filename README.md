Rallye Lecture
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
Cas d'utilisation
Capture.png

Diagrammes de classe
Capture2.png
Capture3.png

Développement
Nous retrouvons donc deux interfaces Windows Forms :

Capture.png
La première permet à un enseignant (et uniquement à un enseignant) de se connecter à l'application.

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
