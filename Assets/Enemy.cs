using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer sr;
    // Cooldown duration for red color effect
    [SerializeField] private float redColorDuration = 1;

    public float currentTimeInGame;
    public float timeWhenLastHit;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        ChangeColorIfHit();
    }

    private void ChangeColorIfHit()
    {
        currentTimeInGame = Time.time;

        if (currentTimeInGame > timeWhenLastHit + redColorDuration)
        {
            if (sr.color != Color.white)
                sr.color = Color.white;
        }

    }

    public void TakeDamage()
    { 
        sr.color = Color.red;
        timeWhenLastHit = Time.time;
    }

}
