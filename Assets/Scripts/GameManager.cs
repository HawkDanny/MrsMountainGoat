using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public string input;
    private int prevInput;

    void Start()
    {
        input = "";
        prevInput = 0;
    }

    void Update()
    {
        int inputInt;
        int.TryParse(input, out inputInt);



        if (inputInt == 1 && prevInput == 0)
        {
            print("clack!");
        }


        prevInput = inputInt;
    }
}
