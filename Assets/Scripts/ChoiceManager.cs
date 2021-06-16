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
    public void Move()
    {
        isMoving = true;
        nextPosX = GroundManager.poscount + 1;
        moveSpeed = 70f;
    }

    public void SetChoice(Choice choice)
    {
        first.GetComponent<ChoiceClick>().Init(choice.first);
        second.GetComponent<ChoiceClick>().Init(choice.second);
        third.GetComponent<ChoiceClick>().Init(choice.third);
        fourth.GetComponent<ChoiceClick>().Init(choice.fourth);
    }
    public void SetChoice(Choice choice, Companion companion)
    {
        first.GetComponent<ChoiceClick>().Init(choice.first,companion);
        second.GetComponent<ChoiceClick>().Init(choice.second,companion);
        third.GetComponent<ChoiceClick>().Init(choice.third,companion);
        fourth.GetComponent<ChoiceClick>().Init(choice.fourth,companion);
    }
}
