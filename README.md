# Tower Defense Game

Welcome to the Tower Defense Game project! This game is a 3D tower defense created with Unity. The objective is to strategically place turrets along a predefined path to stop waves of enemy units from reaching their destination. As the player progresses through levels, they face tougher enemies and gain access to new turrets.

Once player gains enough money to obtain a turret, they will have random chances to get one of 3 turrets

These include:
 Laser Missile

 Missile Launcher

 Standard Turret

 In which they all do different damage, and different attack types, These turrets have different rankings to them as well as shown in the picture below

![Percentages of ranks](https://github.com/hyeonukim/TowerDefence/assets/48634064/c93ba802-1b55-47fc-9767-1c8d2678d5b3)


![Image of Gameplay](https://github.com/hyeonukim/TowerDefence/assets/48634064/d44c74c6-fd85-4de6-a966-4f55650860e6)

## Table of Contents
- [BuildManager](#buildmanager)
- [Bullet](#bullet)
- [CameraController](#cameracontroller)
- [Enemy](#enemy)
- [EnemyMovement](#enemymovement)
- [GameManager](#gamemanager)
- [GameOver](#gameover)
- [MoneyUI](#moneyui)
- [Node](#node)
- [PlayerStats](#playerstats)
- [ResultUI](#resultui)
- [Shop](#shop)
- [Turret](#turret)
- [WaveSpawner](#wavespawner)
- [Waypoints](#waypoints)

## BuildManager
- **Description**: Manages turret building, selection, and placement within a tower defense game.
- **Usage**: Allows players to select nodes for turret placement, choose turrets to build, and handles the actual construction process.
- **Implementation**: Utilizes Unity's MonoBehaviour for scripting. Provides methods for selecting nodes and turrets, checking affordability, and building turrets on selected nodes.

## Bullet
- **Description**: Represents projectiles fired by turrets.
- **Usage**: Seeks and damages enemy targets, with optional explosion effects.
- **Implementation**: Moves towards the target, triggers effects upon impact, and applies damage to enemies.

## CameraController
- **Description**: Controls the in-game camera for player movement and zoom.
- **Usage**: Enables panning, scrolling, and toggling of camera movement during gameplay.
- **Implementation**: Utilizes Unity's Input system for player controls and adjusts camera position accordingly.

## Enemy
- **Description**: Represents enemy units in the game.
- **Usage**: Moves along waypoints, takes damage, and triggers death effects.
- **Implementation**: Utilizes waypoints for movement, updates health with damage, and handles death events.

## EnemyMovement
- **Description**: Controls the movement of enemy units along waypoints.
- **Usage**: Moves enemies towards the next waypoint in the predefined path.
- **Implementation**: Retrieves waypoints and moves the enemy towards the next destination.

## GameManager
- **Description**: Manages game state, UI, and player input.
- **Usage**: Monitors enemy count, player kills, and triggers game end conditions.
- **Implementation**: Updates UI, checks enemy count thresholds, and handles game ending.

## GameOver
- **Description**: Displays game over information.
- **Usage**: Activates upon game end and shows the player's level.
- **Implementation**: Retrieves and displays the player's level.

## MoneyUI
- **Description**: Displays the player's current money.
- **Usage**: Updates the UI to show the player's available funds.
- **Implementation**: Retrieves and displays the player's money.

## Node
- **Description**: Represents build nodes on the game map.
- **Usage**: Handles node selection, turret building, and UI interactions.
- **Implementation**: Allows building turrets on nodes.

## PlayerStats
- **Description**: Manages player-related statistics such as money, turret type, rank, level, and enemy counts.
- **Usage**: Tracks and updates player stats throughout the game.
- **Implementation**: Initializes and updates player stats, such as money and level, during gameplay.

## ResultUI
- **Description**: Displays the result of the game, including the turret used and its rank.
- **Usage**: Retrieves and displays information based on the player's performance.
- **Implementation**: Dynamically updates UI elements to reflect the player's turret and rank.

## Shop
- **Description**: Handles the in-game shop functionality, including purchasing turrets with random ranks.
- **Usage**: Manages turret lists, random turret selection, and turret purchase logic.
- **Implementation**: Integrates with BuildManager to select and purchase turrets based on player choices.

## Turret
- **Description**: Represents the behavior and attributes of turrets in the game.
- **Usage**: Handles targeting, shooting, and special effects for both bullet and laser turrets.
- **Implementation**: Utilizes Unity's MonoBehaviour for turret behavior, including shooting and targeting logic.

## WaveSpawner
- **Description**: Spawns waves of enemies at regular intervals.
- **Usage**: Controls the timing and count of enemy waves, updating the game level accordingly.
- **Implementation**: Utilizes Coroutine to spawn enemy waves and dynamically adjusts wave count based on game level.

## Waypoints
- **Description**: Manages waypoints for enemy movement.
- **Usage**: Stores and retrieves waypoint information for enemy pathfinding.
- **Implementation**: Initializes waypoints based on child objects and provides access for enemy movement.
