ARISSABLO 4

This unity3D project achieves a prototype given by a couple of resources to present a Diablo like game.
It have features below as the requirements said: 

1. Set up an avatar in the scene
2. Top-Down view camera with following function
3. Character movement by NavMeshAgent
4. Character animation by Animator
5. A scene with some obstacles



----Script document

--gameManager.cs
This is a core script of the game. It collaborates with multiple controllers.
Now it currently has only one function: Listening map click event and making player to move.

--camControl.cs
This controller follows player when the player is moving. It uses a simple algorithm to follow the player smoothly.

--mapControl.cs
This controller listens map click event and fire the event to gameManager.
For improvement, it should be Singleton and have a event dispatcher if there are many listeners who needs the map event. 
And the logic in gameManager should be eliminated. 

--playerControl.cs
This controller controls player’s actions. Now it only try to let player move when the map is clicked.



----Technologies used

The path finding is completed by NavMeshAgent.
The animation logic is completed by Unity Animator(to start or stop animation by player running speed).




----How To Use

The executable file is in the folder ./Publish/
click anywhere of the map should make the player running to the place.




----About the Author

I am Jaluca (YIN RUI). I am a game lover since I was a child. I have been working in game industry since I graduated from university.
I came to Singapore since 2019 because of immigration and now I am a Singapore PR. I miss to make real games a lot. I hope my dream will come true in Singapore ASAP. 

TODO: Player behind obstacles should have a stroke, this should be amazing! But to recollect my shader skills 10+ years ago costs me too much time, that is a pity!