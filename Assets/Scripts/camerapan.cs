using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerapan : MonoBehaviour
{
    private float speed = 1;
    public GameObject goat;
    public GameObject gameover;

    public int check1 = 15;
    public int check2 = 30;
    public int check3 = 50;

    private float check0speed =1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(goat.transform.position.y);
        //Debug.Log(this.transform.position.y);

        //arrow keys move camera
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        //}

        //camera moves automatically
        Debug.Log(speed);
        if (goat.transform.position.y < check1)
        {
            //speed = check0speed;
            speed += 0.0001f;
            Debug.Log("startspeed");
        }
        else if((goat.transform.position.y > check1)||(goat.transform.position.y < check2))
        {
            speed -= 0.0001f;
            Debug.Log("secondspeed");
        }
        else if ((goat.transform.position.y > check3))
        {
            speed += 0.001f;
            Debug.Log("thirdspeed");
        }


        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        //transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));


        //die if goat goes off screen
        if ((this.transform.position.y - goat.transform.position.y > 6))
        {
            Debug.Log("bottomscreen");
            gameover.SetActive(true);
        }
        if ((this.transform.position.y + goat.transform.position.y < -6))
        {
            Debug.Log("topscreen");
            gameover.SetActive(true);

        }

        
    }

    
}
