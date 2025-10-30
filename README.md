# 🚒 PimPomBro

## 📌 À propos

**PimPomBro** est une application C# développée avec WinForms pour **la gestion complète d’une caserne de pompiers**.  
Elle permet de suivre les missions, gérer les pompiers et les véhicules, et de générer des rapports PDF pour les opérations effectuées.  

---

## Aperçu de l’application

Voici quelques captures d’écran illustrant l’interface :

![page_accueil](imagesReadme/page_accueil.png)  
![gestion_pompiers](imagesReadme/gestion_pompiers.png)  

---

## Technologies utilisées

- **Langage :** C#  
- **Interface graphique :** WinForms (Visual Studio)  
- **Base de données :** SQLite  
- **Fonctionnalités supplémentaires :** génération automatique de PDF  

---

## Installation et lancement

1. **Récupérer le projet**  
- bash:
  - ``git clone https://github.com/apt-install-fella/PimPomBro.git ``
  - ``cd PimPomBro``


3. **Ouvrir le projet dans Visual Studio**

4. **Vérifier la présence de SQLite**

    -Dans Visual Studio : Projet > Gérer les packages NuGet

    -Chercher System.Data.SQLite.Core (version 1.0.119) et l’installer si nécessaire

    -Cliquer sur Appliquer puis J’accepte

5. **Lancer l’application**

    -Appuyer sur le bouton ▶ ou utiliser la touche F5
---

## Fonctionnalités principales
L’application utilise des liaisons de données en mode connecté ou déconnecté.
<br>
Toutes les modifications de la base (insertion, mise à jour) sont effectuées dans des transactions pour garantir l’intégrité des données.

1️⃣ **Page d’accueil**

Affiche toutes les missions (en cours ou terminées) : type de sinistre, adresse, date, commentaires, compte rendu

Permet de terminer une mission en cours

Génère un PDF récapitulatif de la mission

Option de filtrer les missions affichées

2️⃣ **Création d’une mission**

Crée une mission en indiquant le type de sinistre, l’adresse, un commentaire et la caserne responsable

Affecte automatiquement les pompiers et véhicules disponibles

Si la caserne choisie ne peut pas gérer la mission, il faut sélectionner une autre caserne

Affiche le résumé des ressources mobilisées

3️⃣ **Gestion des informations des pompiers**

Permet de sélectionner un pompier pour afficher :

- matricule et informations personnelles

- caserne de rattachement

- anciennes missions et habilitations (avec dates)

- disponibilité actuelle (ex : en congé)

- Possibilité de modifier certaines informations

- Accès protégé par login/mot de passe administrateur

4️⃣ **Statistiques**

Affiche des statistiques sur l’ensemble de la base ou par caserne precise:
- Générale : 

    - habilitations les plus utilisées
    - nombre de missions par type de sinistre
    - liste des pompiers ayant une habilitation spécifique
      
- Caserne :
    - véhicule le plus mobilisé
    - temps d’utilisation de chaque véhicule par caserne

