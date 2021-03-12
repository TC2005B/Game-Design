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

![image](https://user-images.githubusercontent.com/65837382/110875416-32473000-829b-11eb-8464-87d907c02c50.png)
![image](https://user-images.githubusercontent.com/65837382/110875437-3d9a5b80-829b-11eb-81c9-efc939dd0236.png)
![image](https://user-images.githubusercontent.com/65837382/110875461-4723c380-829b-11eb-8e4e-b9d36486dbf3.png)


## Summary

The game consists of two essential parts, open world exploration and puzzles within certain areas.

## Gameplay

The player will start in an open map, where divere structures are to be found, each of these represent the electronic components of a pc, these will be accessible in order for the player to play puzzle minigames that will interactively represent the functions of these components.


## Mindset

It is intended that the player will develope an interest in discovering / unlocking the map, a pleasant and interesting map will be made so that the user wants to know what else there is, what other challenges he can face or what secrets he can find, when starting the unexplored map he will have a shading that will be removed when the player explores a certain area, in the same way there will be blocked parts of the map that will only be accessible when completing a certain amount of puzzles.

## _Technical_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

## Screens

1. Title Screen
  1. Options
2. Game
  1. Challenges completed counter
3. End Credits

![image](https://user-images.githubusercontent.com/65837382/110875087-9caba080-829a-11eb-848f-d379a6472357.png)

## Controls

The player will be able to move through the arrow keys and will enter automatically each component by just moving through their doors. The puzzle mechanics are yet to be defined individually.

## Mechanics

The main aspect of the general map is pretty much 2D movement in a plane map from a cenital view. The mechanics of each individual component are still in the making to keep the game interesting and not repetitive.


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

![image](https://user-images.githubusercontent.com/65837382/110875661-aaadf100-829b-11eb-9dee-61e88df47035.png)

## Abstract Classes / Components

1. Mainframe
  1. Player
  2. Enemy
  3. DestructibleObject
2. Obstacle
3. Collectable

_(example)_

## Derived Classes / Component Compositions

1. BasePlayer
  1. PlayerMain
2. BaseEnemy
  1. RedRobot
3. BaseObject
  1. Component (breakable)
  2. Component (unbreakable)
4. BaseInteractable
  1. Objective (may vary)
![image](https://user-images.githubusercontent.com/65837382/110875774-e21c9d80-829b-11eb-99e2-f12a0a8f37bc.png)

## _Graphics_

![image](https://user-images.githubusercontent.com/65837382/110875800-ec3e9c00-829b-11eb-9980-fda9810e5a6a.png)


## Style Attributes

The colors will try to be representative of IT stereotypes such as green, blue, but not limited to these, in order to resemble components of a PC.
Since it's 2D, it will be cartoony and pixel-y and not precisely realistic of the build of a real PC. Assests will have mainly have marked edges. 

## Graphics Needed

1. Characters
  1. Robots
    1. Blue robot (idle, walking)
    2. Red robot (idle, walking, seeking)
2. Blocks
  1. Borders
  2. Random components
  3. RAM
  4. CPU
  5. GPU
  6. Random breakable components
3. Ambient
  1. Glitches
  2. LEDS

## _Sounds/Music_

https://soundcloud.com/jaime-emilio-828766911
https://open.spotify.com/artist/7i42XhcctTfHBvHRHMA0mV?si=1TnmpLuQTi2w0OfpsZXJ6g
https://drive.google.com/drive/u/1/folders/1NNeCDcRpgLiupWv6B066B7M1ziq70b-M

All songs written, produced, and arranged by Jaime Emilio Sánchez


## Style Attributes

Some of pre-existing Lawmes tracks share some particular characteristics of videogame music, adding time signature changes representative from prog rock music and some elements from IDM and techno as well that fit the general purpose of the game mood. 

In addition to that, some tracks were composed for the mere objective of adding a particular mood setting to some areas of the game, varying from cathartic music for completing tasks succesfully, passing through friendly exploration music to aggresive and intense tracks for adding pressure to the player.

The game sound effects are yet to be design by the same producer in order to fit the techy setting.


## Sounds Needed

1. Effects
  1. Moving sound (robot sounds)
  2. Enter the component (may vary)
  3. Level complete (may vary)
  4. Level failed (may vary)
  5. Object breaking
2. Feedback
  1. Relieved &quot;Ahhhh!&quot; (health)
  2. Shocked &quot;Ooomph!&quot; (attacked)
  3. Happy chime (extra life)
  4. Sad chime (died)

(Yet to be produced)

## Music Needed

1. Upbeat, friendlyM track
2. Mysterious, danger injected track
3. Creepy, aggresive, intense track
4. Happy ending cathartic, happy sounding track

## _Schedule_

![](RackMultipart20210224-4-casz78_html_237499165a11f2b9.gif)

_(what is a schedule, i don&#39;t even. list is good enough, right? if not add some dates i guess)_

1. develop base classes
  1. base entity
    1. base player
    2. base enemy
  2. base app state
    1. game world
    2. menu world
2. develop player and basic block classes
  1. physics / collisions
3. find some smooth controls/physics
4. develop other derived classes
  1. blocks
    1. grabbed
    2. thrown
    3. breaking
  2. enemies
    1. robot
5. design levels
  1. introduce grabbing
6. design sounds
7. design music
