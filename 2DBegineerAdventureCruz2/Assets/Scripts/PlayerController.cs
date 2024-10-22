using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float Speed = 4.0f;
    private float horizontol;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horazontol = Input.GetAxis("Horizontol");
        float vertical = Input.GetAxis("vertical");

        Vector2 position = transform.position;
        position.x = position.x + Speed * horizontol * Time.deltaTime;
        position.y = position.y + Speed * vertical * Time.deltaTime;

        transform.position = position;
    }
}
