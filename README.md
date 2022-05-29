# Storytelling-Game-Pipeline

## 기획의도
```
게임과 영화는 서로 다른 컨텐츠 입니다.
하지만 그 컨텐츠 사이의 벽을 허무려는 시도들이 종종 보이곤 합니다.

이에 영향을 받아 게임과 영화 그 사이 어딘가에 해당하는 새로운 구현을 시도해 보고 싶었습니다.
특히 조금 더 추상적인 입력을 통해 이야기를 진행시켜 보고 싶었습니다. 
```

```
게임이라는 디지털 매체의 특징 중 하나는 유저의 `개입`과 `선택` 입니다.
만화, 애니메이션, 영화, 드라마 등의 영상매체에서는 이미 정해진 대로 화면에 출력되는 반면,
게임에서는 유저의 선택과 개입에 따라 실시간으로 화면이 렌더링 됩니다.

주로 마우스와 키보드의 입력, 그리고 조금 더 특별한 경우
vr기기, 모바일 기기의 기울기, 흔들기 등의 동작이 반영됩니다.

하지만 이는 대체로 물리적인 입력이며, 입력 값과 이에 대한 결과(이벤트)가 분명합니다.
하지만 저는 조금 더 추상적인 게임진행을 구현하고 싶었고,
그 중 하나가 자연어처리를 이용하여 유저의 경험을 반영하는 것 이였습니다.
```

## 구현

- 원하는 게임 스타일에 맞춘 model을 만듭니다.
    - 기존 스토리에 따른 유저 경험을 반영한 이벤트를 발생시키는 model을 만들었습니다.
    - model은 text를 `vectorize`하고 `classification`을 진행합니다.
  
- game에서 story가 진행될 때, 해당 `text`를 export 합니다.
  
- model은 해당 text를 classification하여 결과를 game으로 전달합니다.
  
- game에서는 해당 결과에 해당하는 event를 발생시킵니다.
  
- 그리고 다시 game이 어느정도 진행되면 `text`와 플레이어의 `status`를 export 합니다.
    - 해당 data는 model이 학습하는 data가 됩니다.
    - 플레이어의 `status` 변화가 잘 반영되기 위한 시간이 필요합니다.
    - 게임이 진행되면 진행될수록 해당 유저의 경험이 쌓입니다.
  
  
---
- ex)
  - "동물원의 호랑이가 슬퍼 보였다" 라는 이야기가 전개됩니다.
  - 유저의 `Status`가 `Sad` 였다면, 모델은 해당 `text`를 `Sad`로 학습합니다.
  - 이야기가 더 진행되면서 "동물원에 갔다" 라는 이야기가 전개됩니다.
  - 기존의 학습에 의해 `Sad` 로 분류하여 이에 해당하는 event를 발생시킵니다.


## 결과물

![projectgif](https://user-images.githubusercontent.com/77562357/170865891-cef59048-b572-45d7-853b-86f232d6d3f8.gif)

- 결과물은 [여기](https://github.com/oeccsy/Storytelling-Game-Pipeline/releases)에서 확인하실 수 있습니다.

- 발생 이벤트는 키보드 `T`를 누르면 텍스트로 확인 가능합니다. 

- text 분류는 실제 의미와는 다르며 인게임에서의 유저 경험에 기반합니다. 



## 라이센스
- 해당 프로젝트는 `MIT` 라이센스를 따릅니다.

- 사용한 오픈소스
  - sklearn
    - event를 발생시킬 model 구현에 사용하였습니다. 
        - bsd 라이센스
        - https://scikit-learn.org/stable/
  - pyinstaller
    - python코드를 build하는데 사용하였습니다.
    - 해당 프로젝트에서는 pyinstaller에 대한 코드 수정사항이 없습니다.
        - `Apache License 2.0` (or GPL 2.0)
        - https://pyinstaller.org/en/stable/license.html
        - https://raw.githubusercontent.com/pyinstaller/pyinstaller/develop/COPYING.txt

