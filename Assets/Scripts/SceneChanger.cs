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
    
    public void ChangeMenu(){
        SceneManager.LoadScene("StartMenu");
    }
    public void EndingViolence(){
        SceneManager.LoadScene("StartMenu");
    }
    public void EndingSane(){
        SceneManager.LoadScene("StartMenu");
    }
    public void EndingNonViolence(){
        SceneManager.LoadScene("StartMenu");
    }
    public void EndingNonSane(){
        SceneManager.LoadScene("StartMenu");
    }
    public void EndingViolenceSane(){
        SceneManager.LoadScene("StartMenu");
    }
    public void EndingViolenceNonSane(){
        SceneManager.LoadScene("StartMenu");
    }
    public void EndingNonViolenceSane(){
        SceneManager.LoadScene("StartMenu");
    }
    public void Normal(){
        SceneManager.LoadScene("StartMenu");
    }
}
