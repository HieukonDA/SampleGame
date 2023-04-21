using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{

     private void OnTriggerEnter2D(Collider2D col)
     {
        if(col.gameObject.CompareTag("Player"))
        {
            Invoke("CompleteLevel",2f);
            CompleteLevel();
        }
     }
     private void CompleteLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    

    
}
