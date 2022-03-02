using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button platformerButton;
    [SerializeField] private Button spawnButton;
    [SerializeField] private Button pongButton;
    [SerializeField] private Button fpsButton;
    [SerializeField] private Button openCreditsButton;
    [SerializeField] private Button closeCreditsButton;
    [SerializeField] private GameObject creditsUI;
    [SerializeField] private GameObject mainScreen;
    
    // Start is called before the first frame update
    private void Awake() {
    
        Cursor.lockState = CursorLockMode.None;
        creditsUI.SetActive(false);
        
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("GameScene1"));

        platformerButton.onClick.AddListener(() => LoadingScreen.LoadScene("NotQuitePlatformer"));

        spawnButton.onClick.AddListener(() => LoadingScreen.LoadScene("3DSpawn"));

        pongButton.onClick.AddListener(() => LoadingScreen.LoadScene("Pong"));

        fpsButton.onClick.AddListener(() => LoadingScreen.LoadScene("FPS"));

        openCreditsButton.onClick.AddListener(() => {creditsUI.SetActive(true); 
        mainScreen.SetActive(false);});

        closeCreditsButton.onClick.AddListener(() => {creditsUI.SetActive(false);
        mainScreen.SetActive(true);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
