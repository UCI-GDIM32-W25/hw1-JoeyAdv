[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

How would you describe this game world in objects?
- Player, plant, ui planted, ui remaining
What attributes and actions do these objects have?
- Player
    -Attributes: sprite
    -Actions: 
        -Move
            -Input: WASD
            -Output: player changes location
        - Plant
            -Input: Space key
            -Output: if seeds remaining, 1 seed planted at player location, ui planted increases and ui remaining decreases
- Plant: prefab, no actions
- Ui planted: text, text changes
- Ui remaining: text, text changes
How do these objects act on or affect each other
- Player: creates plant
- Ui planted: increases when player creates plant
- Ui remaining: decreases when player creates plant


## Devlog

In the first question of the break-down, Player connects to the player GameObject which the user controls, plant refers to the plant prefab, and the ui planted/remaining connects to the text GameObjects that are children under the Canvas parent GameObject. The move action under the player in the break-down refers to the if-else statements under the update function in the Player class that allows for character movement whenever the WASD keys are pressed. The plant action under the player in the break-down refers to the PlantSeed function that creates a plant prefab at the players location. This method is used whenver the user has pressed space and has seeds remaining. The section in the break-down that mentions the UI planted/remaining changing whenever a player creates a plant refers to the UpdateSeeds method in the PlantCountUI class that updates the text of the UI whenever a player creates a seed. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
