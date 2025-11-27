using UnityEngine;

public class LimitMovement : MonoBehaviour
{
    public float limitYMax = 3.5f;
    public float limitYMin = -3.5f;
    public float limitXMax;
    public float limitXMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > limitYMax)
        {
            transform.position = new Vector3(transform.position.x, limitYMax, transform.position.z);
        }
        if (transform.position.y < limitYMin)
        {
            transform.position = new Vector3(transform.position.x, limitYMin, transform.position.z);
        }


        if (transform.position.x > limitXMax)
        {
            transform.position = new Vector3(limitXMax, transform.position.y, transform.position.z);
        }
        if (transform.position.x < limitXMin)
        {
            transform.position = new Vector3(limitXMin, transform.position.y, transform.position.z);
        }
    }
}
