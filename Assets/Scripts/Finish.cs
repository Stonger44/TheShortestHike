using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
   public Collider2D playerController;
   public ParticleSystem finishParticleSystem;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other == playerController)
      {
         if (finishParticleSystem.gameObject.activeSelf == false)
         {
            finishParticleSystem.gameObject.SetActive(true);
         }
      }
   }
}
