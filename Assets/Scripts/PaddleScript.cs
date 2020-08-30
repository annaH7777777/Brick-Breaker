using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed; 
    public float rightBorder; 
    public float leftBorder;
    public GameManagerScript gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gameOver)
        {
            return;
        }
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontal*Time.deltaTime*speed);
        if (transform.position.x < leftBorder)
            transform.position = new Vector2(leftBorder, transform.position.y);
        if (transform.position.x > rightBorder)
            transform.position = new Vector2(rightBorder, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("extraLife"))
        {
            gm.UpdateLives(1);
            Destroy(other.gameObject);
        }
   
    }
}
