# 🎮 Mini-MMORPG 2D Unity - Whishtic Realms

Projet personnel de développement d’un mini-MMORPG en 2D multijoueur, réalisé avec Unity et Mirror, dans le but de renforcer mes compétences en C# et multijoueur, et de servir de projet vitrine pour une alternance dans le jeu vidéo.

## 🚀 Objectifs

- Déplacement en temps réel sur une carte commune
- Affichage des autres joueurs connectés
- Chat global en jeu
- Combat de mobs
- Sauvegarde des données locales

## 🧰 Stack technique

- **Unity 6 LTS**
- **C# (Visual Studio 2022)**
- **Mirror** (multijoueur temps réel)
- **Git / GitHub**
- **JSON** (persistance locale)

## 🧩 Fonctionnalités (MVP)

- ✅ Création de personnage (pseudo + couleur)
- ✅ Mouvement du joueur avec collisions
- ✅ Carte 2D TileMap
- ✅ Multijoueur en temps réel (Mirror)
- ✅ Chat synchronisé entre joueurs
- ✅ Mob simple à attaquer

## 📌 À venir (version 2)

- Système d’inventaire
- Quêtes simples
- PvP entre joueurs
- Gestion de comptes en ligne

## 🎨 Univers & Graphismes

- Style pixel art 2D, top-down
- Univers fantasy médiéval

## 🗂️ Structure du projet Unity

```
/Assets
  /Scripts
    - PlayerMovement.cs
    - NetworkManagerCustom.cs
    - ChatManager.cs
  /Prefabs
    - Player.prefab
    - Mob.prefab
  /Scenes
    - MainScene.unity
  /UI
    - ChatPanel
    - HUD
```

## 🛠️ Tests

- Mode solo (en local)
- Mode multijoueur (client 1 + client 2)
- Logs via Debug.Log() + Visual Studio

## 🗓️ Planning prévisionnel

| Étape                        | Durée estimée |
|-----------------------------|---------------|
| Setup projet + Git          | 1 jour        |
| Mouvement + caméra          | 1 jour        |
| Intégration Mirror          | 1–2 jours     |
| Voir les autres joueurs     | 1 jour        |
| Ajouter un chat global      | 1 jour        |
| Créer un mob avec IA simple | 1 jour        |
| Créer une zone "plaine"     | 0.5 jour      |
| Débogage + polish           | 2–3 jours     |

## 📁 Repository

Ce projet est versionné avec Git et hébergé sur GitHub.  
**Licence** : projet open-source (à préciser)  
**Auteur** : Erwan EBAH
