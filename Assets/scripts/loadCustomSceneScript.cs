using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadTavernScene1 : MonoBehaviour
{
    void loadCustomScene(string sceneName)
    {
        Debug.Log("Loading Scene : " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
