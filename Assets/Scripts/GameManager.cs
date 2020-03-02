using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public string input;
    private int prevInput;

    [Header("Goat")]
    public Rigidbody2D[] legs;
    private int currentLeg = 0;

    [Header("Forces")]
    public float stepForce;

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







        if (Input.GetKeyDown(KeyCode.Space))
            Step();
    }

    private void Step()
    {
        legs[currentLeg].AddForce(new Vector2(0f, stepForce), ForceMode2D.Impulse);
        currentLeg = (currentLeg + 1) % 4;
    }
}
