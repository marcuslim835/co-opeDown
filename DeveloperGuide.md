# Developer Guide
1) [Overview](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#1-overview)
   1) [Setting up the Game](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#11-setting-up-the-game)
   2) [Player Controls](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#12-player-controls)
   3) [Scoring Mechanics](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#13-scoring-mechanics)
   4) [Difficulty Mechanics](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#14-game-difficulty-mechanics)
   5) [Level Mechanics](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#15-level-mechanics)
   6) [User Interface](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#16-user-interface)
   7) [Save/Load Mechanics](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#17-saveload-mechanics)
   8) [Highscore](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#18-highscore)
2) [Game Design](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#2-game-design)
   1) [General Game Flow](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#21-general-game-flow)
   2) [The DontDestroyOnLoad GameObject](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#22-the-dontdestroyonload-gameobject)
   3) [Player Object](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#23-player-object)
   4) [Transitions](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#24-transitions)
   5) [Tutorial](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#25-tutorial)
3) [Game Modes](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#3-game-modes)
   1) [Classic Mode](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#31-classic-mode)
      1) [Platform Questions](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#311-platform-questions)
      2) [True False Questions](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#312-true-false-questions)
      3) [Catch the Object](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#313-catch-the-object)
      4) [Button Shooting Questions](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#314-button-shooting-questions)
      5) [Knowing Each Other Questions](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#315-knowing-each-other-questions)
      6) ["Boss Fight"](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#316-boss-fight)
   2) [Endless Mode](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#32-endless-mode)
4) [Design Considerations](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#4-design-considerations)
5) [Testing](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#5-testing)
   1) [Unit and Integration Testing](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#51-unit-and-integration-testing)
   2) [System Testing](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#52-system-testing)
   3) [Exploratory Testing](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#53-exploratory-testing)
   4) [Self Heuristic Evaluation](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#54-self-heuristic-evaluation)
   5) [User Testing](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#55-user-testing)
6) [Software Engineering](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#6-software-engineering)
   1) [Version Control using Unity Teams](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#61-version-control-using-unity-teams)
   2) [Project Management](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#62-project-management)
   3) [Mistakes to Avoid](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#63-mistakes-to-avoid)

## 1 Overview
The developer guide is meant to provide detailed information and explaination into how the game co-opeDown works. For a brief guide, proceed to the [User Guide](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#user-guide "For Everyone").

### 1.1 Setting up the Game
Refer to the [quick start guide](https://github.com/marcuslim835/co-opeDown/blob/main/README.md#1-quick-start-guide).

### 1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot <br>

### 1.3 Scoring Mechanics
Scoring can differ by the different stages. <br>
Stage (where X is the level) | Scoring for Stage Clear | Scoring for Stage Fail / Timeout
------------ | ------------- | -------------
X-1 | 100 + seconds remaining on the clock | 0
X-2 | 100 + seconds remaining on the clock | 0
X-3 | 5 per normal flask, 10 per blue flask | 0
X-4 | 100 + seconds remaining on the clock | 0
X-5 | 20 per identical answer | 0
X-F | 100 + 5 per enemy killed | 0

### 1.4 Game Difficulty Mechanics
There are three difficulty levels in the game: Easy, Normal, and Hard. <br>

Difficulty for Stage 1 | Type of Questions
------------ | -------------
Easy | Addition
Normal | Multiplication
Hard | Polynomials

Difficulty for Stage 2 | Type of [Equation](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#312-true-false-questions "50% chance this type of question will be generated")
------------ | -------------
Easy | Addition
Normal | Multiplication
Hard | Multiplication and Exponents up to 2nd power

Note: For statement questions, questions from different question banks will be drawn based on the difficulty level.

Difficulty for Stage 3 | Chance of Blue Flask Spawning
------------ | -------------
Easy | 0.25
Normal | 0.5
Hard | 0.75

Difficulty for Stage 4 | Buttons with IsNegative boolean set to true
------------ | -------------
Easy | Number generated is subtracted away from the current sum.
Normal | Number generated is 5 times greater than the ones in Easy difficulty and is subtracted away from the current sum.
Hard | Number generated is multiplied to the current sum.

### 1.5 Level Mechanics
As the level increases, questions will progressively get harder. <br>
Levels for Stage 1 | Individual Platform Numbers Capped At
------------ | -------------
1-1 | 20
2-1 | 30
3-1 | 40
4-1 | 50
5-1 | 60

Levels for Stage 2 | Individual Numbers of [Equation](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#312-true-false-questions "50% chance this type of question will be generated") Capped At
------------ | -------------
1-2 | 20
2-2 | 30
3-2 | 40
4-2 | 50
5-2 | 60

Levels for Stage 3 | Spawn Gap between Flasks (in seconds)
------------ | -------------
1-3 | 2
2-3 | 1.6
3-3 | 1.2
4-3 | 0.8
5-3 | 0.5

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

### 1.6 User Interface
The following is a labelled screenshot of the user interface that every user will see in the game. <br>
Our UI Design follows the general design of many platformer games already out in the market, with essential information at the top and the settings button on the top-right corner. This aims to provide a sense of familiarity to players who were already in contact with other games of the platformer genre prior to co-opeDown. <br>
The implementation of the UI can be found in Section [2.2](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#22-the-dontdestroyonload-gameobject).
<img width="1450" alt="UIExplainer" src="https://user-images.githubusercontent.com/77620616/122636872-1ff05400-d11e-11eb-85e3-aa2ee7992f43.png">
<img width="1450" alt="OptionsMenu" src="https://user-images.githubusercontent.com/77620616/126060977-91237fd4-a5d4-45bd-b5e9-c2c0d2804fcd.png">

### 1.7 Save/Load Mechanics
There are three save slots available, each capable of storing game sessions in both Classic and Endless Mode. <br>
Save files will bring players back to the most recently completed stage. However, due to certain [design considerations](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#4-design-considerations), questions will be re-generated everytime the game is loaded. <br> 
Save files can be deleted only from the main menu but can be loaded in every single scene except the credits screen. <br>
The save/load system can be accessed from the options menu while in game, and from the "Load Game" button in the main menu. <br>

Save files are stored as PlayerPrefs, with each save file having 2 separate string PlayerPref values and 1 integer PlayerPref value to store the difficulty, game mode, and the current score respectively. <br>
PlayerPrefs are stored as a registry key for Windows, as a .plist file for MacOS, and using the browser's IndexedDB API for WebGL.
<img width="1450" alt="MainSaveMenu" src="https://user-images.githubusercontent.com/77620616/126061083-34f1f664-4a5c-41aa-b8de-d1b9d66cff21.png">
<img width="1450" alt="SaveMenu" src="https://user-images.githubusercontent.com/77620616/126060980-4ac28078-04fb-4fd0-afcd-dd01c647688a.png">

### 1.8 Highscore
Users can view their highscores in the main menu. <br>
Highscores are cross-checked with the current score in the credits screen and updated if applicable. <br>

Highscores are stored as 6 separate integer PlayerPrefs, with each representing a different game mode and game difficulty. <br>
PlayerPrefs are stored as a registry key for Windows, as a .plist file for MacOS, and using the browser's IndexedDB API for WebGL. <br>
<img width="1450" alt="MainMenuHS" src="https://user-images.githubusercontent.com/77620616/126061147-0c22e7e4-1c4b-440a-89db-8e1561d8792a.png">

## 2 Game Design

### 2.1 General Game Flow
![flow1](https://user-images.githubusercontent.com/77620616/122660850-3bf40400-d1b7-11eb-922b-5137b4869052.JPG)
![flow2](https://user-images.githubusercontent.com/77620616/122660851-3d253100-d1b7-11eb-89c2-441494ad41b8.JPG)

### 2.2 The DontDestroyOnLoad GameObject
The GameObject contains the User Interface for the game as well as scripts that are used across the entire game. This GameObject is never destroyed while the game is running and is passed from scene to scene.
Objects | Description
------------ | -------------
DisplayUI | The UI for the player that includes the level, score, timer, and settings.
OptionsMenuUI | The settings UI that is disabled by default and enabled when the settings button in DisplayUI is pressed.
NavigationOptions | Script for navigating between scenes that can be used by the different scenes (stages).
AudioManager | Script for playing music that changes depending on the scene.
ScoreTimeManager | Script for the score and timer in DisplayUI that can be used by the different scenes (stages).
OptionsMenu | Script that provides functionality to the OptionsMenuUI.

### 2.3 Player Object
Objects | Description
------------ | -------------
PlayerMovement | Script to give players ability to move left, right and jump up.
PlayerCollision | Script for collision detection in 2.3.1 and 2.3.2. Value of `isCorrectA` or `isCorrectB` changes to true if player is standing on platform with "CorrectAnswerA" or "CorrectAnswerB" tags respectively.
Weapon | Script used to eliminate enemies (bats) and trigger buttons when the weapon is triggered by the player towards the direction it is facing. 

### 2.4 Transitions
-WIP-

### 2.5 Tutorial

## 3 Game Modes
### 3.1 Classic Mode
All classic mode stages have a timer on them. Players should clear the stage before the timer expires to be able to get the score associated with clearing the stage.
Common Objects | Description
------------ | -------------
Main Camera | Scenes with non-motionless cameras contain a CameraTargets script that tracks the position (transform) of both player objects and adjusts the camera view to encompass both players by adjusting the zoom level through the field of view.
Background | As the name suggests, the background picture of the scene.
Tilemap | Used to place platforms, floor and position limits of the map.
World Canvas | Used to display the relevant information tied to the world (eg. labels for tiles or buttons).
Screen Canvas | Used to display the questions and counters related to the stage on the display for the player.
GameController | Contains the scripts specific to each stage. To be discussed in the following subsections.
Player_1/2 | As mentioned in [2.3](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#23-player-object).
GameObject | As mentioned in [2.2](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#22-the-dontdestroyonload-gameobject).

#### 3.1.1 Platform Questions
*Stage X-1 Questions are of this type.* <br>
The GameController for this scene contains a PlatformerGameLogic script, with the following inputs. <br>
PlatformerGameLogic Inputs | Description
------------ | -------------
Player1 | Reference to Player_1
Player2 | Reference to Player_2
Text List | A list of text under World Canvas that serves to display a unique number with every platform.
Sum | A text object under Screen Canvas that displays the sum needed for the player to clear the stage.
Instructions | A text object under Screen Canvas that displays the instructions for the stage.
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
    2. Collision detection using the PlayerCollision script on the [Player](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#23-player-object) object to detect if the player is standing on the correct platforms.
3. Stage End
    1. Players stands on the 2 chosen platforms (which is verified using the `isCorrectA` and `isCorrectB` booleans on the Player object by the PlatformerGameLogic script) **OR** Timer runs down to 0 without solving the question.
    2. Score is credited only if question is solved.

#### 3.1.2 True False Questions
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
    2. Collision detection using the PlayerCollision script on the [Player](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#23-player-object) object to detect which platform the player is standing on.
3. Stage End
    1. Both players stands on the same platform (which is verified using the `isCorrectA` and `isCorrectB` booleans on the Player object by the TrueFalseGameLogic script) **OR** Timer runs down to 0 without solving the question.
    2. Score is credited only if question is solved.

#### 3.1.3 Catch the Object
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

#### 3.1.4 Button Shooting Questions
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

#### 3.1.5 Knowing Each Other Questions
*Stage X-5 Questions are of this type.* <br>
The GameController for this scene contains a TrivialQuestionsGameLogic script, while the buttons (left/A, down/S, right/D) in the scene correlates with the 3 options present in the scenes to choose from. <br>
TrivialQuestionsGameLogic Inputs | Description
------------ | -------------
Question | A text object under Screen Canvas that displays the generated question from the question bank.
Platform A | A text object under Screen Canvas that displays the first option related to the question in `Question`.
Platform B | A text object under Screen Canvas that displays the second option related to the question in `Question`.
Platform C | A text object under Screen Canvas that displays the third option related to the question in `Question`.
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
    4. If they chose the same answer within the time limit, they get a point, else they do not get a point.
    5. If they exceed the time limit for that question, they will not get a point. The next question will be generated randomly.
    6. Questions asked before will not be asked again to prevent repeatedness.
3. Stage End
    1. All questions were answered **OR** Timer runs down to 0 on the last question.
    2. Score is credited to the number of questions answered correctly.


#### 3.1.6 "Boss Fight"
*Stage X-6 Tasks are of this type.* <br>
The GameController for this scene contains a PlatformGameLogicBoss script, while all the interactions in the scene each contains a PlayerHealth and EnemySpawner scripts, with the following inputs. <br>
PlatformGameLogicBoss Inputs | Description
------------ | -------------
Player1 | Reference to Player_1
Player2 | Reference to Player_2
Sum | A text object under Screen Canvas that displays the number of enemies killed.
Is Complete | A boolean that indicates whether the all bats are killed or time is up.
OnePlayerDied | A boolean that indicates whether one of the player dies from insufficient health.
TwoPlayersDied | A boolean that indicates true when two players dies from insufficient health.

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
    3. They can shoot jabs at the enemies to kill them, increasing their score (counting number of enemies killed).
    4. If they fail to kill enemies before they collide, their health decrease.
    5. If a player has no more health, the player dies and the game will still continue as long as there is a surviving player.
3. Stage End
    1. All enemies killed **OR** Both players died **OR** Timer runs down to 0.
    2. Score is credited to the number of enemies killed.

### 3.2 Endless Mode
-WIP-

## 4 Design Considerations
1. WIP
2. The rationale for using only four keys that are adjacent to each other is to facilitate the one-handed use of a single keyboard by two players to play the game, or for one person to control both characters simultaneously. Reducing the number of keys used to control the player to the bare minimum of 4 would make the controls easier for the user to learn, utilize, and remember.
3. The save/load system is designed to only save the most essential information about a user's session: score, game mode, and game difficulty. This was purposely designed this way to avoid the bottleneck of the read/write speed of save files and improve the user experience by making save/load times virtually zero. This comes with a drawback however, it being that any currently incompleted level will be randomly re-generated when the save file is loaded back in. We believe that this minor drawback in exchange for a better user experience is inconsequential, as shown by our user survey, where 60% of respondents believe that a fast save and load speed is more important than having the exact same question being generated when loading a save game. ![image](https://user-images.githubusercontent.com/77620616/126723304-bafbaf67-fc52-4861-9445-ba4918ce7666.png)

4. Some users may find that the difficulty progression from level to level could be much larger than expected. For example, on "Normal" mode, the numbers for Level 1-1 are generally around the low-100s, but increase to the mid-1000s nearing Level 5-1. This is not a bug, but rather an intended consequence of our approach to the educational aspect of co-opeDown. While reading up on the ways education can be made more efficient to students, we came across [an article](https://www.jstor.org/stable/44430322) that  suggests that a hands-on and verbal approach allows for more information to be retained by learners. That got us thinking: How are we going to make use of this information to create something that would be both hands-on and verbal? Sure enough, educational games are hands-on but they require no verbal communications, since calculations can be done mentally by oneself. To encourage players to verbalize their thought process, we decided to set the later levels at a difficulty that we believed normal players would not be able to do on their own. As such, players are forced to verbalize their thoughts and work with their partners to solve the questions, which fits our vision of a hands-on and verbal approach to educational games.

## 5 Testing
To ensure that the game that we are delivering is in tip-top condition, multiple forms of testing were employed throughout the coding process.

### 5.1 Unit and Integration Testing
Unit testing was done everytime changes to any script is made and published. Testing was done by adding the following code to the individual methods to print words into the console when in "Play" mode to ensure the method calls are executed correctly.
> Debug.Log("Words Here")

At the same time, integration testing was done everytime changes to any script attached to the [DontDestroyOnLoad Gameobject](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#22-the-dontdestroyonload-gameobject) or any script using Unity SceneManager is made and published. Testing was done using Unity Play Mode.

| No. | Encounter Date | Problem                                                                      | Solution |
| --- | -------------- | ---------------------------------------------------------------------------- | -------- |
| 1   | 27/5/2021      | Numbers on the platform in world view looks very blurry in world canvas      | Increase font size of text and reduce scaling of text to increase sharpness |
| 2   | 27/5/2021      | Camera cannot fit both players when both players move to extreme ends of map | Moved all UI elements to a screen view canvas instead of attaching to the camera. Zooming is based on FOV instead of orthographic size. |
| 3   | 18/6/2021      | <img width="350" alt="despawnError" src="https://user-images.githubusercontent.com/77620616/126296547-d2d090b5-ce89-449d-b7ae-702120c43ffa.png"> Flasks not despawning after hitting the ground in new levels with different tile textures | Tilemap readjusted to make sure the floor is below y = -3.35, since flasks are programmed to despawn at -3.35. |
| 4   | 18/6/2021      | Player sinking into  tilemap after tilemap is slightly edited                | Re-generate tilemap collider by unchecking and rechecking “Used by Composite” |
| 5   | 11/7/2021      | Transition is triggered more than once                                       | Turns out to be a [Unity Bug](https://answers.unity.com/questions/981044/animator-trigger-not-reseting-bug.html). Manually reset trigger using "animator.ResetTrigger("triggerName") |

### 5.2 System Testing
System Testing was conducted by both of us based on a list of inputs and expected behaviors that we had come up with prior to testing. The manual testing was done separately and independently from each other and collated into the “Actual Behavior” column. The system testing was conducted between 21 to 26 June and Test Cases 1 to 22 were run. <br>
**Compatibility Testing under System Testing:** An informal compatibility test was also done in the same time period with the help of some of our friends, where we asked them to run the game on their computers (different operating environments) to see if it works. No compatibility issues were found on Windows 10. A bug on the MacOS where UI and buttons were out of proportions was found since MacOS sometimes forces co-opeDown to launch in full screen mode. In response, all screen canvases were changed from fixed size to scaling with a reference size of 1920x1080. Screen resizing was disabled as well.

| No. | Scene | Input                                          | Expected Behavior                                                     | Actual Behavior         |
| --- | ----- | ---------------------------------------------- | --------------------------------------------------------------------- | ----------------------- |
| 1   | X-1   | Within time limit, correct platforms           | Clear stage, score added                                              | 2-1: Did not clear stage <br> Others: No deviation                                                                                                                         |
| 2   | X-1   | Within time limit, wrong platforms             | No response                                                           | No deviation            |
| 3   | X-1   | Within time limit, both stand on same platform | No response                                                           | No deviation            |
| 4   | X-1   | Reached time limit                             | End stage, no score added                                             | No deviation            |
| 5   | X-2   | Within time limit, both on correct platform    | Clear stage, score added                                              | No deviation            |
| 6   | X-2   | Within time limit, both on incorrect platform  | End stage, no score added                                             | No deviation            |
| 7   | X-2   | Within time limit, only 1 on either platform   | No response                                                           | No deviation            |
| 8   | X-2   | Reached time limit                             | End stage, no score added                                             | No deviation            |
| 9   | X-3   | No objects collected                           | No score added                                                        | No deviation            |
| 10  | X-3   | 2 blue flasks and 6 normal flasks collected    | 50 added to score (30 for Level 1-3)                                  | No deviation            |
| 11  | X-4   | Within time limit, correct sum reached         | Clear stage, score added                                              | No deviation            |
| 12  | X-4   | Within time limit, overshot correct sum        | No response                                                           | No deviation            |
| 13  | X-4   | Within time limit, reached negative value      | No response                                                           | No deviation            |
| 14  | X-4   | Reached time limit                             | End stage, no score added                                             | No deviation            |
| 15  | X-5   | Within time limit, both same answer            | Clear question, score to be added increased                           | No deviation            |
| 16  | X-5   | Within time limit, both different answer       | Clear question, score to be added remains the same                    | No deviation            |
| 17  | X-5   | Within time limit, one answer                  | No response                                                           | No deviation            |
| 18  | X-5   | Reached time limit                             | Clear question, score to be added remains the same                    | No deviation            |
| 19  | X-F   | Finish without deaths                          | Clear stage, score to be added according to number of bats vaccinated | X-F: Score added even though bats were not vaccinated <br> Otherwise: Stage is cleared/ended normally without deviation |
| 20  | X-F   | Finish with 1 death                            | Clear stage, score to be added according to number of bats vaccinated | Same as Above
| 21  | X-F   | 2 deaths                                       | End stage, score to be added according to number of bats vaccinated   | Same as Above
| 22  | X-F   | Finish without scoring                         | Clear stage, base score will still be added                           | No deviation            |

| Failed Test Case | Fixes Applied                                                                  |
| ---------------- | ------------------------------------------------------------------------------ |
| 1                | Colliders were adjusted on Level 2-1 to make collision detection more reliable |
| 19/20/21         | Scoring changed to ensure score is only added if bat collides with the bullet for Scenes X-F |

A second system testing was conducted before User Testing 1 on 17 June and Test Cases 1 to 22 were run thrice, once for each difficulty. No deviations were detected. In addition, Test Cases 23 to 26 were also run thrice, once for each difficulty to test the endless mode.

| No. | Scene | Input                                          | Expected Behavior                                                     | Actual Behavior         |
| --- | ----- | ---------------------------------------------- | --------------------------------------------------------------------- | ----------------------- |               
| 23  | E-E   | Within time limit, correct platforms           | Clear stage, score added, re-generate question with new parameters    | No deviation            |
| 24  | E-E   | Within time limit, wrong platforms             | End game, no score added                                              | No deviation            |
| 25  | E-E   | Within time limit, both stand on same platform | No response                                                           | No deviation            |
| 26  | E-E   | Reached time limit                             | End game, no score added                                              | No deviation            |

### 5.3 Exploratory Testing
Exploratory Testing was conducted by both of us after we had finished with system testing and are satisfied that scripted testing would be unlikely to surface any more bugs.

| No. | Scene | Input | Expected Behavior | Bugged Behavior | Bug Fixes |
| --- | ----- | ----- | ----------------- | --------------- | --------- |
| 1   | X-1   | Jumping at a platform from underneath it | No collision detected. | Collision was detected and level was cleared. | Platform colliders were moved upwards on the y-axis |
| 2   | 2-F   | Going to a tight spot on the bottom right of the map | Bats still able to pathfind to the chickens | ![pathfindError](https://user-images.githubusercontent.com/77620616/126062266-b2b4eb60-26c1-4eae-969e-2f11eb5bd776.png) | All stage X-F tilemaps were adjusted to ensure no tight spots are present so that the pathfinding AI is able to always reach the chicken |
| 3   | X-5   | Input answers before next question is generated | Score will not be added when there is no new questions yet | Score can be added, allowing possibility of total score > max score allowed. | Added additional checkpoint functions and booleans to prevent inputs on keyboard to affect the scoring system in the stage |
| 4   | 1-2   | None (basically just question generation) | Question properly displayed with apostrophe | ![aprostropheError](https://user-images.githubusercontent.com/77620616/126062281-4673fa4e-d385-4927-894c-d469c53febe9.png) | All symbols were removed from the true/false question banks |

### 5.4 Self Heuristic Evaluation
H2-1: Visibility of system status
1) Pressing shoot key triggers an animation to shoot
2) Movement keys causes player sprites to move

H2-2: Match system and real world
1) Settings icons used is universally recognized albeit customized
2) UI Layout is similar to those of the 2D platformer genre

H2-3: User control and freedom
1) Option to return to main menu or quit game present on all scenes, either through the settings menu or through a highly visible labelled button

H2-4: Consistency and standards
1) Same canvas used for the settings menu
2) Same canvas used for in game UI
3) Same animations used for stage transitions

H2-5: Error prevention
1) System and Exploratory Testing done to eliminate prominent bugs

H2-6: Recognition rather than recall
1) Instructions for every stage displayed clearly in the middle of the screen

H2-7: Flexibility and efficiency of use
1) Only 4 keys used per player

H2-8: Aesthetic and minimalist design
1) Instructions kept as concise as possible

H2-9: Help users recognize, diagnose and recover from errors
1) N/A

H2-10: Help and documentation
1) User and Developer Guides are provided with the game download

### 5.5 User Testing

## 6 Software Engineering

### 6.1 Version Control using Unity Teams
Due to the pandemic, we have decided that we are going to code from home wherever possible and reduce in person meetings. As such, there was a need to practice version control to manage our codes properly. There were two main options available to us, namely branching with Git or Unity Collaborate in Unity Teams. Compared to the steep learning curve that Git has in store for us, we settled on the Unity Collaborate due to its flexibility and its ability to revert code changes, which has allowed us to hit the ground running while still learning and coming up with project management and version control guidelines for use between the both of us. <br>
Since then, we have agreed on several things before we publish code on Unity Collaborate (aka commit code for GitHubbers). As mentioned in [5.1](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#51-unit-and-integration-testing), unit and integration testing has to be performed and passed for the scenes that have been modified or added to ensure that no unwanted code that could introduce unwanted bugs are published. After a code publish by one of us, the other party syncs the published code and reviews whether the code does what it is meant to do. Otherwise, the older version is restored and the code publisher is notified to make changes. Below is a screenshot of what our typical Unity Collaborate version history looks like.
![image](https://user-images.githubusercontent.com/77620616/125154294-e85c5100-e18b-11eb-84e7-4b8d8e6bae45.png)

### 6.2 Project Management
To totally eliminate the risk of publishing errors that may arise from bugs in Unity Collaborate, we have assigned WIPWIP

### 6.3 Mistakes to Avoid
In light of some of our easily avoidable missteps, we find that it would be beneficial to future teams for us to list out some mistakes that are avoidable but have been made by us. <br>
1) Instead of creating a unity project on a GitHub repository folder, we have mistakenly believed that the GitHub repository should contain only exported builds of co-opeDown. A quick google search for Unity2D projects on GitHub would reveal that is not the case -- most of those repositories in fact contain raw Unity Project Files. We have since corrected that mistake and aligned our repository to the norm.
2) Instead of uploading the GitIgnore file after all Unity files have been uploaded, the GitIgnore file should be added before, since it does not retroactively apply to already indexed files.
