# JUMPY BOI - ACTION 2D PLATFORMER - Fall 2024

## Authors

- John Leonard (jdleonard@vcu.edu)
- Jason Bennett (jebennett@vcu.edu)

## Team

- Alex Nguyen (nguyena57@vcu.edu)
- Brooke Derdevanis (derdevanisbp@vcu.edu)


## Important Links

- Game URL: <https://play.unity.com/en/games/6f66d588-64ca-47a8-ab69-b4a1f1fe7a0d/jumpy-boi>
- GITHUB URL: <https://github.com/cmsc-vcu/gamedev-fa2024-hw6-team-stickay.git>
- Gameplay Video URL: <https://drive.google.com/file/d/1k51onKfl5fIuBCBKhj2vfsmnOPhcsLcx/view?usp=sharing>
- Google Doc writeup: <https://docs.google.com/document/d/1p22_YRiRMqorlA-lG0XY0FYDM76kvRErtfRhnQlMlGw/edit?usp=sharing>

## Files in the repository

./unity/ - this folder contains the Unity game files associated with this game.

./website/ - this folder contains files associated with the *gh-pages* created for this game.

./docs/ - Don't edit files in this folder directly.  Edit the source documents in the *./website* folder, then use `quarto` to render the documents to HTML and store them in the *./docs* folder.

./Stickay/ - Has all the necessary Unity project files, from the paackages to the assets.

---

# **JUMPY BOI - Game Description**

### *Overview*:
Welcome to *JUMPY BOI*, a 2D action-platformer where players control a sword-wielding character navigating through a dark, fantasy world filled with monsters. With tight controls and simple yet satisfying mechanics, the goal is to survive, bounce off enemies, and reach the flag for victory.

---

## **Gameplay Mechanics**

### **Movement**:
- **Horizontal Movement**: Use the left and right arrow keys or `A` and `D` to move your character left and right.
- **Jumping**: Press the `Spacebar` to jump. The character has a controlled jump, meaning you can direct their movement mid-air.

### **Attacking**:
- **Downward Slash**: When in the air, pressing `Down + Spacebar` will trigger a downward slash that can destroy enemies. You must time your slashes carefully, as hitting an enemy without slashing results in death.

### **Enemies**:
- **Floating Enemies**: These monsters hover in place, serving as both obstacles and platforms. Slash them with a downward attack to bounce off them or risk losing the game.

### **Victory Condition**:
- **The Flag**: The goal is to reach the flag at the end of the level. Once touched, the victory screen will appear, allowing you to restart the game.

### **Death Mechanic**:
- **Dying**: If you collide with an enemy without performing the downward slash, your character dies and the game will show a death screen with an option to restart.

---

## **Controls**:
- **Move Left**: `A` or `Left Arrow`
- **Move Right**: `D` or `Right Arrow`
- **Jump**: `Spacebar`
- **Downward Slash**: `Down Arrow + Spacebar`

---

## **Features**:
- **Dynamic Enemy Combat**: Players need to master the timing of jumps and slashes to survive enemy encounters.
- **Tight Platforming**: Navigate the levels using precise controls to avoid hazards and reach the goal.
- **Death & Restart**: On death, a death screen will appear, allowing players to restart from the beginning.

---

## **Game Design**:
- **Player Mechanics**: The player character can move horizontally, jump, and perform downward attacks. The jump height and horizontal movement are balanced to give the player control over their movement in the air, crucial for bouncing off enemies and avoiding hazards.
  
- **Enemy Mechanics**: Enemies are placed strategically in the air, challenging the player to time their jumps and slashes accurately. Each enemy serves as a potential platform when destroyed.

- **Victory & Defeat**: Touch the flag to win and trigger the victory screen, or hit an enemy without attacking properly to die and restart the game.

---

## **Development Details**:
- **Programming Language**: C#
- **Project Type**: 2D Action-Platformer

---

## **How to Play**:
1. Clone or download the project from the repository. Or click the playable link.
2. Open the project in Unity.
3. Press the "Play" button in Unity to start the game.
4. Control the player with the movement and jump keys to defeat enemies and reach the flag for victory.

---

## **Credits**
- **Developer**: Alex Nguyen(Coding), Brooke Derdevanis(Art)
- **Art & Animations**: Custom-made sprites for the player and enemies.

---
