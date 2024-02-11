using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class DinoScript : MonoBehaviour
{
    public Rigidbody2D DinoRigid;
    public float velocity;
    public ScoreScript script;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        velocity = 10;
        script = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) && isAlive)
        {
            DinoRigid.velocity = Vector2.up * velocity;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
        }

    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.transform.name=="terrain(Clone)"){
            script.gameOver();
            isAlive = false;
        }
    }
}
