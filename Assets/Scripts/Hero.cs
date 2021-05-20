using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public static int violence;
    public static int sane;
    public static Companion[] companions;
    public static int currentCompanion = 0;
    // Start is called before the first frame update
    void Start()
    {
        companions = new Companion[3];
        violence = 0;
        sane = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void addCompanion(Companion partner)
    {
        companions[currentCompanion] = partner;
        currentCompanion += 1;
    }
}
