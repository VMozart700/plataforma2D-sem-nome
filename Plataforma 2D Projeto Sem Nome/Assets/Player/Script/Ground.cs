using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Movimento Player;
   void Start()
   {
      Player = gameObject.transform.parent.gameObject.GetComponent<Movimento>();
   }

   void OnCollisionEnter2D(Collision2D Col)
   {
      if(Col.gameObject.layer == 3)
      {
         Player.EstaPulando = false;
      }
   }
   void OnCollisionExit2D(Collision2D Coli)
   {
         if(Coli.gameObject.layer == 3)
      {
         Player.EstaPulando = true;
      }
   }
}


