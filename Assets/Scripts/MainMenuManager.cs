using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button openCreditsButton;
    [SerializeField] private Button closeCreditsButton;
    [SerializeField] private GameObject creditsUI;
    [SerializeField] private GameObject mainScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        creditsUI.SetActive(false);
        
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("GameScene1"));

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
