using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceClick : MonoBehaviour{
    private ChoiceManager choicemanager;
    public GameObject hero;
    // private int thisnumber;
    public ChoiceEach thisdata;
    private Animator animator;
    private MentManager mentManager;
    public SceneChanger sceneChanger;
    private void Start() {
        choicemanager = GameObject.Find("ChoiceManager").GetComponent<ChoiceManager>();
        animator = GameObject.Find("Ment").GetComponent<Animator>();
        mentManager = GameObject.Find("Ment").GetComponent<MentManager>();
    }
    public void Init(ChoiceEach choice)
    {
        thisdata = choice; 
        transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.ment + "\n 필요폭력수치:" + thisdata.success.needviolence.ToString() + "\n 필요이성수치:" + thisdata.success.needsane.ToString();
    }
    private void OnMouseUp() {
        if(Hero.violence >= thisdata.success.needviolence && Hero.sane >= thisdata.success.needsane)
        {
            Hero.violence += thisdata.success.violence;
            Hero.sane +=  thisdata.success.sane;
            Debug.Log(thisdata.success.ment);
            Debug.Log("ACT" + transform.name + ", Currnet Violence: " + Hero.violence.ToString() + ", Currnet Sane: " + Hero.sane.ToString());
            animator.SetBool("isMent",true);
            mentManager.SetMent(thisdata.success.ment);
        }
        else
        {
            Hero.violence += thisdata.fail.violence;
            Hero.sane +=  thisdata.fail.sane;
            Debug.Log(thisdata.fail.ment);
            Debug.Log("ACT" + transform.name + ", Currnet Violence: " + Hero.violence.ToString() + ", Currnet Sane: " + Hero.sane.ToString());
            animator.SetBool("isMent",true);
            mentManager.SetMent(thisdata.fail.ment);
        }
        if(GroundManager.poscount < 9)
            choicemanager.Move();
        else
            sceneChanger.EndingViolence();
    }
}
