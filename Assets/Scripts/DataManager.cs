using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager
{
    public string choice_first;
    public string choice_second;
    public string choice_third;
    public string choice_fourth;
    public Data data;
    
    public DataManager() {
        data = JsonUtility.FromJson<Data>(File.ReadAllText(Application.dataPath + "/Table/choicement.json"));
    }

    public Choice giveChoice(string enemyname){
        if(enemyname == "Goblin")
           return data.Goblin; 
        else if(enemyname == "Gnoll")
            return data.Gnoll;
        else if(enemyname == "Chicken")
            return data.Chicken;
        else if(enemyname == "Wolf")
            return data.Wolf;
        else if(enemyname == "Boar")
            return data.Boar;
        else if(enemyname == "Ork")
            return data.Ork;
        else
            return data.Goblin;
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
    public Choice Goblin;
    public Choice Gnoll;
    public Choice Chicken;
    public Choice Wolf;
    public Choice Boar;
    public Choice Ork;
}