using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonSc : MonoBehaviour
{

private Button button;
private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(startGame);
        gameManager = GameObject.Find("gameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void startGame(){
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame();

        
    }
}
