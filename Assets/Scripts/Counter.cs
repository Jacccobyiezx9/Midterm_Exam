using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI eggCountText;
    public TextMeshProUGUI chickCountText;
    public TextMeshProUGUI henCountText;
    public TextMeshProUGUI roosterCountText;

    void Start()
    {
        UpdateCounts();
    }

    void Update()
    {
        UpdateCounts();
    }

    void UpdateCounts()
    {
        UpdateEggCount();
        UpdateChickCount();
        UpdateHenCount();
        UpdateRoosterCount();
    }

    void UpdateEggCount()
    {
        GameObject[] eggs = GameObject.FindGameObjectsWithTag("Egg");
        eggCountText.text = "Eggs: " + eggs.Length.ToString();
    }

    void UpdateChickCount()
    {
        GameObject[] chicks = GameObject.FindGameObjectsWithTag("Chick");
        chickCountText.text = "Chicks: " + chicks.Length.ToString();
    }

    void UpdateHenCount()
    {
        GameObject[] hens = GameObject.FindGameObjectsWithTag("Hen");
        henCountText.text = "Hens: " + hens.Length.ToString();
    }

    void UpdateRoosterCount()
    {
        GameObject[] roosters = GameObject.FindGameObjectsWithTag("Rooster");
        roosterCountText.text = "Roosters: " + roosters.Length.ToString();
    }
}
