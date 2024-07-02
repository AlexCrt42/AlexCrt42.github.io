# Rapport de Projet FlopSecurity

 Le TP nous montre de plusieurs manière comment une application peut avoir des failles dans sécurité. Il nous apprend les risques liés au manque de sécurité des applications qui sont sujets de cyberattaque...

L'objectif étant de comprendre des vulnérabilités d'une application.

## Installation du serveur LAMP 

### Étapes d'installation du serveur LAMP :

**Linux:**
- Choisissez Ubuntu OS.
- Exécutez la commande `sudo apt-get install ubuntu`.

**Apache:**
- Installez Apache avec `sudo apt-get install apache2`.

**MySQL:**
- Installez MySQL avec `sudo apt-get install mysql-server`.
- Définissez le mot de passe root en suivant les étapes du document FlopSecurity.

**PHP:**
- Installez PHP avec `sudo apt-get install php libapache2-mod-php php-mysql`.
- Activez le module avec `sudo a2enmod php`.

### Différences configuration serveur développement / serveur production :

- **Serveur de Développement:**
  - Configuration moins stricte qui facilite le développement.
  - Un débogage plus efficace.
  - Utilisation d'extensions supplémentaires pour le développement.

- **Serveur de Production:**
  - Configuration plus stricte, favorisant la sécurité et minimisant les risques.
  - Débogage moins efficace.
  - Paramètres spécifiques pour la performance et la stabilité.

### Choix du Serveur :

- **Développement:** Configuration facilitant le débogage et la flexibilité.

- **Production:** Configuration plus sécurisée qui garanti la performance et la stabilité.

## Injection SQL (SQLI) :

### Description:
L'injection SQL implique l'insertion de requêtes malveillantes dans les bases de données.

### Risques encourus:
Cela peut permettre à un utilisateur malveillant de contourner l'authentification et d'accéder à des données sensibles.

### Solution technique:
Utiliser des requêtes préparées pour éviter l'injection de code SQL.

## Cross-Site Scripting (XSS) ⚠️:

### Description:
XSS injecte des scripts malveillants dans des pages web consultées par d'autres utilisateurs.

### Risques encourus:
Par exemple, l'injection de scripts dans un champ de commentaire peut voler des sessions utilisateur.

### Solution technique:
Valider et échapper les données en sortie, utiliser des politiques de sécurité du contenu (CSP).

## Sécurisation de l'application et du système :

Par exemple, mettre en place un pare-feu pour filtrer le trafic indésirable.
Par exemple, gérer strictement les permissions pour limiter l'accès.
Par exemple, effectuer des mises à jour régulières des composants pour corriger les vulnérabilités.
Par exemple, intégrer des bibliothèques de requêtes préparées dans le code pour filtrer et valider les entrées utilisateur. Utiliser des frameworks (comme Ruby on Rails) qui intègrent des mécanismes automatiques d'échappement des données pour prévenir les attaques XSS.

## Mon avis sur le TP 

Ce TP sert énormément et nous "forme" à la sécurisation d'une appli et nous montre sa très grosse importance. Il peut nous permettre d'éviter certaines erreurs à l'avenir.


## L'importance de la sécurité ! 

C'est lorsqu'on met tout ce que l'on a fais en place qu'on se rend vraiment compte de l'importance de la sécurité. Aujourd'hui personne n'est à l'abri d'une cyberattaque, d'un piratage... C'est donc très important de sécurisé son application.

## Mon avis pour l'avenir de la sécurité des apps 

Lorsque je vois le développement très rapide et les différentes manières de se faire attaquer ou pirater, je me dis que nous sommes obligé de réagir et nous, informaticiens allons réagir et réussir à développer différente formes de sécurité. Je suis donc confiant pour l'avenir de la sécurité informatique.