 using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cherry : MonoBehaviour
{
    private int cherries = 0;
    public TextMeshProUGUI cherriesText;
 
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.CompareTag("cherry"))
         {
           Debug.Log("OnCollisionEnter2D"); 
             Destroy(col.gameObject);
             cherries++ ;
             cherriesText.text = "cherries : "+ cherries;

         }
    }
 
}
