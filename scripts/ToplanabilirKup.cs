using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirKup : MonoBehaviour
{
    bool ToplandiMi;
    int index;
    public Toplayici toplayici;

    void Start()
    {
        ToplandiMi = false;
    }


    void Update()
    {
        if (ToplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            toplayici.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled=false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool GetToplandiMi()
    {
        return ToplandiMi;
    }

    public void ToplandiYap()
    {
        ToplandiMi=true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index; 
    }
}
