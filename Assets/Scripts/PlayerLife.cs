using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    //public static int Life;
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource Diesound;
    private void Start()
    {
      //  Life = 1;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
   

    private  void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();

        }
    }
  

    private void Die()
    {
        Diesound.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
       // Life = 0;
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
