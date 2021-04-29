using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    public GameObject player,first,second,third,fourth;
    public static int clicked_choice;
    public static bool isMoving;
    public static float moveSpeed = 0f;
    private int backgroundsize = 90;
    public static int nextPosX;
    // backgroundsize는 GroundManager 스크립트에 똑같이 저장되어있음. 만약 오류가 날 시에는 static 같은거로 변환해서 하나로 통일시켜 유지하는것도 나쁘지 않은 방법임
    
    void Start()
    {
        first = transform.GetChild(0).gameObject;
        second = transform.GetChild(1).gameObject;
        third = transform.GetChild(2).gameObject;
        fourth = transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < backgroundsize * (nextPosX) && isMoving)
            player.transform.position += Vector3.right * moveSpeed * Time.deltaTime;   
        else 
            moveSpeed = 0f;
    }

    public static void ChoiceAct(){
        Debug.Log("ACT" + clicked_choice);
        ChoiceManager.isMoving = true;
        nextPosX = GroundManager.poscount + 1;
        moveSpeed = 30f;
    }
}
