﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgilityTrainingMinigame : MonoBehaviour
{
    public GameObject[] col1;

    public GameObject[] col2;

    public GameObject[] col3;

    public GameObject[] col4;

    public GameObject[] col5;

    // Start is called before the first frame update
    void Start()
    {
        randomMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void randomMap()
    {
        int prevBranch = 0;
        for(int i = 1; i <= 5; i++)
        {
            prevBranch = selectBranch(i, prevBranch);
        }
    }

    void resetMap()
    {
        for(int i = 0; i < 5; i++)
        {
            col1[i].SetActive(false);
            col2[i].SetActive(false);
            col3[i].SetActive(false);
            col4[i].SetActive(false);
            col5[i].SetActive(false);
        }
    }

    int selectBranch(int colNum, int branch)
    {
        switch(colNum)
        {
            case 1:
            {
                int rand = (int) Random.Range(0, 4);
                col1[rand].SetActive(true);
                return rand;
            }
            case 2:
            {
                int maxBranch = Mathf.Min(branch+2, 4);
                int rand = (int) Random.Range(0, maxBranch);
                col2[rand].SetActive(true);
                return rand;
            }
            case 3:
            {
                int maxBranch = Mathf.Min(branch+2, 4);
                int rand = (int) Random.Range(0, maxBranch);
                col3[rand].SetActive(true);
                return rand;
            }
            case 4:
            {
                int maxBranch = Mathf.Min(branch+2, 4);
                int rand = (int) Random.Range(0, maxBranch);
                col4[rand].SetActive(true);
                return rand;
            }
            case 5:
            {
                int maxBranch = Mathf.Min(branch+2, 4);
                int rand = (int) Random.Range(0, maxBranch);
                col5[rand].SetActive(true);
                return rand;
            }
            default:
            {
                return 0;
            }
        }
    }
}
