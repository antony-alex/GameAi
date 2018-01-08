# GameAi
Final Year Project
Game AI Programming
Antony Porcu

Car racing with Pathfinding
I was always interested in the idea of competition, with games such as FIFA or gran tourismo, 
Allows for individuals to compete with one another or bots. In racing games such as gran tourismo, if you face an agent, they will be following nodes to beat you to the finish line. This interested me to make a racing game with agents that follow the nodes to race around the track and to try win the game. 
I started of by making my terrain big enough for the track with some colliders and agents, I found most objects on the asset store.
I wanted to follow a plan on how I would make this game; what techniques I would be using and libraries.
I used a car from the asset store which was handy as it already had wheel, body and bumper objects. This allowed me to create colliders for the wheels. 
I needed to make my path for the cars to follow, so I made an object called path with an empty child called node, with the nodes, I created way points around the map for the cars to follow. such as so
The small blue dots around the screen are nodes that I’ve added into the game


After this I needed to get my car to drive and follow the track. I made a script called car engine which will be used for ray casting of different objects in the game as well as moving the car through the nodes. I used some of the path script to allow all the cars to use the nodes in the game
I made a function called apply steer which allows the car to turn left and right. I added another function called check point, which allows the car pass through the nodes and if its on the last node, it will go back the 0th node and start all again, basically putting it through a loop. With these, I needed the car to actually move, so I added a Power function which allows the car to move, I could have hard coded the speed of the car, but I allowed the car to be able to gather speed and go as fast as it can which is 60f, and when it does go as fast as it can, it usually gets the car off track and the car has to go back to the waypoint to complete the node passing.  
I had problems trying to get my car to be interactive and allow users to play the game, with my AI car, I wanted to make a script that would allow users to play using the up, down, left, right keys or w, s, a, d keys. However long hours searching, I was unable to implement the idea. However, in unity I found a premade car which has these controls and that allowed me to control the car, so I have two different types of cars in the game, one for the user and one with AI Controls.





Implementing sensors for the car gave me some problems, as it didn’t turn when it collided with another car. I had a problem of getting the car sensor aiming at the middle of the map at all times. I had hours of trying to find other techniques such as ray cast to be able to do this, but my game kept crashing when attempted.

After this I created multiple car agents in the game to have fun let them race around the track via the nodes.
				
