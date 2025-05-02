# User Stories for Darts Assistant

## Add Player
**AS A:** user  
**WANT TO:** add player to the game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in the game creation window | I input the player details            | The player should be successfully added to the game |

## Set Game Mode
**AS A:** user  
**WANT TO:** set the game mode  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in the game creation window | I select a game mode from the list of gamemodes           | The desired mode should be confirmed |

## Add Bot
**AS A:** user  
**WANT TO:** add a bot to the game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in the game creation window       | I choose to add a bot                 | Set bot difficulty pops up |

## Set Bot Difficulty
**AS A:** user  
**WANT TO:** set the difficulty level of the bot  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I chose to add a bot       | I select a difficulty level           | The bot with the desired difficulty is added to the game |

## Start Game
**AS A:** user  
**WANT TO:** start the game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| All required setup (players, game mode, etc.) | I start the game                      | The game should begin |

## Track Score
**AS A:** user  
**WANT TO:** track the score during the game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in a game             | I check the score                     | The score should be updated and displayed correctly |

## Track Throws
**AS A:** user  
**WANT TO:** track the throws during the game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in a game                 | I record a throw                      | The system should record and display the throws accurately |

## Check Statistics
**AS A:** user  
**WANT TO:** check game statistics  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in a game      | I select to view statistics           | Detailed and accurate game stats should be displayed |

## Check Checkout Table
**AS A:** user  
**WANT TO:** check the checkout table  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in a game                  | I check the checkout table            | Recommended checkout options should be displayed |

## Save Game
**AS A:** user  
**WANT TO:** save the current game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in a game                 | I choose to save the game             | The game state should be stored for future use |

## Load Game
**AS A:** user  
**WANT TO:** load a previously saved game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in the main menu             | I select load save, and select a saved game                 | The selected game should be restored |

## Check Game History
**AS A:** user  
**WANT TO:** check my game history  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in the main menu      | I check the game history              | A list of previous games and their details should be displayed |

## End Game
**AS A:** user  
**WANT TO:** end the game  

| GIVEN          | WHEN                             | THEN                                   |
|-----------------|----------------------------------|----------------------------------------|
| I'm in a game       | I choose to end the game              | The game should conclude and display the final results |