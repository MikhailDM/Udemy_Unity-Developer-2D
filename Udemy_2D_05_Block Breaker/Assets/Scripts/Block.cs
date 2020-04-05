using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //Parametres    
    [SerializeField] AudioClip breakSounds;

    //Cached References
    Level level;


    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        FindObjectOfType<GameStatus>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSounds, Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
    }
}
