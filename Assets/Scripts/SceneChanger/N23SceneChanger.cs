using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class N23SceneChanger : MonoBehaviour
{
    private string sceneName = "FirstScene";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    void Exit()
    {
        Application.Quit();
    }
}
