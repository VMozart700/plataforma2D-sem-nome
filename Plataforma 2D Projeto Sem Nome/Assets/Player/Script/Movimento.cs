using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    
     public Rigidbody2D rig;

    public float velocidade;
    public float velPulo;
    public float Gravidade;
    public float timer;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        Pulinho();
    }

    void Movimentacao()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
             rig.velocity = new Vector2(-velocidade,0);
        }
        if(Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            rig.velocity = new Vector2(velocidade,0);
        }
    }

     IEnumarator Pulinho()
    {
       if(Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
       {
          rig.AddForce(Vector2.up*velPulo,ForceMode2D.Impulse);
             
       
       }
    }

   
     
}
