# co-opeDown
Orbital 2021 Apollo 11 Project <br>
Developed using Unity 2020.3.7f1 <br>

[1. User Guide](https://github.com/marcuslim835/co-opeDown#1-user-guide "For Everyone")

[2. Developer Guide](https://github.com/marcuslim835/co-opeDown#2-developer-guide "For developers who are interested in our implementation")

[3. Credits](https://github.com/marcuslim835/co-opeDown#3-credits "Many Thanks!")

# 1 User Guide
## 1.1 Overview
The user guide is meant to provide brief information to the user about the game co-opeDown. For detailed information and explanation as to how the game works, proceed to the [Developer Guide](https://github.com/marcuslim835/co-opeDown#2-developer-guide "For developers who are interested in our implementation") below.

### 1.1.1 Installing the Game
For Windows Users: Download the "Windows" folder and run co-opeDown.exe to play the demo. <br>
For Mac Users: Download the "MacOS" folder and run the co-opeDown app to play the demo.

### 1.1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot

### 1.1.3 Scoring Mechanics
Scoring can differ by the different stages. The general rule of thumb is that a stage complete gives a base score of 100, in addition to points given for speed (calculated using the time remaining when the stage is cleared). More details can be found in the [Developer Guide](https://github.com/marcuslim835/co-opeDown#2-developer-guide "For developers who are interested in our implementation").

### 1.1.4 Level Mechanics
As the level increases, questions will progressively get harder. For example, in the case of 1.2.1, the numbers generated will increase from 20 in the first level to 60 in the final level. More details can be found in the [Developer Guide](https://github.com/marcuslim835/co-opeDown#2-developer-guide "For developers who are interested in our implementation").

### 1.1.5 User Interface
The following is a labelled screenshot of the user interface that every user will see in the game.
<img width="756" alt="UIExplainer" src="https://user-images.githubusercontent.com/77620616/122636872-1ff05400-d11e-11eb-85e3-aa2ee7992f43.png">
<img width="753" alt="OptionsMenu" src="https://user-images.githubusercontent.com/77620616/122636873-21218100-d11e-11eb-9f91-09d8b349a21a.png">

### 1.1.6 Save/Load Mechanics
The saving and loading system is currently not yet implemented and will be implemented by Milestone 3.

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
<img width="957" alt="3-3" src="https://user-images.githubusercontent.com/77620616/122638989-01905580-d12a-11eb-8bb5-10bcfb04a47e.png">
Both chickens should try to collect the falling flasks by coming into contact with the flasks. <br>
Blue coloured flasks are worth twice as much as normal flasks, but fall faster than normal flasks. <br>

### 1.2.4 Button Shooting Questions
<img width="960" alt="3-4" src="https://user-images.githubusercontent.com/77620616/122659897-ef0c2f80-d1ae-11eb-93df-f4d467ade2ec.png">
The chickens should shoot the buttons such that the current sum reaches the number displayed in the middle. <br>
In the example provided, there are multiple solutions to the problem, one of which is shooting "+18" five times, "+13" once, and "-3" once.

### 1.2.5 Knowing Each Other Questions
<img width="961" alt="Screenshot 2021-06-22 at 1 19 24 AM" src="https://user-images.githubusercontent.com/77206005/122802556-115d9480-d2f8-11eb-84b5-bb6a3a6d3d92.png">
The players have to answer the questions by trying to choose the same answer that is most suited to the question given. <br>
In the example provided, they have to choose one of the three options that best suit the question within the 5 seconds time limit.

### 1.2.6 "Boss Fight"
<img width="960" alt="Screenshot 2021-06-22 at 1 25 39 AM" src="https://user-images.githubusercontent.com/77206005/122803155-d0b24b00-d2f8-11eb-886f-ce447c2a7765.png">
The chickens have to shoot the bats before the bats come into contact with them and decrease their HP. <br>
Landing shots at the bats will increase the score, while avoiding death from insufficient HP.

# 2 Developer Guide
## 2.1 Overview
The developer guide is meant to provide detailed information and explaination into how the game co-opeDown works. For a brief guide, proceed to the [User Guide](https://github.com/marcuslim835/co-opeDown#1-user-guide "For Everyone") above.

### 2.1.1 Installing the Game
For Windows Users: Download the "Windows" folder and run co-opeDown.exe to play the demo. <br>
For Mac Users: Download the "MacOS" folder and run the co-opeDown app to play the demo. 

### 2.1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot <br>
The rationale for using only four keys that are adjacent to each other is to facilitate the one-handed use of a single keyboard by two players to play the game, or for one person to control both characters simultaneously.

### 2.1.3 Scoring Mechanics
Scoring can differ by the different stages. <br>
Stage (where X is the level) | Scoring for Stage Clear | Scoring for Stage Fail / Timeout
------------ | ------------- | -------------
X-1 | 100 + seconds remaining on the clock | 0
X-2 | 100 + seconds remaining on the clock | 0
X-3 | 5 per normal flask, 10 per blue flask | 0
X-4 | 100 + seconds remaining on the clock | 0
X-5 | 20 per identical answer | 0
X-F | 100 + 5 per enemy killed | 0

### 2.1.4 Level Mechanics
As the level increases, questions will progressively get harder. <br>
Levels for Stage 1 | Individual Platform Numbers Capped At
------------ | -------------
1-1 | 20
2-1 | 30
3-1 | 40
4-1 | 50
5-1 | 60

Levels for Stage 2 | Individual Numbers of [Equation](https://github.com/marcuslim835/co-opeDown#232-true-false-questions) Capped At
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

Levels for Stage 5 | Number of Questions 
------------ | ------------- 
1-5 | 5
2-5 | 5
3-5 | 5
4-5 | 5
5-5 | 5

Levels for Final Stage | Number of Bats | Number of Hits before death for each player | Enemy Spawn Rate (per Enemy in Seconds)
------------ | ------------- | ------------- | -------------
1-F | 40 | 20 | 4
2-F | 40 | 17 | 3
3-F | 40 | 14 | 2
4-F | 40 | 11 | 1.7
5-F | 40 | 9 | 1.5

### 2.1.5 User Interface
The following is a labelled screenshot of the user interface that every user will see in the game. <br>
Our UI Design follows the general design of many platformer games already out in the market, with essential information at the top and the settings button on the top-right corner. This aims to provide a sense of familiarity to players who were already in contact with other games of the platformer genre prior to co-opeDown.
<img width="756" alt="UIExplainer" src="https://user-images.githubusercontent.com/77620616/122636872-1ff05400-d11e-11eb-85e3-aa2ee7992f43.png">
<img width="753" alt="OptionsMenu" src="https://user-images.githubusercontent.com/77620616/122636873-21218100-d11e-11eb-9f91-09d8b349a21a.png">

### 2.1.6 Save/Load Mechanics
The saving and loading system is currently not yet implemented and will be implemented by Milestone 3.

## 2.2 Game Design

### 2.2.1 General Game Flow
![flow1](https://user-images.githubusercontent.com/77620616/122660850-3bf40400-d1b7-11eb-922b-5137b4869052.JPG)
![flow2](https://user-images.githubusercontent.com/77620616/122660851-3d253100-d1b7-11eb-89c2-441494ad41b8.JPG)

### 2.2.2 The DontDestroyOnLoad GameObject
The GameObject contains the User Interface for the game as well as scripts that are used across the entire game. This GameObject is never destroyed while the game is running and is passed from scene to scene.
Objects | Description
------------ | -------------
DisplayUI | The UI for the player that includes the level, score, timer, and settings.
OptionsMenuUI | The settings UI that is disabled by default and enabled when the settings button in DisplayUI is pressed.
NavigationOptions | Script for navigating between scenes that can be used by the different scenes (stages).
AudioManager | Script for playing music that changes depending on the scene.
ScoreTimeManager | Script for the score and timer in DisplayUI that can be used by the different scenes (stages).
OptionsMenu | Script that provides functionality to the OptionsMenuUI.

<img width="756" alt="UIExplainer" src="https://user-images.githubusercontent.com/77620616/122636872-1ff05400-d11e-11eb-85e3-aa2ee7992f43.png">
<img width="753" alt="OptionsMenu" src="https://user-images.githubusercontent.com/77620616/122636873-21218100-d11e-11eb-9f91-09d8b349a21a.png">

### 2.2.3 Player Object
Objects | Description
------------ | -------------
PlayerMovement | Used to give players ability to move left, right and jump up.
PlayerCollision | Used for collision detection in 2.3.1 and 2.3.2. Value of `isCorrectA` or `isCorrectB` changes to true if player is standing on platform with "CorrectAnswerA" or "CorrectAnswerB" tags respectively.
Weapon | Used to kill enemys (bats) and press buttons when the weapon is executed by the player towards the direction it is facing. 

## 2.3 Stages
All stages have a timer on them. Players should clear the stage before the timer expires to be able to get the score associated with clearing the stage.
Common Objects | Description
------------ | -------------
Main Camera | Scenes with non-motionless cameras contain a CameraTargets script that tracks the position (transform) of both player objects and adjusts the camera view to encompass both players by adjusting the zoom level through the field of view.
Background | As the name suggests, the background picture of the scene.
Tilemap | Used to place platforms, floor and position limits of the map.
World Canvas | Used to display the relevant information tied to the world (eg. labels for tiles or buttons).
Screen Canvas | Used to display the questions and counters related to the stage on the display for the player.
GameController | Contains the scripts specific to each stage. To be discussed in the following subsections.
Player_1/2 | As mentioned in [2.2.3](https://github.com/marcuslim835/co-opeDown#223-player-object).
GameObject | As mentioned in [2.2.2](https://github.com/marcuslim835/co-opeDown#222-the-dontdestroyonload-gameobject).

### 2.3.1 Platform Questions
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

**Flow of Level** <br>
1. Stage Initialization
    1. 2 platforms are randomly chosen to be the ones with the correct answer. They are assigned with the tags "CorrectAnswerA" and "CorrectAnswerB".
    2. Unique numbers are randomly generated for the 2 chosen platforms using `Max Random Number`, `Min Random Number A`, and `Min Random Number B`. The sum of the 2 numbers are assigned to the text object `Sum`.
    3. Unique numbers that cannot be added together to give the correct sum are randomly generated for the remaining platforms using `Max Random Number` and `Min Random Number A`.
2. Stage in Progress
    1. Timer from ScoreTimeManager script is started.
    2. Collision detection using the PlayerCollision script on the [Player](https://github.com/marcuslim835/co-opeDown#223-player-object) object to detect if the player is standing on the correct platforms.
3. Stage End
    1. Players stands on the 2 chosen platforms (which is verified using the `isCorrectA` and `isCorrectB` booleans on the Player object by the PlatformerGameLogic script) **OR** Timer runs down to 0 without solving the question.
    2. Score is credited only if question is solved.

### 2.3.2 True False Questions
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

**Flow of Level** <br>
1. Stage Initialization
    1. Answer to the question is randomized between True or False. The platform with the answer is assigned the tag "CorrectAnswerA" while the other is assigned the tag "CorrectAnswerB" (in other words, the tag "CorrectAnswerB" represents the incorrect platform).
    2. Question type is randomly chosen between a statement question or an equation question.
    3. Should the question be a statement question, the question is drawn from either the "TrueQuestionBank" or the "FalseQuestionBank", depending on the answer to the question.
    4. Should the question be a equation question, two numbers are randomized using `Max Random Number` and `Min Random Number`. The two numbers will make up the equation to be displayed in the Question text object. If the answer is True, the sum displayed will be the sum of both numbers. If the answer is False, an offset number will be randomized between 1 to 4 and added to the total sum displayed (hence making the equation false).
2. Stage in Progress
    1. Timer from ScoreTimeManager script is started.
    2. Collision detection using the PlayerCollision script on the [Player](https://github.com/marcuslim835/co-opeDown#223-player-object) object to detect which platform the player is standing on.
3. Stage End
    1. Both players stands on the same platform (which is verified using the `isCorrectA` and `isCorrectB` booleans on the Player object by the TrueFalseGameLogic script) **OR** Timer runs down to 0 without solving the question.
    2. Score is credited only if question is solved.

### 2.3.3 Catch the Object
*Stage X-3 Tasks are of this type.* <br>
The GameController for this scene contains a FallingStageGameLogic script, with the following inputs. <br>
FallingStageGameLogic Inputs | Description
------------ | -------------
Player1 | Reference to Player_1
Player2 | Reference to Player_2
Slow Drop Object | A prefab of the normal flask.
Fast Drop Object | A prefab of the blue flask.
Chance of Fast | Probability at which a blue flask is instantiated.
Spawn Gap | Amount of time gap between every flask instantiation.
Score Display | A text object under Screen Canvas that displays the number of flasks caught.

**Flow of Level** <br>
1. Stage in Progress
    1. Timer from ScoreTimeManager script is started.
    2. A slow drop object or fast drop object is randomly chosen to be instantiatied based on the `Chance of Fast` variable.
    3. The drop object is instantiated at a height of y=8 and a random x value that spans the length of the stage.
    4. The drop object has a gravity scale of 1 to 1.5 for a fast drop object and 0.25 to 0.75 for a slow drop object, which is randomly determined by the DroppedObjectLogic script tagged to the drop objects.
    5. Collision detection using the DroppedObjectLogic script on the prefab of the slow drop object and the fast drop object to detect if a player has collided with it.
    6. If a player collides with the dropped object before it hits the ground, the dropped object is destroyed and the number of flasks caught increases by 1 if the flask is a slow drop object (normal flask) or by 2 if the flask is a fast drop object (blue flask).
    7. If no player collides with the dropped object and it hits the ground, the dropped object is destroyed.
2. Stage End
    1. Timer runs down to 0.
    2. The number of flasks caught is multiplied by 5 and credited to the total score.

### 2.3.4 Button Shooting Questions
*Stage X-4 Questions are of this type.* <br>
The GameController for this scene contains a PlusMinusGameLogic script while all the buttons in the scene each contains a ButtonCollision script, with the following inputs. <br>
PlusMinusGameLogic Inputs | Description
------------ | -------------
Target Sum | A text object under Screen Canvas that displays the target number needed by the current number for the player to clear the stage.
Current Sum | A text object under Screen Canvas that displays the current number.

ButtonCollision Inputs | Description
------------ | -------------
Is Negative | A boolean that indicates whether the button has a negative value.
Max Num | Maximum number that the button values can take on.
Min Num | Minimum number that the button values can take on.
Max Multiplier | Maximum multiplier that the button values are multiplied to to get the target sum. Set at 6 for positive button values and 3 for negative button values.
Min Multiplier | Minimum multiplier that the button values are multiplied to to get the target sum. Set at 3 for positive button values and 1 for negative button values.
Game Logic | Reference to PlusMinusGameLogic script to modify Target Sum and Current Sum.
Num Value | A text object under World Canvas that displays the value of the button.

**Flow of Level** <br>
1. Stage Initialization
    1. All buttons are randomly given a number between `Max Num` and `Min Num`, with the `Is Negative` boolean deciding whether the number is negative or positive.
    2. All button values are multiplied to a randomly generated multiplier between `Max Multiplier` and `Min Multiplier`, with each value getting an independently generated multiplier. The multiplied values are added to the `Target Sum`.
2. Stage in Progress
    1. Timer from ScoreTimeManager script is started.
    2. Collision detection using the ButtonCollision script on the button to see if the bullet shot by the player strikes the button.
    3. If a bullet strikes the button, the value associated with the button is added to the `Current Sum`.
3. Stage End
    1. Players make the `Current Sum` equal to the `Target Sum` **OR** Timer runs down to 0 without solving the question.
    2. Score is credited only if question is solved.

### 2.3.5 Knowing Each Other Questions
*Stage X-5 Questions are of this type.* <br>
The GameController for this scene contains a TrivialQuestionsGameLogic script, while all the buttons (left, down, right) in the scene correlates with the 3 options present in the scenes to choose from. <br>
TrivialQuestionsGameLogic Inputs | Description
------------ | -------------
Question | A text object under Screen Canvas that displays the generated question from the question bank.
Platform A | A text object under Screen Canvas that displays the first option related to the question in Question.
Platform B | A text object under Screen Canvas that displays the second option related to the question in Question.
Platform C | A text object under Screen Canvas that displays the third option related to the question in Question.
Sum | A text object under Screen Canvas that displays the number of questions correctly answered.
Timer | A text object under Screen Canvas that displays countdown for the question to be answered by.
Total Number Of Questions Asked | A text object under Screen Canvas that displays the number of questions answered thus far.

**Flow of Level** <br>
1. Stage Initialization
    1. A question is generated randomly from the question bank and the 3 options are populated in the scene, ready to be answered.
2. Stage in Progress
    1. Timer from ScoreTimeManager script is started.
    2. Key detection using the standard key input on the buttons to see if each player has placed their answer.
    3. If a button key is pressed by each player, the timer will stop, the script will detect if they chose the same answer.
    4. If they chose the same answer within the time limit, they get a point, else if the chose different answers they do not get a point.
    5. If they exceed the time limit for that question, they will not get a point. The next question will be generated randomly.
    6. Questions asked before will not be asked again to prevent repeatedness.
3. Stage End
    1. All questions were answered **OR** Timer runs down to 0 on the last question.
    2. Score is credited to the number of questions answered correctly.


### 2.3.6 "Boss Fight"
*Stage X-6 Tasks are of this type.* <br>
The GameController for this scene contains a PlatformGameLogicBoss script, while all the interactions in the scene each contains a PlayerHealth and EnemySpawner scripts, with the following inputs. <br>
PlatformGameLogicBoss Inputs | Description
------------ | -------------
Player1 | Reference to Player_1
Player2 | Reference to Player_2
Sum | A text object under Screen Canvas that displays the number of enemies killed.
Is Complete | A boolean that indicates whether the all bats are killed or time is up.
OnePlayerDied | A boolean that indicates whether one of the player died from insufficient health.
TwoPlayersDied | A boolean that indicates true when two players died from insufficient health.

PlayerHealth Inputs | Description
------------ | -------------
Max Health | Maximum health for the player.
Current Health | Current health of the player throughout the gameplay in the scene.
Health Bar |Reference to the health object of the player, displaying the hp below the player.

EnemySpawner Inputs | Description
------------ | -------------
Enemy | Reference to the enmey object to follow players.
Spawn Rate | Number of enemy objects released per second.
Number Of Monsters | Count of number of enemies released so far.

**Flow of Level** <br>
1. Stage Initialization
    1. Timer from ScoreTimeManager script is started.
2. Stage in Progress
    1. Enemies are relased as per spawn rate and uses an AI script to track the location of the players.
    2. Players will move to dodge the enemy.
    3. They can shoot jabs into the enemies to kill them, increasing their score (counting number of enemies killed).
    4. If they fail to dodge and kill enemies before they collide, their health decrease.
    5. If they have no more health, they die while game continues as long as there is a surviving player.
3. Stage End
    1. All enemies killed **OR** Both players died **OR** Timer runs down to 0.
    2. Score is credited to the number of enemies killed.

# 3 Credits
We would like to thank Lanturnip, ScheduleNeuron, tOThEmOoN, and our advisor Gerald for providing helpful evaluations of our project.

Movement script is based on the one provided by Unity as part of their Standard Assets.

Corona by Alexander Nakarada | https://www.serpentsoundstudios.com <br>
Music promoted by https://www.chosic.com/ <br>
Attribution 4.0 International (CC BY 4.0) <br>
https://creativecommons.org/licenses/by/4.0/

Main Theme (Overture) | The Grand Score by Alexander Nakarada | https://www.serpentsoundstudios.com <br>
Music promoted by https://www.chosic.com/ <br>
Attribution 4.0 International (CC BY 4.0) <br>
https://creativecommons.org/licenses/by/4.0/

Adventure by Alexander Nakarada | https://www.serpentsoundstudios.com <br>
Music promoted by https://www.chosic.com/ <br>
Attribution 4.0 International (CC BY 4.0) <br>
https://creativecommons.org/licenses/by/4.0/

Brazilian Street Fight by Punch Deck | https://soundcloud.com/punch-deck <br>
Music promoted by https://www.chosic.com <br>
Creative Commons Attribution 3.0 Unported License <br>
https://creativecommons.org/licenses/by/3.0/deed.en_US

Fragile by Keys of Moon | https://soundcloud.com/keysofmoon <br>
Attribution 4.0 International (CC BY 4.0) <br>
https://creativecommons.org/licenses/by/4.0/ <br>
Music promoted by https://www.chosic.com/

White Petals by Keys of Moon | https://soundcloud.com/keysofmoon <br>
Attribution 4.0 International (CC BY 4.0) <br>
https://creativecommons.org/licenses/by/4.0/ <br>
Music promoted by https://www.chosic.com/

Other Music <br>
Creative Commons Public License
