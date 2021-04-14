using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    //주인공 받아와서 어느 백그라운드 안에 있는지 좌표를 통해서 알아내고 그 특정 좌표중 일부를 통과시 새 백그라운드를 생성, 특정 좌표를 지나면 다시 없어지는걸로
    //카메라는 양옆으로 70 사이즈
    //백그라운드는 가로로 90 사이즈
    //주인공은 카메라로부터 왼쪽으로 10만큼 있음
    //주인공이 0,0부터시작한다고 치고 
    //백그라운드 가로길이 // 백그라운드 세로길이 45
    //백그라운드 처음에 45에서 시작
    //주인공이 40이 될때 갱신
    //20 + 90 * n 된 위치를 지날때마다 생성
    //주인공이 90 * n 위칠 지날때마다 지나간 것을 제거

    public GameObject player;
    public GameObject background;
    private int count;
    private int backgroundsize = 90;
    private int camerasize = 70;
    private Vector3 playerPos;

    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        if (playerPos.x > 20 + 90 * (count))
        {
            count += 1;
            Instantiate(background, this.transform.position + new Vector3(90,0,0) * count, Quaternion.identity);
        }
    }
}
