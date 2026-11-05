using UnityEngine;

public class WS1 : MonoBehaviour
{
    private bool lovesZelda = true;
    private string name = "Ocarina of Time remake release thursday, be HYPED!!";
    private int age = 98;
    private float speed = 19.98f;
    
    private Rigidbody2D rb;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(name);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Yspeed();
        }
    }

    void Yspeed()
    {
        rb.linearVelocityY = 3f;
    }
}
