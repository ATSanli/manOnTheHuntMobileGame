using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pciçinhariektkodları : MonoBehaviour
{

    [SerializeField]
    private float ileriGitmehizi;
    [SerializeField]
    private float sagaSolagitme;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal")*sagaSolagitme*Time.deltaTime;
        this.transform.Translate(yatayEksen,0,ileriGitmehizi*Time.deltaTime);
    }
}
