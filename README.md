# StaySafe
**Stay Safe** is a 2D endless runner survival game developed with Unity and C#. Players guide a character running forward indefinitely, avoiding randomly spawned obstacles. The goal is to survive as long as possible and achieve a high score.

## 🎮 Features
- **Main Menu**  
  - Play button to start the game  
  - Audio settings: toggle mute and adjust volume via slider  

- **Endless Runner Gameplay**  
  - Character automatically runs forward  
  - Random obstacles spawn at intervals  
  - Collision with an obstacle triggers Game Over  

- **Real-time Scoring**  
  - Score increments over time  
  - The score is displayed in the center of the game screen in real time.

- **Pause & Resume**  
  - Tap the pause button to pause  
  - Resume or return to Main Menu from pause panel  

- **Game Over Screen**  
  - Shows “Game Over” message  
  - Options to Restart or go back to Main Menu  

---

## 🛠️ Tech Stack

- **Engine**: Unity 2022.3.53f1c1
- **Language**: C#  
- **UI**: Unity UI System (Canvas, Panels, Buttons, Text, Slider)  
- **Storage**: PlayerPrefs (for audio & scoring settings)  
- **Scene Management**: UnityEngine.SceneManagement  

## 📂 Project Structure
StaySafe/
├── Assets/
│ ├── Scenes/
│ │ ├── MainMenuScene.unity
│ │ └── GameScene.unity
│ ├── Scripts/
│ │ ├── MainMenuUI.cs
│ │ ├── VolumePanelToggle.cs
│ │ ├── VolumeMenuUI.cs
│ │ ├── BackgroundMusic.cs
│ │ ├── ScoreManager.cs
│ │ └── GameManager.cs
│ ├── Prefabs/ # 障碍物、玩家、UI 面板预制件
│ ├── Sprites/ # 角色和障碍物贴图
│ └── UI/ # Canvas 和面板预制件
└── README.md

https://qifan75.itch.io/2d-endless-runner



https://github.com/user-attachments/assets/14a7f1d7-816d-43c1-bcf1-d178a04e9202

