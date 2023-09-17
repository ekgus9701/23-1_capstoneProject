# 23-1_CapstoneProject : 고딩작가의 연애노트
 23-1 OO캡스톤디자인 수업에서 개발한 Z세대의 어휘력 향상을 위한 시뮬레이션 게임입니다. 
 
 게임 실행파일은 여기서 다운 받으실 수 있습니다. (Windows에서 실행 가능)
 https://drive.google.com/file/d/1uELl5rnZXfdxu9EEBS3ICwJMZts1ITbK/view?usp=sharing 

 게임 시연영상은 여기서 보실 수 있습니다.<br>
 https://drive.google.com/file/d/12t3zm0ICyjLxG2PD2vjQ74CaQq8jo02h/view?usp=drive_link

### 1. 개발 도구

게임 개발 도구로는 대표적으로 사용되고 있는 게임 개발 엔진인 Unity를 사용하였다. 개발 언어로는 Unity에 사용되는 C#을 활용하여 개발하였다.

### 2. 대화 시스템

대화는 직접 대화하는 듯한 현실감을 위해 텍스트가 한 글자씩 타이핑 되는 방식으로 개발하였다. 이 과정에서는 IEnumerator와 Coroutine을 활용하였다. 대화를 다 읽고 마우스 왼쪽 버튼을 누르면 다음 대화가 나타난다. 말하는 화자가 끊임없이 사용자와 NPC 중 한 명으로 바뀌기 때문에, SetActive를 활용하여 이름표, 캐릭터 등 UI를 상황에 맞게 변경하였다. 대화 시스템은 프롤로그, 메인 스테이지 1,2,3, 엔딩에서 사용되었다. 그림1은 Stage 1 대화 화면 중 일부이다.

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/8d96b047-8d09-4e45-8025-0939732e60ed)
<br>그림 1. Stage 1 대화 화면



### 3. 선택지 시스템

각 씬의 대화가 끝나면 사용자는 맥락에 맞는 어휘가 사용된 선택지를 선택하여야 하는데 이는 버튼으로 구현하였고 버튼에 스크립트를 연결하여 사용자에게 정답/오답 여부를 알려주는 Popup 화면이 보이도록 하였다. Popup 화면에서 사용자가 확인 버튼을 누르면 씬 이동이 진행되는데 버튼에 스크립트를 연결하여 사용자 씬 이동을 구현하였다. 사용자의 선택에 따라 NPC의 사용자에 대한 호감도가 변경되어야 하기 때문에 NPC의 사용자에 대한 호감도 데이터를 PlayerPrefs에 저장해두고 선택이 이루어질 때마다 변경하였다. Stage 1, 2, 3는 모두 동일한 기능을 가지기 때문에, 위와 같은 방식으로 개발하였다. 그림 2는 Stage 1의 선택지 선택 화면, 그림 3은 정답/오답 여부를 알려주는 Pop up 화면이다.
 

![캡처 (1)](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/6d55cb3c-2809-4a0d-b76e-cd729c20d869)
<br>그림2 . Stage 1 선택지 선택 화면

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/bbb17705-b51c-44d7-a104-40835c39214c)
<br>그림3 . Stage 1 선택지 선택 화면 후 Popup 화면  


### 4. 미니 게임

미니 게임은 3 종류의 퀴즈 게임으로 구성되어 있는데, Stage 1 미니 게임은 드래그 앤 드롭을 활용한 퀴즈, Stage 2 미니 게임은 OX 선택을 활용한 퀴즈, Stage 3 미니 게임은 글자 선택을 활용한 퀴즈이다.

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/f09773fe-d43c-4bbb-a096-19faf9c71302)
<br>그림4 . Stage 1 미니게임 개발 화면

(1) Stage 1 미니게임
Stage 1 미니 게임은 드래그 앤 드롭을 이용해야하기 때문에 IBeginDragHandler, IEndDragHandler, IDragHandl er, IDropHandler를 이용하였다. 사용자가 드래그를 하면 드래그가 된 컴포넌트의 alpha값을 조절하였고 position 값을 조절하였다. 정답, 오답 여부 구분을 위하여 id를 활용하였고, 정답의 id와 사용자가 드래그한 컴포넌트의 id가 같으면 정답, 다르면 오답처리하였다. 그림 4은 Stage 1 미니게임 화면 중 일부이다.  

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/6f92608f-ec2c-4863-a6b9-06086f84c542)
<br>그림5 . Stage 2 미니게임 개발 화면 

(2) Stage 2 미니 게임
Stage 2 미니 게임은 OX 게임이기 때문에 버튼을 만들어 사용자로 하여금 선택하도록 하였다. 버튼에 스크립트를 연결해 사용자가 버튼을 누른 이후에 버튼을 또 누르지 못하게 하기위하여 interactable 요소를 이용하였다.변화를 반영하였다.제한시간이 지나면 버튼을 누를 수 없게 하기 위하여 interactable 요소를 이용하였다. 그림 5은 Stage 2 미니게임 화면 중 일부이다. 

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/9443469c-57c5-4899-af3f-a32828dabf35)
<br>그림6 . Stage 3 미니게임 개발 화면 

(3) Stage 3 미니 게임
Stage 3 미니게임은 글자 버튼을 클릭하면 답안 부분에 글자가 나타나도록 하였다. 클릭한 게임 오브젝트를 가져와서 저장해야했기 때문에 EventSystem의 CurrentSele ctedGameObject를 활용하였다. 확인 버튼을 누르면 버튼이 더 이상 눌리지않도록 하기 위하여 interactable 요소를 이용하였다. 확인 버튼을 누른 후에는 입력한 답과 실제 답이 맞는지 if문을 활용하여 확인하였다. 그림 6은 Stage 3 미니게임 화면 중 일부이다. 

3단계의 미니게임 모두 사용자의 정답 여부에 따라 NPC의 사용자에 대한 호감도가 변경되어야 하기 때문에 NPC의 사용자에 대한 호감도 데이터를 PlayerPrefs에 저장해두고 풀이가 이루어질 때마다 변경하였다. 사용자의 정답/ 오답 판별은 버튼의 OnClick 기능을 활용하였다. 정답/ 오답 여부를 알려주는 문구가 나오고 1.5초 이후에 씬 이동을 하기 위하여 Invoke를 활용하였다. 제한시간은 Time. deltaTime을 이용하여 시간의 변화를 반영하였다. 미니게임 2,3은 제한시간이 지나면 버튼을 누를 수 없게 하기 위하여 interactable 요소를 이용하였다.

### 5. 기타 

![캡처 (2)](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/fe1f39af-a0cf-42bf-b9d0-abcfd4d41971)
<br>그림7 . 게임 시작 화면

(1) 게임 시작
게임 시작화면은 버튼에 스크립트를 연결해 게임 시작과 게임 종료를 하게 하였다. 마우스가 글자 위에 오버되면 new Color(r,g,b,a)을 활용해 투명도를 변경하였다. 그림 7은 게임 시작 화면의 모습이다.


![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/e1f482eb-8d6b-486e-ac01-c0cf912236fc)
<br>그림8 . 이름 입력 화면


(2) 이름 입력
이름 입력은 InputField와 버튼을 활용하였고 사용자의 이름 데이터를 PlayerPrefs에 저장해 다른 씬에서도 활용하였다. InputField에 입력 된 스트링이 비었는지를 판별하여 아무 것도 입력하지 않았을 때 다음 화면으로 넘어가지못하도록 하였다. 그림 8은 이름 입력 화면의 모습이다.

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/3888236c-e8e5-42bf-b44f-2087c294bf5b)
<br>그림9 . 게임 종료 화면

(3) 게임 종료
게임 종료 화면은 버튼을 배치하고 키보드의 입력을 받아 ESC키를 누르면 SetActive를 활용해 화면이 나타나도록 하였다. 그림 9는 게임 종료 화면의 모습이다.


![캡처 (3)](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/54d1684b-7820-407c-9146-49789fcfccbe)
<br>그림10 . 문장 쓰기 화면

(4) 문장 쓰기
문장 쓰기 화면은 사용자가 배운 단어를 이용해 문장을 써야하기 때문에, InputField를 활용하였고 문자열이 비었는지를 판별해 아무것도 쓰지 않으면 다음 씬으로 넘어갈 수 없게 하였다. 또한, 사용자가 쓴 글을 저장하기 위하여 ScreenCapture 기능을 활용하여 화면이 자동 캡처되고 사용자의 PC에 저장되도록 하였다. 캡처 파일 이름은 어휘 공부라는 단어에 사용자가 작성한 년, 월, 일, 시, 분, 초가 나타나도록 구성하였다. 그림 10은 문장 쓰기 화면 중 일부이다. 

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/ff6e2b70-8d4e-4c57-adfc-1b42807a89b1)
<br>그림11 . 남자 주인공 선택 화면 

(5) 남자 주인공 선택
남자 주인공 선택 화면은 사용자가 남자 주인공을 선택하면 이미지의 테두리에 표시를 하기 위하여 enabled를 활용하였다. PlayerPrefs에 저장해두었던 각 주인공 별 호감도 데이터를 불러와 호감도에 따라 LoadScene기능을 활용하여 선택한 캐릭터의 굿, 노멀, 배드 엔딩으로 씬 이동을 하게 하였다. 그림 11는 남자 주인공 선택 화면의 모습이다. 

![image](https://github.com/ekgus9701/23-1_CapstoneProject/assets/52192706/f715fb27-037d-43d3-a27e-18d207e0c7f1)
<br>그림12 . 단어 의미 복습 화면

(6) 단어 의미 복습
마지막 씬에 사용자가 배운 단어를 차례대로 복습할 수 있도록 버튼에 스크립트를 연결해 다른 단어 씬으로 이동할 수 있도록 하였다. 그림 12은 단어 의미 복습 화면 중 일부이다. 





