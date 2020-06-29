using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject bulletspawner;
    public Transform bulletOrigin;

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (collision.gameObject.CompareTag("Meteorite"))
        {
            Meteorite meteorite = collision.gameObject.GetComponent<Meteorite>();

            if (meteorite != null)
            {
               
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }

        }
        else if (collision.gameObject.CompareTag("Enemigo"))
        {
            Enemigo enemigo = collision.gameObject.GetComponent<Enemigo>();

            if (enemigo != null)
            {

                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}