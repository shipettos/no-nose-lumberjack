using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour
{
    public void doExitGame()
    {
        Debug.Log("clicked");
        Application.Quit();        
    }
}
