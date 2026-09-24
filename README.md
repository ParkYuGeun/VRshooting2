
# 🎯 VRshooting2

> **Meta Quest 기반의 3D VR 액션 슈팅 게임**  
> 플레이어가 직접 컨트롤러를 조작하여 가상 공간에서 사격하고 적을 퇴치하는 VR 액션 게임입니다.

---

## 📸 Demo & Screenshots

| 메인 플레이 화면 |
| :---: | 
| <img src = ./Screenshot/vr2-1.PNG width = 600 height = 600 alt = vr2-1> |
| <img src = ./Screenshot/vr2-2.PNG width = 600 height = 600 alt = vr2-2> |
| <img src = ./Screenshot/vr2-3.PNG width = 600 height = 600 alt = vr2-3> |

---

## ✨ Key Features

- **직관적인 VR 사격 시스템**: XR Interaction Toolkit을 활용한 현실감 있는 총기 조작 및 조준 시스템
- **다양한 적 AI & 웨이브 시스템**: 플레이어를 추적하고 공격하는 적 navMesh AI 패턴 사용
- **체감형 VR UI/UX**: 가상 공간 내 3D World Space Canvas를 활용한 체력 및 스코어 표시
- **렌더 파이프라인에 대한 이해**: URP -> Built-in Render Pipeline 기반 메테리얼로의 전환과 쉐이더그래프 제작

---
## 💻 Languages and Tools
[![Unity](https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com)
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![XR Interaction Toolkit](https://img.shields.io/badge/XR%20Interaction%20Toolkit-6F42C1?style=for-the-badge&logo=unity&logoColor=white)](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@latest)
---

## 🛠 Tech Stack & Environment

| 구분 | 내용 |
| :--- | :--- |
| **Engine** | Unity 6.5.6f1 |
| **Render Pipeline** | Built-in Render Pipeline |
| **Target Device** | Meta Quest 2 / Quest 3 |
| **SDK / Framework** | Meta XR Core SDK, XR Interaction Toolkit |
| **Language** | C# |
| **IDE** | Visual Studio|

---


## 📁 Project Structure

```text
Assets/
├── Core/               # 핵심 게임 매니저 및 시스템 스크립트
├── Prefabs/            # 총기, 적 AI, UI 프레합
├── Scenes/             # 메인 게임 및 테스트 씬
├── Scripts/            # C# 로직 스크립트
└── Shaders/            # Custom Shader Graph 파일

</div>
