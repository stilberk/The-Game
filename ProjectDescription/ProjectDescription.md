## Project description


###The name of the game: The adventures of Professor Feynman

###Designers of the game: Team Feynman

**Team Members:** Alexander, Aneliya, Borislav, Kalina, Mariya, Neli, Plamen, Stiliyan   

###Type of the game: 2D animated Role-Play Game (RPG), designed by the team Feynman. 

**I. The goal:** to develop an interactive 2D animated Role-Play Game (RPG).  The game is based on several interesting stories, which are inspired from the real life achievements of Professor Richard Feynman. 

**II. Advantages:** This game is open and allows realization of many scenarios. When one scenario ends, the hero moves to the next level, where a new story starts. Thus the game could be continuously developed and extended. 

**III. Development tools:** 

* [OneDrive temporary file storage] (https://onedrive.live.com/?id=8179642F11171979%21105&cid=8179642F11171979)
Here we have stored sprite sheets and other images, which we have used or plan to use in the game code. All necessary images are taken from the internet. 

**IV. Team collaboration tools:**

* [GitHub repository]( https://github.com/Team-Feynman/The-Game )
* [Trello] (https://trello.com/b/3sCSKPDq/rpg-game-ideas)
* Skype – Team Feynman group, where we have continuously discussed all ideas and problems. 


**V. Used platform:** We have used the **MonoGame 3.5 for Visual studio**.  It is an open source implementation of the Microsoft XNA 4 Framework, which is quite easy and intuitive to learn, and has a cross-platform realization. 


**VI. What is realized till now:**

1. Title screen with 2 buttons (Play and Quite) on the background and 2 objects (bomb and test tube)

2. The second screen, where the Professor is walking on the map. 

3. All possible collisions during the movement of the hero on the map are programmed in the code. 

4. This game level is accompanied using suitable music. 


**VII. Code description:** 
**Project solution:** FeynmanGame.sln
All classes are included in the **namespace** SpriteAnimation.sln. 
**Starting point of the game:** file ../../FeinmanGame/Feynman.cs
Feynman.cs calls the file Game1.cs

**Game1.cs** was created following the instructions for using MonoGame. As a starting point we have used the [tutorial] (http://www.gamefromscratch.com/post/2015/06/10/Getting-Started-with-MonoGame-on-Windows.aspx), and extended the code according our needs. 
The class Game1 is the main type for our game, which inherits the base class Game. In our implementation of this file we have created a rectangle that defines the limits for the main game screen. Here we also have defined a behavior of the concrete objects of the our own classes MenuButton, Player, KnoledgeBook, as well as object from the classes GraphicsDeviceManager, SpriteBatch,  Content, Texture2D. 
In this class the following methods are used:

**- Initialize()** - Allows the game to perform any initialization it needs to before starting to run. This is where it can query for any required services and load any non-graphic related content.  Calling base.Initialize will enumerate through any components and initialize them as well.

**- LoadContent()** is called once per game and is the place to load all of the game content. Here we create a new SpriteBatch, which can be used to draw textures. Here we set the rectangle parameters using 2D textures. These textures are saved in the library SpriteAnimation/content/content.mgcb as *.png - files.

**- UnloadContent()** – it is called once per game and is the place to unload game-specific content.

**- Update(GameTime gameTime)** - Allows the game to run logic such as updating the world, checking for collisions, gathering input, and playing audio. The parameter gameTime provides a snapshot of timing values. Here the behavior of both buttons is defined. 

**- Draw(GameTime gameTime)** – this method is called when the game should draw itself. Here the animation of the concrete instance of the class Player is defined. 
This class call the classes MenuButton, Player, KnoledgeBook.

**MenuButton.cs** defines the color, position and behavior of the buttons on the start page of the game. 

**Player.cs** defines the behavior of Professor Feynman, the animated hero in our game. The movements up, down, left and right are defined according the pressed arrows from the keyboard. 

**KnowledgeBook.cs** is a texture with defined size and location. 

**VIII. Future detailed work on level 1** 
1. The goal of this level is to increase the IQ value of the hero up to some boundary, needed for creating of the Feynman diagrams. 

2. During his movements on the screen Professor Feynman collects some pieces, which help him to create his famous Feynman diagrams. These pieces are related to the subatomic particles and could be drawn as [some symbols]  (http://www.conceptdraw.com/How-To-Guide/picture/physics-symbols/Science-Education-Physics-Design-Elements-Nuclear-Physics.png)

3. Once he manages to collect something, his IQ value arises. 

4. In the same time some obstacles appear – some books or equations or diagram falls from the top part of the screen. 

5. Ones the Professor meets these obstacles, his IQ decreases with certain value. 

6. At the end of this level, when the boundary IQ value is reached, the Professor Feynman gets a coin with Nobel face drawn on it. 

7. During all the time a suitable music for all events is playing. 


**Possible game scenarios:** These facts from Professor Feynman life inspired us to create three possible scenarios of our game, namely:

Part1: Professor Feynman and the subatomic particles. 

Part 2: Professor Feynman and the atomic bomb.

Part 3: Professor Feynman and the space shuttle Challenger.

**The scenarios:** 
Part 1, which we will try to realize next. 
1.  The goal of this level is to increase the IQ value of the hero up to some boundary, needed for creating of the Feynman diagrams.

2.  During his movements on the screen Professor Feynman collects some pieces, which help him to create his famous Feynman diagrams. These pieces are related to the subatomic particles and could be drawn as [some symbols](http://www.conceptdraw.com/How-To-Guide/picture/physics-symbols/Science-Education-Physics-Design-Elements-Nuclear-Physics.png)

3. Once he manages to collect something, his IQ value arises. 

4. In the same time some obstacles appear – some books or equations or diagram falls from the top part of the screen. 

5. Ones the Professor meets these obstacles, his IQ decreases with certain value. 

6. At the end of this level, when the boundary IQ value is reached, the Professor Feynman gets a coin with Nobel face drawn on it. 

7. During all the time a suitable music for all events is playing. 

Future work: If there is more time, we can try to create and realize also scenarios for Part 2 and Part3. 




