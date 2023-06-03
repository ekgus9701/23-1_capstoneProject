
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;  // AudioManager 인스턴스에 접근하기 위한 정적 변수

    public AudioSource audioSource;
    public AudioClip song_main;
    public AudioClip song_prologue;
    public AudioClip song_stage1;
    public AudioClip song_stage2;
    public AudioClip song_stage3;
    public AudioClip song_minigame;
    public AudioClip song_epilogue;
    public AudioClip song_ending;
    
    private int currentSceneIndex;
    private AudioClip currentSong;

    private void Awake()
    {
        // AudioManager 싱글톤 패턴 적용
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
         audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        // 초기 씬 인덱스를 설정합니다.
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 초기 씬에 따라 해당하는 노래를 재생합니다.
        PlaySceneSong(currentSceneIndex);
    }

    private void OnEnable()
    {
        // 씬 전환 시 이벤트 리스너를 등록합니다.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // 이벤트 리스너를 해제합니다.
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 씬 전환 후 현재 씬 인덱스를 업데이트하고 해당하는 노래를 재생합니다.
        currentSceneIndex = scene.buildIndex;

        PlaySceneSong(currentSceneIndex);
    }

    private void PlaySceneSong(int sceneIndex)
    {
        AudioClip songToPlay = null;

       // 씬 인덱스에 따라 재생할 노래를 선택합니다.
        if (sceneIndex >=0 && sceneIndex <=1)
        {
            songToPlay = song_main;
        }
        else if (sceneIndex >=2  && sceneIndex <= 4)
        {
            songToPlay = song_prologue;
        }
         else if (sceneIndex >=5  && sceneIndex <= 17)
        {
            songToPlay = song_stage1;
        }
         else if (sceneIndex >=18  && sceneIndex <= 22)
        {
            songToPlay = song_minigame;
        }
         else if (sceneIndex >=23  && sceneIndex <= 35)
        {
            songToPlay = song_stage2;
        }
         else if (sceneIndex >=36  && sceneIndex <= 40)
        {
            songToPlay = song_minigame;
        }
         else if (sceneIndex >=41  && sceneIndex <= 54)
        {
            songToPlay = song_stage3;
        }
         else if (sceneIndex >=55  && sceneIndex <= 59)
        {
            songToPlay = song_minigame;
        }
         else if (sceneIndex >=60  && sceneIndex <= 65)
        {
            songToPlay = song_epilogue;
        }
         else if (sceneIndex >=66  && sceneIndex <= 74)
        {
            songToPlay = song_ending;
        }
      
        else
        {
            songToPlay = song_main;
        }

          if (songToPlay == currentSong)
        {
            return;
        }

        // 오디오 소스를 통해 노래를 재생합니다.
        audioSource.clip = songToPlay;
        audioSource.loop = true; // 반복 재생을 활성화합니다.
        audioSource.Play();

        // 현재 재생 중인 노래를 업데이트합니다.
        currentSong = songToPlay;
    }
}
