using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class difficulties : MonoBehaviour
{
    private Button button;
    private gameManager gameManager;
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        gameManager = GameObject.Find("gamemanager").GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
