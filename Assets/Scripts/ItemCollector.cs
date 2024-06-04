using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fruits = 0;

    [SerializeField] private Text fruitsText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            collectionSoundEffect.Play();
            //Remove the item
            Destroy(collision.gameObject);
            fruits++;
            fruitsText.text = "Frutas Obtenidas:" + fruits;
        }
    }
    
}