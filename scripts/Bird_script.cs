using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_script : MonoBehaviour
{
    public bool Isdead = false;
    public float velocity = 1f;
    public Rigidbody2D body;
    public GameManager manager;

    public GameObject Death;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = Vector2.up * velocity;  
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ic")
        {
            manager.Update_score();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Death_Area")
        {
            Isdead = true;
            Time.timeScale = 0;
            Death.SetActive(true);
        }
    }
}
