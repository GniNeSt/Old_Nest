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
        SceneManager.LoadScene("EndingViolence");
    }
    public void EndingSane(){
        SceneManager.LoadScene("EndingSane");
    }
    public void EndingNonViolence(){
        SceneManager.LoadScene("EndingNonViolence");
    }
    public void EndingNonSane(){
        SceneManager.LoadScene("EndingNonSane");
    }
    public void EndingViolenceSane(){
        SceneManager.LoadScene("EndingViolenceSane");
    }
    public void EndingViolenceNonSane(){
        SceneManager.LoadScene("EndingViolenceNonSane");
    }
    public void EndingNonViolenceSane(){
        SceneManager.LoadScene("EndingNonViolenceSane");
    }
    public void EndingNonViolenceNonSane(){
        SceneManager.LoadScene("EndingNonViolenceNonSane");
    }
    public void EndingNormal(){
        SceneManager.LoadScene("EndingNormal");
    }
}
