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
        float horizontol = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontol * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        transform.position = position;
    }
}
