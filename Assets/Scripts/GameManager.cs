using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public string input;

    [Header("Goat")]
    public Rigidbody2D[] legs;
    private int currentLeg = 0;

    [Header("Forces")]
    public float stepForce;

    void Start()
    {
        input = "";
    }

    void Update()
    {
        print(input);
        if (input == "1")
        {
            print("clack!");
            Step();
        }



        if (Input.GetKeyDown(KeyCode.Space))
            Step();
    }

    private void Step()
    {
        legs[currentLeg].AddForce(new Vector2(0f, stepForce), ForceMode2D.Impulse);
        currentLeg = (currentLeg + 1) % 4;
    }
}
