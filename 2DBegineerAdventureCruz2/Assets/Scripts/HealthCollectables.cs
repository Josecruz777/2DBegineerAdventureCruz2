using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthC : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        DuckoController Controller = other.GetComponent<DuckoController>();
        if (Controller != null)
        {
            if (Controller.health < Controller.maxHealth)
            {

                Controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}

