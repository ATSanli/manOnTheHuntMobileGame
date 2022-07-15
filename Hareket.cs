using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

   


    
    Rigidbody rigi;
    bool sol;
    bool sag;

    float hiz = 5.0f;
    float ziplama = 5.0f;

   




    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sag_git = new Vector3(1.90f, transform.position.y,transform.position.z);
        Vector3 sol_git = new Vector3(-1.30f, transform.position.y, transform.position.z);
        transform.Translate(0, 0, hiz * Time.deltaTime);
        if(Input.touchCount > 0)
        {

          


            //mobile için hareket kodlarý

            
            Touch parmak = Input.GetTouch(0);
            if (parmak.deltaPosition.x > 50.0f)
            {
                sag = true;
                sol = false;
            }
            if (parmak.deltaPosition.x < -50.0f)
            {
                sag = false;
                sol = true;
            }
            if (parmak.deltaPosition.y > 50.0f)
            {
                rigi.velocity = Vector3.zero;
                rigi.velocity = Vector3.up * ziplama;
            }
            if (sag == true)
            {
                transform.position=Vector3.Lerp(transform.position, sag_git, 5 * Time.deltaTime);
            }
            if (sol == true)
            {
                transform.position = Vector3.Lerp(transform.position, sol_git, 5 * Time.deltaTime);
            }
            


        }
    }
}
