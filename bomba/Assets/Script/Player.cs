using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rig;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = Vector2.right * speed;
            transform.eulerAngles = new Vector2(0,180);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = Vector2.left * speed;
            transform.eulerAngles = new Vector2(0,0);
        }

    }
}
