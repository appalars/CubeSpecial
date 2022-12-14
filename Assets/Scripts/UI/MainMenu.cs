using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button optionenButton;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        startButton.onClick.AddListener(LoadIntro);
        optionenButton.onClick.AddListener(LoadOptions);
    }

    private void LoadIntro()
    {
        gameManager.LoadScene("Intro");
    }

    private void LoadOptions()
    {
        gameManager.LoadScene("Optionen");
    }
}