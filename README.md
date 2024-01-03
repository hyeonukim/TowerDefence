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

The `BuildManager` class manages turret building and selection.

## Bullet

The `Bullet` class handles the behavior of bullets fired by turrets.

## CameraController

The `CameraController` class controls the movement and interaction of the in-game camera.

## Enemy

The `Enemy` class defines the behavior of enemy units.

## EnemyMovement

The `EnemyMovement` class handles the movement of enemy units along waypoints.

## GameManager

The `GameManager` class manages the overall game state, including game ending conditions.

## GameOver

The `GameOver` class displays the game over UI and allows players to retry.

## MoneyUI

The `MoneyUI` class updates and displays the in-game currency.

## Node

The `Node` class represents buildable nodes on the game grid where turrets can be placed.

## PlayerStats

The `PlayerStats` class keeps track of player-related statistics, such as money, turret, rank, level, and enemy counts.

## ResultUI

The `ResultUI` class displays the result, including the selected turret and its rank.

## Shop

The `Shop` class handles turret purchasing and randomization.

## Turret

The `Turret` class defines the behavior of turrets, including shooting and targeting.

## WaveSpawner

The `WaveSpawner` class controls the spawning of waves of enemies.

## Waypoints

The `Waypoints` class defines the path for enemy movement through waypoints.

Feel free to customize and expand this `README.md` file based on your project's specific details and features.
