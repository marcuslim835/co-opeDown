# User Guide
1) [Overview](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#1-overview)
   1) [Setting up the Game](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#11-setting-up-the-game)
   2) [Player Controls](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#12-player-controls)
   3) [Scoring Mechanics](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#13-scoring-mechanics)
   4) [Difficulty Mechanics](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#14-difficulty-mechanics)
   5) [User Interface](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#15-user-interface)
   6) [Save/Load Mechanics](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#16-saveload-mechanics)
   7) [Highscore](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#17-highscore)
2) [Game Modes](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#2-game-modes)
   1) [Classic Mode](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#21-classic-mode)
      1) [Platform Questions](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#211-platform-questions)
      2) [True False Questions](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#212-true-false-questions)
      3) [Catch the Object](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#213-catch-the-object)
      4) [Button Shooting Questions](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#214-button-shooting-questions)
      5) [Knowing Each Other Questions](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#215-knowing-each-other-questions)
      6) ["Boss Fight"](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#216-boss-fight)
   2) [Endless Mode](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#22-endless-mode)
3) [Frequently Asked Questions](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#3-frequently-asked-questions)

## 1 Overview
The user guide is meant to provide brief information to the user about the game co-opeDown. For detailed information and explanation as to how the game works, proceed to the [Developer Guide](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#developer-guide "For developers who are interested in our implementation") below.

### 1.1 Setting up the Game
Refer to the [quick start guide](https://github.com/marcuslim835/co-opeDown/blob/main/README.md#1-quick-start-guide).

### 1.2 Player Controls
Player 1 Controls: WAD for movement, S to shoot <br>
Player 2 Controls: Arrow Keys (except Down Arrow) for movement, Down Arrow to shoot

### 1.3 Scoring Mechanics
Scoring can differ by the different stages. The general rule of thumb is that a stage complete gives a base score of 100, in addition to points given for speed (calculated using the time remaining when the stage is cleared).

### 1.4 Difficulty Mechanics
As the level increases, questions will progressively get harder. For example, in the case of [2.1.1](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#211-platform-questions), the numbers generated will increase from 20 in the first level to 60 in the final level. <br>
Apart from minor difficulty increases from levels, there are also 3 different difficulty levels for the game, namely "Easy", "Normal", and "Hard". These questions determines the type of questions generated. For example, in the case of [2.1.1](https://github.com/marcuslim835/co-opeDown/blob/main/UserGuide.md#211-platform-questions), addition questions are generated for "Easy", multiplication questions are generated for "Normal", and quadratic equations are generated for "Hard".

### 1.5 User Interface
The following is a labelled screenshot of the user interface that every user will see in the game.
<img width="1450" alt="UIExplainer" src="https://user-images.githubusercontent.com/77620616/122636872-1ff05400-d11e-11eb-85e3-aa2ee7992f43.png">
<img width="1450" alt="OptionsMenu" src="https://user-images.githubusercontent.com/77620616/126060977-91237fd4-a5d4-45bd-b5e9-c2c0d2804fcd.png">

### 1.6 Save/Load Mechanics
Users can save their game whenever they want to as long as they are in a game. The latest cleared stage, game mode, and game difficulty will be saved. <br>
Users can load their game from the main menu or while in a game. The stage loaded will be the stage directly following the latest cleared stage. However, due to certain [design considerations](https://github.com/marcuslim835/co-opeDown/blob/main/DeveloperGuide.md#4-design-considerations), questions will be re-generated everytime the game is loaded. <br>
Users can delete their save game by pressing "Delete Save" from the main menu or by simply saving another game on top of the existing save. <br>
<img width="1450" alt="MainSaveMenu" src="https://user-images.githubusercontent.com/77620616/126061083-34f1f664-4a5c-41aa-b8de-d1b9d66cff21.png">
<img width="1450" alt="SaveMenu" src="https://user-images.githubusercontent.com/77620616/126060980-4ac28078-04fb-4fd0-afcd-dd01c647688a.png">

### 1.7 Highscore
Users can view their highscores in the main menu. <br>
<img width="1450" alt="MainMenuHS" src="https://user-images.githubusercontent.com/77620616/126061147-0c22e7e4-1c4b-440a-89db-8e1561d8792a.png">

## 2 Game Modes
### 2.1 Classic Mode
All classic mode stages have a timer on them. Players should clear the stage before the timer expires to be able to get the score associated with clearing the stage.

#### 2.1.1 Platform Questions
<img width="1450" alt="1-1" src="https://user-images.githubusercontent.com/77620616/122509856-150ec400-d037-11eb-9845-62a2268ab9ed.png">
Move the chickens to 2 different platforms that follows the instructions displayed in the middle. <br>
Standing on the wrong platforms will not result in a "level fail". <br>
In the example provided, moving the rooster and hen to the platform for "12" and "10" would clear the level.

#### 2.1.2 True False Questions
<img width="1450" alt="1-2falsemath" src="https://user-images.githubusercontent.com/77620616/122638704-4915e200-d128-11eb-9bac-10eb51027681.png">
<img width="1450" alt="1-2falsestatement" src="https://user-images.githubusercontent.com/77620616/122638705-4a470f00-d128-11eb-96d2-4464c40a951c.png">
Both chickens should be standing on the same platform that answers the question displayed in the middle. <br>
Questions will either be in the form of a statement or an equation. <br>
Standing on the wrong platform will result in a "level fail" (game continues with no score added). <br>
In both examples provided, moving both the rooster and the hen to the platform labelled "False" would clear the level and earn points. Moving them to the platform labelled "True" would end the level and not earn points.

#### 2.1.3 Catch the Object
<img width="1450" alt="3-3" src="https://user-images.githubusercontent.com/77620616/122638989-01905580-d12a-11eb-8bb5-10bcfb04a47e.png">
Both chickens should try to collect the falling flasks by coming into contact with the flasks. <br>
Blue coloured flasks are worth twice as much as normal flasks, but fall faster than normal flasks. <br>

#### 2.1.4 Button Shooting Questions
<img width="1450" alt="3-4" src="https://user-images.githubusercontent.com/77620616/122659897-ef0c2f80-d1ae-11eb-93df-f4d467ade2ec.png">
The chickens should shoot the buttons such that the current sum reaches the number displayed in the middle. <br>
In the example provided, there are multiple solutions to the problem, one of which is shooting "+18" five times, "+13" once, and "-3" once.

#### 2.1.5 Knowing Each Other Questions
<img width="1450" alt="Screenshot 2021-06-22 at 1 19 24 AM" src="https://user-images.githubusercontent.com/77206005/122802556-115d9480-d2f8-11eb-84b5-bb6a3a6d3d92.png">
The players have to answer the questions by trying to choose the same answer that is most suited to the question given. <br>
In the example provided, they have to choose one of the three options that best suit the question within the 5 seconds time limit.

#### 2.1.6 "Boss Fight"
<img width="1450" alt="Screenshot 2021-06-22 at 1 25 39 AM" src="https://user-images.githubusercontent.com/77206005/122803155-d0b24b00-d2f8-11eb-886f-ce447c2a7765.png">
The chickens have to shoot the bats before the bats come into contact with them and decrease their HP. <br>
Landing shots at the bats will increase the score, while avoiding death from insufficient HP.

### 2.2 Endless Mode
<img width="1450" alt="E-E" src="https://user-images.githubusercontent.com/77620616/126061240-1785dbd8-8d72-4274-92f3-3aa11b10528b.png">
Move the chickens to 2 different platforms that follows the instructions displayed in the middle. <br>
Standing on the wrong platforms will not result in a "level fail". <br>
In the example provided, moving the rooster and hen to the platform for "12" and "3" would clear the level.

## 3 Frequently Asked Questions
**Q: The game is not launched in a 16:9 aspect ratio and hence looks weirdly proportioned.** <br>
A: For Windows users, locate the following registry key: HKEY_CURRENT_USER\SOFTWARE\co-opeDown\co-opeDown <br>
Then, delete the entire key and relaunch the app. <br>
The registry can be accessed by typing "regedit" into the search bar. <br>
For Mac users, delete the corresponding preferences file located in ~/Library/Preferences/unity
