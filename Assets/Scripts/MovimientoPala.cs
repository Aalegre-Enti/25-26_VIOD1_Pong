using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoPala : MonoBehaviour
{
    public float speed;
    public bool playerA;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(0, 0, 0);
        if (playerA)
        {
            if (Keyboard.current.wKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                dir.y = -1;
            }
            if (Keyboard.current.dKey.isPressed)
            {
                dir.x = 1;
            }
            if (Keyboard.current.aKey.isPressed)
            {
                dir.x = -1;
            }
        }
        else
        {
            if (Keyboard.current.upArrowKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                dir.y = -1;
            }
            if (Keyboard.current.rightArrowKey.isPressed)
            {
                dir.x = 1;
            }
            if (Keyboard.current.leftArrowKey.isPressed)
            {
                dir.x = -1;
            }
        }

        dir.Normalize();

        transform.position += dir * speed * Time.deltaTime;
    }
}