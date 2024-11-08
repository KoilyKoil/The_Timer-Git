# 필독!
- 코드가 구버전이라 주석이 깨져있습니다. EUC-KR로 리인코딩해주시면 주석내용이 보입니다!
- Because codes are legacy, all of comments are broken. Reencode to EUC-KR to see comments.

## 소개
"The Timer" 게임 프로젝트입니다. 안드로이드 환경에서 구동됩니다.
시간의 가속과 감속을 활용한 **플랫포머 퍼즐**게임입니다.
현재는 작업을 하고있지 않은 프로젝트입니다.

## 주요 특징
- 시간의 가속과 감속을 활용한 플랫포머 퍼즐게임입니다.
- 시간을 가속하면 플레이어의 속도가 빨라지고, 감속하면 플레이어의 중력과 이동속도가 느려집니다.
- 속도 기믹 이외에도 착지 가능한 미사일, 문과 버튼, 상승형 소화전, 강제 시간 조절 장치 등의 기믹으로 퍼즐의 재미를 높여갑니다.

## 구현 기능
- **판정**. 일정 범위내에 존재하는 오브젝트를 인식하고, 이에 따라 본인의 행동패턴을 달리함. 플레이어의 경우 Trigger가 설정된 콜라이더를 활용, 적의 경우 플레이어와 오브젝트의 거리차를 실시간으로 계산하여 해결
- **씬의 활용**. 이 작품부터 본격적으로 씬을 사용하기 시작. 메인메뉴를 만들고, DontDestroyOnLoad를 활용하여 씬을 넘어선 데이터 교환을 진행.
- **유도탄**. 플레이어와 오브젝트의 좌표값에 따른 방향벡터와 거리차를 구한 뒤, 이를 1/n한 수치만큼 오브젝트를 이동

## 기획적 특징
- 시간의 가속과 감속을 활용하되, 원래는 오브젝트 자체에 대한 시간변화를 활용하고자 했음. 허나 이때 당시에는 Timescale에 대한 개념이 전무했기 때문에 플레이어 자체의 시간 변화로 결정.
- 물론 대부분의 미디어에서는 시간의 감속만을 소재로 삼기에, 시간 가속을 활용한 퍼즐을 고안하고자 했음
- 시간 퍼즐 이외에도 미사일, 상승 등 여러 퍼즐적 기믹을 구현하면서, 되도록 각 테마별로 상응하는 퍼즐을 구현하고자 했음
- 허나, 맵 자체를 너무 좁게 설정하여 퍼즐이 제한된다는 점과 스테이지가 쓸데없이 너무 많다는 점으로 인해 프로젝트 중단.
---
