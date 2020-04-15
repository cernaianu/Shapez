﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePowerup : Powerup
{
    [SerializeField] private int increaseAmount = 10;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(TriggerEffect(collision.GetComponent<Player>()));
            DisableUntilDestruction();
        }
    }

    private IEnumerator TriggerEffect(Player p)
    {
        p.damage += increaseAmount;
        yield return new WaitForSeconds(duration);
        p.damage -= increaseAmount;
        Destroy(gameObject);
    }

    
}
