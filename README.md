# co-opeDown
Orbital 2021
User and Developer Guides can be found below.

[User Guide](https://github.com/marcuslim835/co-opeDown#user-guide "For normal users")

[Developer Guide](https://github.com/marcuslim835/co-opeDown#developer-guide "For developers who are interested in our implementation")

# User Guide
## 1.1 Overview
The user guide is meant to provide brief information to the user about the game co-opeDown. For detailed information and explanation as to how the game works, proceed to the [Developer Guide](https://github.com/marcuslim835/co-opeDown#developer-guide "For developers who are interested in our implementation") below.

### 1.1.1 Installing the Game
For Windows Users: Download the "Windows" folder and run co-opeDown.exe to play the demo. <br>
For Mac Users: ???

### 1.1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot

### 1.1.3 Scoring Mechanics
Scoring can differ by the different stages. The general rule of thumb is that a stage complete gives a base score of 100, in addition to points given for speed (calculated using the time remaining when the stage is cleared). More details can be found in the [Developer Guide](https://github.com/marcuslim835/co-opeDown#developer-guide "For developers who are interested in our implementation").

### 1.1.4 Level Mechanics
As the level increases, questions will progressively get harder. For example, in the case of 1.2.1, the numbers generated will increase from 20 in the first level to 60 in the final level. More details can be found in the [Developer Guide](https://github.com/marcuslim835/co-opeDown#developer-guide "For developers who are interested in our implementation").

### 1.1.5 User Interface
The following is a labelled screenshot of the user interface that every user will see in the game.
<img width="756" alt="UIExplainer" src="https://user-images.githubusercontent.com/77620616/122636872-1ff05400-d11e-11eb-85e3-aa2ee7992f43.png">
<img width="753" alt="OptionsMenu" src="https://user-images.githubusercontent.com/77620616/122636873-21218100-d11e-11eb-9f91-09d8b349a21a.png">

## 1.2 Stages
All stages have a timer on them. Players should clear the stage before the timer expires to be able to get the score associated with clearing the stage.

### 1.2.1 Platform Questions
<img width="958" alt="1-1" src="https://user-images.githubusercontent.com/77620616/122509856-150ec400-d037-11eb-9845-62a2268ab9ed.png">
Move the chickens to 2 different platforms whose numbers add up to the number displayed in the middle. <br>
Standing on the wrong platforms will not result in a "level fail". <br>
In the example provided, moving the rooster and hen to the platform for "12" and "10" would clear the level.

### 1.2.2 True False Questions
<img width="960" alt="1-2falsemath" src="https://user-images.githubusercontent.com/77620616/122638704-4915e200-d128-11eb-9bac-10eb51027681.png">
<img width="958" alt="1-2falsestatement" src="https://user-images.githubusercontent.com/77620616/122638705-4a470f00-d128-11eb-96d2-4464c40a951c.png">
Both chickens should be standing on the same platform that answers the question displayed in the middle. <br>
Questions will either be in the form of a statement or an equation. <br>
Standing on the wrong platform will result in a "level fail" (game continues with no score added). <br>
In both examples provided, moving both the rooster and the hen to the platform labelled "False" would clear the level and earn points. Moving them to the platform labelled "True" would end the level and not earn points.

### 1.2.3 Catch the Object

### 1.2.4 Button Shooting Questions

### 1.2.5 Knowing Each Other Questions

### 1.2.6 "Boss Fight"

# Developer Guide
## 1.1 Overview
The developer guide is meant to provide detailed information and explaination into how the game co-opeDown works. For a brief guide, proceed to the [User Guide](https://github.com/marcuslim835/co-opeDown#user-guide "For normal users") above.

### 1.1.1 Installing the Game
For Windows Users: Download the "Windows" folder and run co-opeDown.exe to play the demo. <br>
For Mac Users: ???

### 1.1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot <br>
The rationale for using only four keys that are adjacent to each other is to facilitate the one-handed use of a single keyboard by two players to play the game.

### 1.1.3 Scoring Mechanics
Scoring can differ by the different stages. <br>
Stage (where X is the level) | Scoring for Stage Clear | Scoring for Stage Fail
------------ | ------------- | -------------
X-1 | 100 + seconds remaining on the clock | 0
X-2 | 100 + seconds remaining on the clock | 0
X-3 | 5 per normal flask, 10 per blue flask | Not Possible to Fail
X-4 | 100 + seconds remaining on the clock | 0

### 1.1.4 Level Mechanics
As the level increases, questions will progressively get harder. <br>
Levels for Stage 1 | Individual Platform Numbers Capped At
------------ | -------------
1-1 | 20
2-1 | 30
3-1 | 40
4-1 | 50
5-1 | 60

Levels for Stage 2 | Individual Numbers of [Equation](https://github.com/marcuslim835/co-opeDown#132-true-false-questions) Capped At
------------ | -------------
1-2 | 20
2-2 | 30
3-2 | 40
4-2 | 50
5-2 | 60

Levels for Stage 3 | Chance of Blue Flask Spawning
------------ | -------------
1-3 | 0
2-3 | 0.2
3-3 | 0.4
4-3 | 0.6
5-3 | 0.8

Levels for Stage 4 | Number of Buttons | Possibility of Repeated Numbers of the Same Sign | Numbers Capped At
------------ | ------------- | ------------- | -------------
1-4 | 0 | No | 9
2-4 | 0.2 | Yes | 9
3-4 | 0.4 | No | 19
4-4 | 0.6 | Yes | 19
5-4 | 0.8 | No | 29

## 1.2 Game Design

### 1.2.1 General Game Flow

### 1.2.2 The DontDestroyOnLoad GameObject
The GameObject contains the User Interface for the game.
Objects | Description
------------ | -------------
DisplayUI | The UI for the player that includes the level, score, timer, and settings.
OptionsMenu | The settings menu that is disabled by default and enabled when the settings button in DisplayUI is pressed.

<img width="756" alt="UIExplainer" src="https://user-images.githubusercontent.com/77620616/122636872-1ff05400-d11e-11eb-85e3-aa2ee7992f43.png">
<img width="753" alt="OptionsMenu" src="https://user-images.githubusercontent.com/77620616/122636873-21218100-d11e-11eb-9f91-09d8b349a21a.png">


### 1.2.3 Player Object
Objects | Description
------------ | -------------
PlayerMovement | ???
PlayerCollision | Used for collision detection in 1.3.1 and 1.3.2. Value of `isCorrectA` or `isCorrectB` changes to true if player is standing on platform with "CorrectAnswerA" or "CorrectAnswerB" tags respectively.
Weapon | ???

## 1.3 Stages
All stages have a timer on them. Players should clear the stage before the timer expires to be able to get the score associated with clearing the stage.
Common Objects | Description
------------ | -------------
Main Camera | Scenes with non-motionless cameras contain a CameraTargets script that tracks the position (transform) of both player objects and adjusts the camera view to encompass both players by adjusting the zoom level through the field of view.
Background | As the name suggests, the background picture of the scene.
Tilemap | Used to place platforms, floor and position limits of the map.
World Canvas | Used to display the relevant information tied to the world (eg. labels for tiles or buttons).
Screen Canvas | Used to display the questions and counters related to the stage on the display for the player.
GameController | Contains the scripts specific to each stage. To be discussed in the following subsections.
Player_1/2 | As mentioned in [1.2.3](https://github.com/marcuslim835/co-opeDown#123-player-object).
GameObject | As mentioned in [1.2.2](https://github.com/marcuslim835/co-opeDown#122-the-dontdestroyonload-gameobject).

### 1.3.1 Platform Questions
*Stage X-1 Questions are of this type.* <br>
The GameController for this scene contains a PlatformerGameLogic script, with the following inputs. <br>
PlatformerGameLogic Inputs | Description
------------ | -------------
Player1 | Reference to Player_1
Player2 | Reference to Player_2
Text List | A list of text under World Canvas that serves to display a unique number with every platform.
Sum | A text object under Screen Canvas that displays the sum needed for the player to clear the stage.
Max Random Number | Maximum number that any platform's value can take on
Min Random Number A | Minimum number that the first correct platform's value can take on
Min Random Number B | Minimum number that the second correct platform's value can take on

**Flow Chart** <br>
1. Stage Initialization
    1. 2 platforms are randomly chosen to be the ones with the correct answer. They are assigned with the tags "CorrectAnswerA" and "CorrectAnswerB".
    2. Unique numbers are randomly generated for the 2 chosen platforms using `Max Random Number`, `Min Random Number A`, and `Min Random Number B`. The sum of the 2 numbers are assigned to the text object `Sum`.
    3. Unique numbers that cannot be added together to give the correct sum are randomly generated for the remaining platforms using `Max Random Number` and `Min Random Number A`.
2. Stage in Progress
    1. Timer from ScoreTimeManager script is started.
    2. Collision detection using the PlayerCollision script on the [Player](https://github.com/marcuslim835/co-opeDown#123-player-object) object to detect if the player is standing on the correct platforms.
3. Stage End
    1. Players stands on the 2 chosen platforms (which is verified using the `isCorrectA` and `isCorrectB` booleans on the Player object by the PlatformerGameLogic script) **OR** Timer runs down to 0 without solving the question.
    2. Score is credited only if question is solved.

### 1.3.2 True False Questions
*Stage X-2 Questions are of this type.* <br>
The GameController for this scene contains a TrueFalseGameLogic script, with the following inputs. <br>
TrueFalseGameLogic Inputs | Description
------------ | -------------
Player1 | Reference to Player_1
Player2 | Reference to Player_2
Question | A text object under Screen Canvas that displays the question up for evaluation.
True Platform | A reference to the platform representing the True option.
False Platform | A reference to the platform representing the False option.
Max Random Number | Maximum number that the equation question values can take on.
Min Random Number | Minimum number that the equation question values can take on.

**Flow Chart** <br>
1. Stage Initialization
    1. Answer to the question is randomized between True or False. The platform with the answer is assigned the tag "CorrectAnswerA" while the other is assigned the tag "CorrectAnswerB" (in other words, the tag "CorrectAnswerB" represents the incorrect platform).
    2. Question type is randomly chosen between a statement question or a equation question.
    3. Should the question be a statement question, the question is drawn from either the "TrueQuestionBank" or the "FalseQuestionBank", depending on the answer to the question.
    4. Should the question be a equation question, two numbers are randomized using `Max Random Number` and `Min Random Number`. The two numbers will make up the equation to be displayed in the Question text object. If the answer is True, the sum displayed will be the sum of both numbers. If the answer is False, an offset number will be randomized between 1 to 4 and added to the total sum displayed (hence making the equation false).
2. Stage in Progress
    1. Timer from ScoreTimeManager script is started.
    2. Collision detection using the PlayerCollision script on the [Player](https://github.com/marcuslim835/co-opeDown#123-player-object) object to detect which platform the player is standing on.
3. Stage End
    1. Both players stands on the same platform (which is verified using the `isCorrectA` and `isCorrectB` booleans on the Player object by the TrueFalseGameLogic script) **OR** Timer runs down to 0 without solving the question.
    2. Score is credited only if question is solved.

### 1.3.3 Catch the Object
*Stage X-3 Tasks are of this type.* <br>

### 1.3.4 Button Shooting Questions
*Stage X-4 Questions are of this type.* <br>

### 1.3.5 Knowing Each Other Questions
*Stage X-5 Questions are of this type.* <br>

### 1.3.6 "Boss Fight"
*Stage X-6 Tasks are of this type.* <br>

# Credits
Movement script is based on the one provided by Unity as part of their Standard Assets.
