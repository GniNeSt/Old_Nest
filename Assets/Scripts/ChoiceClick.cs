using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceClick : MonoBehaviour{
    private ChoiceManager choicemanager;
    public GameObject hero;
    // private int thisnumber;
    public int choiceviolence;
    public int choicesane;
    private void Start() {
        choicemanager = GameObject.Find("ChoiceManager").GetComponent<ChoiceManager>();
    }
    public void Init(ChoiceEach choice)
    {
        transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.ment;
        choiceviolence = choice.violence;
        choicesane = choice.sane;
    }
    private void OnMouseUp() {
        Hero.violence += choiceviolence;
        Hero.sane += choicesane;
        Debug.Log("ACT" + transform.name + ", Currnet Violence: " + Hero.violence.ToString() + ", Currnet Sane: " + Hero.sane.ToString());
        choicemanager.Move();
    }
}
