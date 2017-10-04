using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

    public void StartGame()
    {
        // "stage01"
        UnityEngine.SceneManagement.SceneManager.LoadScene("stage01");
    }
}