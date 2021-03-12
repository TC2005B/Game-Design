# **Virus World**

## _Game Design Document_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

##### **Copyright notice / author information / boring legal stuff nobody likes**

##
## _Index_

 ![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)Index

1. [Index](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.tn44c9jbklu6)
2. [Game Design](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.vh7mr3wp9gub)
  1. [Summary](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.y0z7a3kyjoqj)
  2. [Gameplay](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.q89snwy3vllo)
  3. [Mindset](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.3j0sjjj4v19l)
3. [Technical](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.nw2pvrargt85)
  1. [Screens](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.5baplgyo85eh)
  2. [Controls](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.4u55u65bonjw)
  3. [Mechanics](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.vrkne3rhovuh)
4. [Level Design](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.mun66rmbl34h)
  1. [Themes](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.feu141lpqdpj)
    1. Ambience
    2. Objects
      1. Ambient
      2. Interactive
    3. Challenges
  2. [Game Flow](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.lrp1xr74olld)
5. [Development](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.k64sfnylstdx)
  1. [Abstract Classes](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.fwz93u72nlt2)
  2. [Derived Classes](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.9mr6xhrqo7o4)
6. [Graphics](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.7fniby1a9lf0)
  1. [Style Attributes](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.3ui65x9w2r9w)
  2. [Graphics Needed](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.cdq39znqma9y)
7. [Sounds/Music](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.p0zdtpym1l8)
  1. [Style Attributes](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.g829e5h0mi8e)
  2. [Sounds Needed](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.1k2k1v9771k6)
  3. [Music Needed](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.coz0pe9ii0ek)
8. [Schedule](https://docs.google.com/document/d/1ct5-qyUZC9cAKn-iLUgtOczDkERmPzNNwPLDfT9Hgjs/preview#bookmark=kix.ur637w5onhwq)

## _Game Design_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

## Summary

Nuestro juego consistirá en dos partes esenciales, exploración en un mapa principal y puzzles en diferentes estructuras del mismo.

## Gameplay

El jugador empezará en un mapa explorable, donde encontrará diversas estructuras, que representan componentes electrónicos de una computadora, se podrá acceder a estas estructuras donde el jugador se encontrará ante diversos puzzles que representarán de una manera interactiva el funcionamiento de cada uno de estos componentes.

## Mindset

Se busca que el jugador tenga interés por ir descubriendo/desbloqueando el mapa, se hará un mapa agradable e interesante para que el usuario desea saber qué más hay, qué otros desafíos puede enfrentar o qué secretos puede encontrar, al empezar el mapa no explorado tendrá un sombreado que será removido al momento que el jugador explore cierta zona, de igual manera habrá partes bloqueadas del mapa que solo serán accesibles al completar cierta cantidad de puzzles. 

## _Technical_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

## Screens

1. Title Screen
  1. Options
2. Level Select
3. Game
  1. Inventory
  2. Assessment / Next Level
4. End Credits

_(example)_

## Controls


How will the player interact with the game? Will they be able to choose the controls? What kind of in-game events are they going to be able to trigger, and how? (e.g. pressing buttons, opening doors, etc.)

## Mechanics

Are there any interesting mechanics? If so, how are you going to accomplish them? Physics, algorithms, etc.

## _Level Design_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

_(Note : These sections can safely be skipped if they&#39;re not relevant, or you&#39;d rather go about it another way. For most games, at least one of them should be useful. But I&#39;ll understand if you don&#39;t want to use them. It&#39;ll only hurt my feelings a little bit.)_

## Themes

1. Motherboard
  1. Mood
    1. Calm, neutral
  2. Objects
    1. _Ambient_
      1. Fireflies
      2. Beams of moonlight
      3. Tall grass
    2. _Interactive_
      1. Components
      2. Breakable objects
      3. Non-breakable objects
2. RAM
  1. Mood
    1. Confusing, active
  2. Objects
    1. _Ambient_
      1. Labyrinth walls
    2. _Interactive_
      1. RAM
_(example)_

## Game Flow

1. Player starts in the motherboard
2. The player can move with the arrow keys
3. The player can explore freely the motherboard seeking for components
4. Player encounters a component and enters it
5. *Each component will have different mechanics

_(example)_

## _Development_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

## Abstract Classes / Components

1. BasePhysics
  1. BasePlayer
  2. BaseEnemy
  3. BaseObject
2. BaseObstacle
3. BaseInteractable

_(example)_

## Derived Classes / Component Compositions

1. BasePlayer
  1. PlayerMain
  2. PlayerUnlockable
2. BaseEnemy
  1. EnemyWolf
  2. EnemyGoblin
  3. EnemyGuard (may drop key)
  4. EnemyGiantRat
  5. EnemyPrisoner
3. BaseObject
  1. ObjectRock (pick-up-able, throwable)
  2. ObjectChest (pick-up-able, throwable, spits gold coins with key)
  3. ObjectGoldCoin (cha-ching!)
  4. ObjectKey (pick-up-able, throwable)
4. BaseObstacle
  1. ObstacleWindow (destroyed with rock)
  2. ObstacleWall
  3. ObstacleGate (watches to see if certain buttons are pressed)
5. BaseInteractable
  1. InteractableButton

_(example)_

## _Graphics_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

## Style Attributes

What kinds of colors will you be using? Do you have a limited palette to work with? A post-processed HSV map/image? Consistency is key for immersion.

What kind of graphic style are you going for? Cartoony? Pixel-y? Cute? How, specifically? Solid, thick outlines with flat hues? Non-black outlines with limited tints/shades? Emphasize smooth curvatures over sharp angles? Describe a set of general rules depicting your style here.

Well-designed feedback, both good (e.g. leveling up) and bad (e.g. being hit), are great for teaching the player how to play through trial and error, instead of scripting a lengthy tutorial. What kind of visual feedback are you going to use to let the player know they&#39;re interacting with something? That they \*can\* interact with something?

## Graphics Needed

1. Characters
  1. Human-like
    1. Goblin (idle, walking, throwing)
    2. Guard (idle, walking, stabbing)
    3. Prisoner (walking, running)
  2. Other
    1. Wolf (idle, walking, running)
    2. Giant Rat (idle, scurrying)
2. Blocks
  1. Dirt
  2. Dirt/Grass
  3. Stone Block
  4. Stone Bricks
  5. Tiled Floor
  6. Weathered Stone Block
  7. Weathered Stone Bricks
3. Ambient
  1. Tall Grass
  2. Rodent (idle, scurrying)
  3. Torch
  4. Armored Suit
  5. Chains (matching Weathered Stone Bricks)
  6. Blood stains (matching Weathered Stone Bricks)
4. Other
  1. Chest
  2. Door (matching Stone Bricks)
  3. Gate
  4. Button (matching Weathered Stone Bricks)

_(example)_

_(Note : If you&#39;re soloing you might not need to define this part, as you can just use the Derived Classes + Themes section as a reference. It&#39;s up to you.)_

## _Sounds/Music_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

## Style Attributes

Again, consistency is key. Define that consistency here. What kind of instruments do you want to use in your music? Any particular tempo, key? Influences, genre? Mood?

Stylistically, what kind of sound effects are you looking for? Do you want to exaggerate actions with lengthy, cartoony sounds (e.g. mario&#39;s jump), or use just enough to let the player know something happened (e.g. mega man&#39;s landing)? Going for realism? You can use the music style as a bit of a reference too.

 Remember, auditory feedback should stand out from the music and other sound effects so the player hears it well. Volume, panning, and frequency/pitch are all important aspects to consider in both music _and_ sounds - so plan accordingly!

## Sounds Needed

1. Effects
  1. Soft Footsteps (dirt floor)
  2. Sharper Footsteps (stone floor)
  3. Soft Landing (low vertical velocity)
  4. Hard Landing (high vertical velocity)
  5. Glass Breaking
  6. Chest Opening
  7. Door Opening
2. Feedback
  1. Relieved &quot;Ahhhh!&quot; (health)
  2. Shocked &quot;Ooomph!&quot; (attacked)
  3. Happy chime (extra life)
  4. Sad chime (died)

_(example)_

## Music Needed

1. Slow-paced, nerve-racking &quot;forest&quot; track
2. Exciting &quot;castle&quot; track
3. Creepy, slow &quot;dungeon&quot; track
4. Happy ending credits track
5. Rick Astley&#39;s hit #1 single &quot;Never Gonna Give You Up&quot;

_(example)_

_(Note : Again, if you&#39;re soloing you might be able to / want to skip this section. It&#39;s up to you.)_

## _Schedule_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

_(what is a schedule, i don&#39;t even. list is good enough, right? if not add some dates i guess)_

1. develop base classes
  1. base entity
    1. base player
    2. base enemy
    3. base block
  2. base app state
    1. game world
    2. menu world
2. develop player and basic block classes
  1. physics / collisions
3. find some smooth controls/physics
4. develop other derived classes
  1. blocks
    1. moving
    2. falling
    3. breaking
    4. cloud
  2. enemies
    1. soldier
    2. rat
    3.
5. design levels
  1. introduce motion/jumping
  2. introduce throwing
  3. mind the pacing, let the player play between lessons
6. design sounds
7. design music

_(example)_
