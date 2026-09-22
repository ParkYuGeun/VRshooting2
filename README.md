
# 🎯 VR VR Shooting Game (가제)

> **Meta Quest 기반의 3D VR 액션 슈팅 게임**  
> 플레이어가 직접 컨트롤러를 조작하여 가상 공간에서 사격하고 적을 퇴치하는 VR 액션 게임입니다.

---

## 📸 Demo & Screenshots

| 메인 플레이 화면 | 조작 / 상호작용 |
| :---: | :---: |
| *(플레이 GIF 또는 이미지 링크 입력)* | *(플레이 GIF 또는 이미지 링크 입력)* |

---

## ✨ Key Features

- **직관적인 VR 사격 시스템**: XR Interaction Toolkit을 활용한 현실감 있는 총기 조작 및 조준 시스템
- **다양한 적 AI & 웨이브 시스템**: 플레이어를 추적하고 공격하는 적 AI 패턴 구현
- **체감형 VR UI/UX**: 가상 공간 내 3D World Space Canvas를 활용한 체력 및 스코어 표시
- **최적화된 렌더링**: URP(Universal Render Pipeline) 기반의 모바일 VR 기기 프레임 최적화

---
## 사용한 기술 & tool
-[![Unity](https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)

---

## 🛠 Tech Stack & Environment

| 구분 | 내용 |
| :--- | :--- |
| **Engine** | Unity 6 (또는 사용 중인 유니티 버전) |
| **Render Pipeline** | Universal Render Pipeline (URP) |
| **Target Device** | Meta Quest 2 / Quest 3 |
| **SDK / Framework** | Meta XR Core SDK, XR Interaction Toolkit |
| **Language** | C# |
| **IDE** | Visual Studio Code |

---

## 🎮 Controls

| 동작 | Meta Quest Touch Controller |
| :--- | :--- |
| **이동 (Locomotion)** | 왼쪽 썸스틱 (Continuous Move / Teleport) |
| **시점 전환** | 오른쪽 썸스틱 (Snap Turn / Continuous Turn) |
| **총기 잡기 (Grasp)** | 그립 버튼 (Grip Button) |
| **발사 (Fire)** | 트리거 버튼 (Trigger Button) |

---

## 📁 Project Structure

```text
Assets/
├── Core/               # 핵심 게임 매니저 및 시스템 스크립트
├── Prefabs/            # 총기, 적 AI, UI 프레합
├── Scenes/             # 메인 게임 및 테스트 씬
├── Scripts/            # C# 로직 스크립트
└── Shaders/            # Custom Shader Graph 파일
Languages and Tools

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/) 
[![Unity](https://img.shields.io/badge/Unity-222222?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/) 
[![React](https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB)](https://react.dev/)
[![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)
</div>
