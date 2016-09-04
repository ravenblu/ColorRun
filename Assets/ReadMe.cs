/*
 * 
 * The game maker is created to help people to produce their own ColorRun game with customized features.
 * Author: Jiayu Liu
 * Date: 03/21/2016
 * 
 * 
 * Gameplay:
 * Goal: Try to eliminate as many color cubes as possible.
 * Rule: Cubes would be eliminated if player's color is the same.
 * How: Press numbers on the keypad (0,1,2,3,...) to change colors accroding to definitions of "Element" numbers in Spawn Property. 
 *
 *
 * Custimization in Hierarchy-Inspector:
 * 1. Spawn Property (Change "Size" and assign propertie, i.e. weight and color, to spawn cubes)
 * 2. Player --> PlayerControl Component --> Player Move Speed
 * 3. Spawn --> SpawnControl Component --> Spawn Point Start & Spawn Point End
 * 4. Trigger Positon --> Spawn(in Hierarchy)-Trigger-Edit Collider in Inspector to adjust its location
 * 
 * 
 */
