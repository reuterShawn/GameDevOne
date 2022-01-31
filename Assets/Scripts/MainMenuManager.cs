using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(() => LoadingScreen.LoadScene("GameScene1"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
