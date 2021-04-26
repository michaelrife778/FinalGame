using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    private bool isGameActive = false;

    public static GameManager instance;

    public SpawnManager platformSpawner;

    [HideInInspector]
    public PlatformManager currentPlatform;



    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        platformSpawner.SpawnPlatform();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DetectInput();
    }

    void DetectInput()
    {
        if (Input.GetMouseButtonDown(0) && isGameActive == true)
        {
            currentPlatform.DropPlatform();
        }
    }

    public void StartGame()
    {
        titleScreen.gameObject.SetActive(false);
        Time.timeScale = 1;
        isGameActive = true;
    }
}
