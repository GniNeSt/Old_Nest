using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    public GameObject player;
    public float isRight;
    private float moveSpeed = 0f;
    private int backgroundsize = 90;
    private int nextPosX;
    // backgroundsize는 GroundManager 스크립트에 똑같이 저장되어있음. 만약 오류가 날 시에는 static 같은거로 변환해서 하나로 통일시켜 유지하는것도 나쁘지 않은 방법임
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x < 10 + 90 * (nextPosX))
        {
            player.transform.position += Vector3.right * isRight * moveSpeed * Time.deltaTime;   
        } 
        else 
        {
            moveSpeed = 0f;
        }
    }

    private void OnMouseDown() {
        Debug.Log(this.name);
        moveSpeed = 30f;
        nextPosX = GroundManager.poscount + 1;
    }
}
