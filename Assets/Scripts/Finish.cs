using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;

    // Start is called before the first frame update
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si player colisiona se nivel completado
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            //Invoke para dar diley para cargar el siguiente nivel
            Invoke("CompleteLevel", .8f);
        }
    }

    private void CompleteLevel()
    {
        //cargar siguiente nivel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
