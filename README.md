# Unity Screening Test

## Overview
This project was created as part of the **Unity Screening Test**. The goal is to demonstrate clean scene logic, data flow handling, and basic UI interaction similar to what’s used in **MeetUsVR** — all implemented without any private or external project code.

The project includes two main scenes and one additional interactive feature, following the requirements of the test.

---

## Scenes

### 1. Lobby Scene
- Contains an **Input Field** for entering the player’s name.  
- A **"Join Room"** button loads the Room Scene.  
- The player’s name is persisted and passed to the next scene.

### 2. Room Scene
- Displays a **Text UI element** showing:  
  `Connected as [PlayerName]`  
- Logs a console message:  
  `Player [PlayerName] joined room.`

---

## Extra Feature
- **Spawn Cube Button:** Instantiates a cube prefab at a random position in the scene.  


---

## Technical Notes
- Built with **Unity 2022.3.x**.  
- All scripts are written in **C#**, cleanly commented and structured.  
- The project demonstrates:
  - Scene transitions and data persistence.
  - Proper variable passing and UI updates.
  - Awareness of console logs and error-free behavior.

---

## Git Workflow
The repository includes at least **three commits** representing key development stages:
1. **Setup:** Unity project initialization and basic structure.  
2. **Logic:** Core functionality and scene scripting.  
3. **Polish:** UI improvements, comments, and bug fixes.

---

## Submission
- **Deliverables:** Public GitHub link, short screen recording, and this README.  
- **Deadline:** 48 hours after receiving the test.  
  
  - **Bonus:**Made it multiplayer using Photon Pun2

---

## Author
Ahmed Osama  
*Date of Submission: 13/11/2025*
