using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public Transform mole;
    public Transform [] holes;
    public SpriteRenderer hitEffect;
    public Sprite [] hitEffects;
    int hits;
    int misses;
    public TMP_Text hitUI;
    public TMP_Text missUI;

    void Start()
    {
        Invoke("ShowMole", 1f);
        UpdateUI();
    }

    void ShowMole()
    {
        Transform hole = holes[Random.Range(0, holes.Length)];
        mole.position = hole.position;
        Invoke("HideMole", 1f);
    }

    void HideMole()
    {
        mole.position = new Vector3(0, -10, 0);
        Invoke("ShowMole", 1f);
    }

    public void HitMole()
    {
        hits++;
        UpdateUI();
        hitEffect.sprite = hitEffects[Random.Range(0, hitEffects.Length)];
        hitEffect.transform.position = mole.position;
        Invoke("HideHitEffect", 0.5f);
    }

    public void MissMole()
    {
        misses++;
        UpdateUI();
    }

    void HideHitEffect()
    {
        hitEffect.transform.position = new Vector3(0, -10, 0);
    }

    void UpdateUI()
    {
        hitUI.text = $"Hits: {hits}";
        missUI.text = $"Misses: {misses}";
    }
}
