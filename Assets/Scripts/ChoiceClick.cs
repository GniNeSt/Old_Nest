using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceClick : MonoBehaviour{
    private ChoiceManager choicemanager;
    private int thisnumber;
    private void Start() {
        choicemanager = GameObject.Find("ChoiceManager").GetComponent<ChoiceManager>();
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
        choicemanager.clicked_choice = thisnumber;
        choicemanager.ChoiceAct();
    }
}
