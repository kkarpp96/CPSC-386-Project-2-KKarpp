# Second Simple Platformer for CPSC-386 Game Development Class

Compiled build can be found in /Build.

# Project 2 Documentation

## Scripts
### PlayerMovement.cs
Handles player input and moves the Player GameObject by its transform and accesses its rigidbody to apply linear velocity for jumping. Also contains is_grounded checks for jumping, a maximum player fall speed constraint, a constraint to prevent glitching into walls, and logic for checking if Player has fallen off the screen. It also includes animation controls related to movement.
### GameRules.cs
Handles victory and player death conditions. It tracks timer scores to PlayerPrefs, resets player position on death, and keeps track of which level to load next when the Player collides with the Goal GameObject.
### MenuButtons.cs
Handles start and quit buttons from the main menu and pause menu. It loads the correct scene when starting the game or returning to menu and closes the game when the main menu's quit button is pressed.
### PauseButtons.cs
Handles game pausing by stopping and starting timeScale and activates the pause buttons and text.
### VictoryTrigger.cs
Handles the Player GameObject colliding with the Goal GameObject. Checks for the Player tag when something enters its trigger zone and then triggers GameRules.cs' Victory() method.
### VolumeInput.cs
Handles the player's volume selection from the main menu's volume slider.
### SoundManager.cs
Plays music and maintains its persistence between scenes.
### PlayerAnimation.cs
Helper script that sends the animation event trigger from the player's visual object that actually gets animated to the player game object that handles game logic and control.
### ParticleManager.cs
Helper script that plays particle system effects at the position of the collectible.
### Switch.cs
Handles trigger collisions for the switches in level 2.
### CoinSpawner.cs
Handles logic for spawning coins in a random configuration in level 3.
### Coin.cs
Handles trigger collisions for coin collection in level 3.
### Counter.cs
Handles logic for collecting enough coins to win the game.

## Scenes
### MainMenu
Displays game title, controls, and start and quit buttons.
### Level1
Simple first level of the game to ease players into the controls and player animations before adding too many mechanics.
### Level2
Introduces switches that get activated in the goal game object's hash set until all four are activated and the goal is unlocked.
### Level3
Final level that introduces the randomized coin collection where players must gather enough coins to achieve their final victory.
### VictoryScreen
Final menu screen that displays a congratulations message and allows players to return to the main menu.

## Requirements
### Requirement 1
The player is controlled with an Input Actions asset with jumps that are restricted with a groundcheck.
### Requirement 2
Level 2 has switches that are stored in a hash set with unique ids until all are flipped and the goal is unlocked to progress.
### Requirement 3
The music is persistent between scenes without restarting with persistent volume controls from the main menu slider. There is also a jump sound effect and coin/switch collection sound effect.
### Requirement 4
This project unfortunately does not meet this requirement.
### Requirement 5
The player has an animator control with idle, jumping, and falling animations, as well as a blend tree that handles the transitions between moving left and right.
### Requirement 6
The player left and right movement animations have animation events that cause the player's speed to increase slightly at the peak of the animation.
### Requirement 7
The switches and coins in levels 2 and 3 have particle effects that play on collection.
### Requirement 8
The coins in level 3 are spawned in random locations.

## Third-Part Asset Usage
Music: [8-Bit Retro by Monume via Pixabay](https://pixabay.com/music/video-games-8-bit-retro-629800/)  
Collection SFX: [Game Bonus 02 by Universfield via Pixabay](https://pixabay.com/sound-effects/film-special-effects-game-bonus-02-294436/)  
Jump SFX by me