# co-opeDown
Orbital 2021
User and Developer Guides can be found below.

[User Guide](https://github.com/marcuslim835/co-opeDown#user-guide "For normal users")

[Developer Guide](https://github.com/marcuslim835/co-opeDown#developer-guide "For developers who are interested in our implementation")

# User Guide
## 1.1 Overview
The user guide is meant to provide brief information to the user about the game co-opeDown. For detailed information and explanation as to how the game works, proceed to the [Developer Guide](https://github.com/marcuslim835/co-opeDown#developer-guide "For developers who are interested in our implementation") below.

### 1.1.1 Installing the Game
For Windows Users: Download the "Windows" folder and run co-opeDown.exe to play the demo.
For Mac Users: ???

### 1.1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot

### 1.1.3 Scoring Mechanics
Scoring can differ by the different stages. The general rule of thumb is that a stage complete gives a base score of 100, in addition to points given for speed (calculated using the time remaining when the stage is cleared).

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
The developer guide is meant to provide detailed information and explaination into how the game co-opeDown works. For a brief guide, proceed to the [User Guide](https://github.com/marcuslim835/co-opeDown#user-guide "For normal users") above.

### 1.1.1 Installing the Game
For Windows Users: Download the "Windows" folder and run co-opeDown.exe to play the demo.
For Mac Users: ???

### 1.1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot <br>
The rationale for using only four keys that are adjacent to each other is to facilitate the one-handed use of a single keyboard by two players to play the game.

### 1.1.3 Scoring Mechanics
Scoring can differ by the different stages. <br>
Stage (where X is an integer) | Scoring for Stage Clear | Scoring for Stage Fail
------------ | ------------- | -------------
X-1 | 100 + seconds remaining on the clock | 0
X-2 | 100 + seconds remaining on the clock | 0
X-3 | 5 per normal flask, 10 per blue flask | Not Possible to Fail
X-4 | 100 + seconds remaining on the clock | 0

### 1.1.4 Level Mechanics
As the level increases, questions will progressively get harder. <br>
Stage X-1 | Individual Platform Numbers Capped At
------------ | -------------
1-1 | 20
2-1 | 30
3-1 | 40
4-1 | 50
5-1 | 60

Stage X-2 | Individual Numbers of [Equation](https://github.com/marcuslim835/co-opeDown#132-true-false-questions) Capped At
------------ | -------------
1-2 | 20
2-2 | 30
3-2 | 40
4-2 | 50
5-2 | 60

Stage X-3 | Chance of Blue Flask Spawning
------------ | -------------
1-3 | 0
2-3 | 0.2
3-3 | 0.4
4-3 | 0.6
5-3 | 0.8

Stage X-4 | Number of Buttons | Possibility of Repeated Numbers of the Same Sign | Numbers Capped At
------------ | ------------- | ------------- | -------------
1-4 | 0 | No | 9
2-4 | 0.2 | Yes | 9
3-4 | 0.4 | No | 19
4-4 | 0.6 | Yes | 19
5-4 | 0.8 | No | 29

## 1.2 Game Design

### 1.2.1 General Game Flow

### 1.2.2 The DontDestroyOnLoad GameObject
Objects | Description
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
