using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string enemyname = "Goblin";
    public Choice choice = new Choice();
    public GameObject player;
    private string data;
    private Data jdata;
    // Start is called before the first frame update
    private void Awake() {
        data = File.ReadAllText(Application.dataPath + "/Table/choicement.json");
        jdata = JsonUtility.FromJson<Data>(data);
    }

    void Start()
    {
        choice = jdata.Goblin;
        player = GameObject.FindWithTag("Player");
        player.transform.Find("Choices").transform.GetChild(0).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.first;
        player.transform.Find("Choices").transform.GetChild(1).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.second;
        player.transform.Find("Choices").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.third;
        player.transform.Find("Choices").transform.GetChild(3).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.fourth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Choice
{   
    public string first = "";
    public string second = "";
    public string third = "";
    public string fourth = "";
}

[System.Serializable]
public class Data
{
    public string[] enemyList;
    public Choice Goblin;
    public Choice Gnoll;
    public Choice Chicken;
    public Choice Wolf;
    public Choice Boar;
    public Choice Ork;
}