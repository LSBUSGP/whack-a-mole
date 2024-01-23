using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    public Game game;
    public AudioSource sound;
    public AudioClip [] hits;
    void OnMouseDown()
    {
        game.HitMole();
        sound.PlayOneShot(hits[Random.Range(0, hits.Length)]);
    }
}
