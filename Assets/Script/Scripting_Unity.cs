using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripting_Unity : MonoBehaviour
{
    public int healthPlayer;
    public int armorPlayer;
    public int[] score = { 100, 90, 85, 70, 60 };

    void Start()
    {
        Debug.Log("Hp Player \t: " + healthPlayer);
        Debug.Log("Armor Player \t: " + armorPlayer);
        Debug.Log("Score \t: " + score[0]);
    }

    void Update()
    {
        //Status Player
        if (Input.GetKeyDown(KeyCode.R))
        {
            StatusPlayer();
        }

        //Commant
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Average();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            restartHpPlayer();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            ForHpPlayer();
        }

        if (healthPlayer > 0 && Input.GetKeyDown(KeyCode.D))
        {
            HpDamage();
        }

        if (armorPlayer > 0 && Input.GetKeyDown(KeyCode.A))
        {
            ArmorDamage();
        }

        // Cek Kualitas Player
        if (Input.GetKeyDown(KeyCode.S))
        {
            CheckPlayerQuality();
        }
    }

    public void ForHpPlayer()
    {
        while (healthPlayer > 0)
        {
            healthPlayer -= 10;
            Debug.Log("Hp Player : " + healthPlayer);

        }
        Debug.Log("Player Dead!!!");
    }

    public void HpDamage()
    {
        healthPlayer -= 20;
        Debug.Log("Slime Attack");
        Debug.Log("Hp Player : " + healthPlayer);
    }

    public void ArmorDamage()
    {
        armorPlayer -= 10;
        Debug.Log("Spider Attack");
        Debug.Log("Armor Player : " + armorPlayer);
    }

    public void restartHpPlayer()
    {
        healthPlayer = 100;
        armorPlayer = 50;
        Debug.Log("Player HP reset! Current HP: " + healthPlayer);
        Debug.Log("Player Armor reset! Current Armor: " + armorPlayer);
    }

    public void Average()
    {
        int totalScore = 0;

        for (int i = 0; i < score.Length; i++)
        {
            totalScore += score[i];
        }
        int averageTotal = totalScore / score.Length;
        Debug.Log("Average Score : " + averageTotal);
    }

    public void StatusPlayer()
    {
        Debug.Log("Player HP \t: " + healthPlayer);
        Debug.Log("Player Armor \t: " + armorPlayer);

        if (healthPlayer > 50)
        {
            Debug.Log("Pemain Sehat");
        }
        else if (healthPlayer > 20)
        {
            Debug.Log("Pemain Perlu Berhati-hati");
        }
        else
        {
            Debug.Log("Pemain dalam Bahaya");
        }


        if (healthPlayer > 50 && armorPlayer > 30)
        {
            Debug.Log("Pemain Siap Bertarung");
        }
        else
        {
            Debug.Log("Pemain Perlu Bersiap");
        }
    }

    public void CheckPlayerQuality()
    {
        bool highQuality = false;

        for (int i = 0;i < score.Length;i++)
        {
            if (score[i] > 80)
            {
                highQuality = true;
                break;
            }
        }

        if (highQuality)
        {
            Debug.Log("Pemain berkualitas tinggi");
        }
        else
        {
            Debug.Log("Pemain butuh latihan");
        }
    }
}
