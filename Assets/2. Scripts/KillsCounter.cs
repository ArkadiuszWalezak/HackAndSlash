using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class KillsCounter : MonoBehaviour
{
    [SerializeField] public Text counter;
    private int playerKillCount = 0;

        
    void Update()
    {
        ShowKills();
    }

    public void ShowKills()
    {
        counter.text = playerKillCount.ToString();
    }

    public void AddKill()
    {
        playerKillCount++;
    }
}
