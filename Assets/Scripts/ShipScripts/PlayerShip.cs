using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 300;
    public float hInput;
    public float vInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.isPaused)
        {
            hInput = Input.GetAxisRaw("Horizontal");
            vInput = Input.GetAxisRaw("Vertical");

            Vector2 movement = new Vector2(hInput, vInput);
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }
}
