using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBox : MonoBehaviour
{
    [Header("Unity Setup")]
    public ParticleSystem boxDestroy;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Engel"))
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

}

