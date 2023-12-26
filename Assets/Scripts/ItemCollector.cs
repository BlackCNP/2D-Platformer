using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int bananas = 0;
    public static bool colectbananas=false;

    [SerializeField] private Text bananasText;
    [SerializeField] private AudioSource banasAudioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
            banasAudioSource.Play();
            Destroy(collision.gameObject);
            bananas++;
            bananasText.text = "Bananas: " + bananas;
        }
        if (bananas >= 3)
        {
            colectbananas = true;
        }
    }
}
