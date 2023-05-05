using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    public float speed = 0.0f;
    public float aceleration = 0.1f;
    public float stopAceleration = 0.5f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Esto es para combinar la animacion de caminar con correr
        bool movePress = Input.GetKey("w");
        //bool runPress = Input.GetKey("r");

        if (movePress && speed < 1.0f)
        {
            speed += Time.deltaTime * aceleration;
        }
        if (!movePress && speed > 0.0f)
        {
            speed -= Time.deltaTime * stopAceleration;
        }
        if (!movePress && speed < 0.0f)
        {
            speed = 0.0f;
        }

        anim.SetFloat("Speed", speed);
        
        //Esto es para asignar la tecla de espacio para saltar
        if (Input.GetKey("space"))
        {
            anim.SetBool("Jump", true);
        }
        if (!Input.GetKey("space"))
        {
            anim.SetBool("Jump", false);
        }


    }
}
