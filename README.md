# co-opeDown
Orbital 2021
User and Developer Guides can be found below.

[User Guide](https://github.com/marcuslim835/co-opeDown#user-guide "For normal users")

[Developer Guide](https://github.com/marcuslim835/co-opeDown#developer-guide "For developers who are interested in our implementation")

# User Guide
## 1.1 Overview

### 1.1.1 Installing the Game
Download and run co-opeDown.exe to play the demo

### 1.1.2 Player Controls
Player 1 Controls: WASD for movement
Player 2 Controls: Arrow Keys for movement

### 1.1.3 Scoring Mechanics

### 1.1.4 Level Mechanics
As the level increases, questions will progressively get harder. For example, in the case of 1.2.1, the numbers generated will increase from 20 in the first level to 60 in the final level.

## 1.2 Stages
All stages have a timer on them. Players should clear the stage before the timer expires to be able to get the score associated with clearing the stage.

### 1.2.1 Platform Questions
<img width="958" alt="1-1" src="https://user-images.githubusercontent.com/77620616/122509856-150ec400-d037-11eb-9845-62a2268ab9ed.png">
Move the chickens to 2 different platforms whose numbers add up to the number displayed in the middle. <br>
Standing on the wrong platforms will not result in a "level fail". <br>
In the example provided, moving the rooster and hen to the platform for "12" and "10" would clear the level.

### 1.2.2 True False Questions

### 1.2.3 Catch the Object

### 1.2.4 Button Shooting Questions

### 1.2.5 Knowing Each Other Questions

### 1.2.6 "Boss Fight"

# Developer Guide
## 1.1 Overview

### 1.1.1 Installing the Game
Download and run co-opeDown.exe to play the demo

### 1.1.2 Player Controls
Player 1 Controls: WASD for movement
Player 2 Controls: Arrow Keys for movement

### 1.1.3 Scoring Mechanics

### 1.1.4 Level Mechanics

## 1.2 Game Design

### 1.2.1 General Game Flow

### 1.2.2 The DontDestroyOnLoad GameObject
Common Objects | Description
------------ | -------------
DisplayUI | The UI for the player that includes the level, score, timer, and settings.
OptionsMenu | The settings menu that is disabled by default and enabled when the settings button in DisplayUI is pressed.

### 1.2.3 Player Object

## 1.3 Stages
All stages have a timer on them. Players should clear the stage before the timer expires to be able to get the score associated with clearing the stage.
Common Objects | Description
------------ | -------------
Main Camera | Scenes with moving cameras contain a CameraTargets script that tracks the position (transform) of both player objects and adjusts the zoom to encompass both players within the camera view.
Background | As the name suggests, the background picture of the scene.
Tilemap | Used to place platforms, floor and position limits of the map.
World Canvas | Used to display the relevant information tied to the world (eg. labels for tiles or buttons).
Screen Canvas | Used to display the questions and counters related to the stage on the display for the player.
GameController | Contains the scripts specific to each stage. To be discussed in [1.3.1](https://github.com/marcuslim835/co-opeDown#131-platform-questions).
Player_1/2 | As mentioned in [1.2.3](https://github.com/marcuslim835/co-opeDown#123-player-object).
GameObject | As mentioned in [1.2.2](https://github.com/marcuslim835/co-opeDown#122-the-dontdestroyonload-gameobject).

### 1.3.1 Platform Questions
![image](https://user-images.githubusercontent.com/77620616/122510741-ab8fb500-d038-11eb-91f1-487ea0f0faac.png)
The GameController for this scene contains a PlatformerGameLogic script, with the following inputs.
PlatformerGameLogic Script | Description
------------ | -------------
Player1 | Reference to Player_1
Player2 | Reference to Player_2
Text List | A list of text under World Canvas that serves to display a unique number with every platform.
Sum | A text object under Screen Canvas that displays the sum needed for the player to clear the stage.
Max Random | etc tbc

### 1.3.2 True False Questions

### 1.3.3 Catch the Object

### 1.3.4 Button Shooting Questions

### 1.3.5 Knowing Each Other Questions

### 1.3.6 "Boss Fight"

# Credits
Movement script is based on the one provided by Unity as part of their Standard Assets.
