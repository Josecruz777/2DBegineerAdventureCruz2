using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Other)
    {
        DuckoController controller = Other.GetComponent<DuckoController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
