using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

public TextMeshProUGUI gameTitle;
public Button StartButton;
public bool isGameActive;
public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame() {
       isGameActive = true;
        titleScreen.gameObject.SetActive(false);

    }
}
