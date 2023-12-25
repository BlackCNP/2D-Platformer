using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlat : MonoBehaviour
{
   // Перевірка, чи "Player" торкається платформи
   
    private void OnTriggerEnter2D(Collider2D collision)   
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform); //липка платформа 
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);         
        }

    }
}