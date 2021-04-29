using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceClick : MonoBehaviour{
    private int thisnumber;
    private void Start() {
        if (transform.name == "first"){
            thisnumber = 1;
        } else if (transform.name == "second") {
            thisnumber = 2;
        } else if (transform.name == "third") {
            thisnumber = 3;
        } else if (transform.name == "fourth"){
            thisnumber = 4;
        }
    }
    private void OnMouseUp() {
        ChoiceManager.clicked_choice = thisnumber;
        ChoiceManager.ChoiceAct();
    }
}
