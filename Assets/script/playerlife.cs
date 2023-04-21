 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerlife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      anim = GetComponent<Animator>();
    }

     private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.CompareTag("DeathZone"))
         {
          Debug.Log("on going");
           Die();
           restartLevel();

         }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("trapspike"))
         {
          Debug.Log("on going");
           Die();
           restartLevel();

         }
    }
    private void Die()
    {

     
     // rb.bodyType = RigidbodyType2D.Static;
        
      anim.SetTrigger("death");
    }

     private void restartLevel()
      {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }

 
    
}
