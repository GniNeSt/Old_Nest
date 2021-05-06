using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    public GameObject player;
    public Transform first,second,third,fourth;
    public GameObject firstenemy;
    public int clicked_choice;
    public bool isMoving;
    public float moveSpeed = 0f;
    private int backgroundsize = 90;
    public static int nextPosX;
    // backgroundsize는 GroundManager 스크립트에 똑같이 저장되어있음. 만약 오류가 날 시에는 static 같은거로 변환해서 하나로 통일시켜 유지하는것도 나쁘지 않은 방법임
    // private int cviolence,csane;
    
    void Start()
    {
        first = transform.GetChild(0);
        second = transform.GetChild(1);
        third = transform.GetChild(2);
        fourth = transform.GetChild(3);
        firstenemy = GameObject.Find("Enemy");
        firstenemy.GetComponent<Character>().Initialize("Goblin");
        

    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < backgroundsize * (nextPosX) && isMoving)
            player.transform.position += Vector3.right * moveSpeed * Time.deltaTime;   
        else 
            moveSpeed = 0f;
    }

    public void ChoiceFirst(){
        Debug.Log("ACT" + clicked_choice);
        isMoving = true;
        nextPosX = GroundManager.poscount + 1;
        moveSpeed = 30f;
    }
    public void ChoiceSecond(){
        Debug.Log("ACT" + clicked_choice);
    }
    public void ChoiceThird(){
        Debug.Log("ACT" + clicked_choice);
    }
    public void ChoiceFourth(){
        Debug.Log("ACT" + clicked_choice);
    }

    public void SetChoice(Choice choice){
        first.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.first.ment;
        second.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.second.ment;
        third.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.third.ment;
        fourth.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.fourth.ment;
    }
}
