using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    
     public Rigidbody2D rig;

    public float velocidade;
    public float velPulo;
    public bool EstaPulando;
    
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

    void Pulinho()
    {
       if(Input.GetKeyDown(KeyCode.W) && !EstaPulando)
       {
          rig.velocity = new Vector2(0,velPulo); 
       
       }
    }

   
     
}
