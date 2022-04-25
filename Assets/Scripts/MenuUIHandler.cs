using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text playerNameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.playerName = playerNameInput.text;
        //Debug.Log(PlayerDataHandle.Instance.playerName);
        Debug.Log("Greetings " + playerNameInput.text);
    }

    public void ExitGame()
    {
        // MainManager.inst

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
