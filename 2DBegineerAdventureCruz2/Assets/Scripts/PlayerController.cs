using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class DuckoController : MonoBehaviour
{
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontol = Input.GetAxis("Horizontol");
        float vertical = Input.GetAxis("vertical");

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontol;
        position.y = position.y + 0.1f * vertical;

        transform.position = position;
    }
}
