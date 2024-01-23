using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Game game;
    public AudioSource sound;
    public AudioClip [] misses;
    void OnMouseDown()
    {
        game.MissMole();
        sound.PlayOneShot(misses[Random.Range(0, misses.Length)]);
    }
}
