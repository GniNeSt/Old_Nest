using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeMain(){
        SceneManager.LoadScene("Main");
    }

    public void ChangeLoad(){
        SceneManager.LoadScene("Load");
    }

    public void ChangeSettings(){
        SceneManager.LoadScene("Settings");
    }
    
}
