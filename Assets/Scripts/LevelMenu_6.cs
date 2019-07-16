using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu_6 : MonoBehaviour {

    [SerializeField]
    GameObject[] emptyStar = new GameObject[3];

    [SerializeField]
    GameObject[] star = new GameObject[3];

    [SerializeField]
    GameObject cadenas;

    public static int nbStarGained;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (LevelMenu_5.nbStarGained > 0)
        {
            Destroy(cadenas);
        }

        if (nbStarGained == 1)
        {
            emptyStar[0].SetActive(false);
            star[0].SetActive(true);
        }
        else if (nbStarGained == 2)
        {
            emptyStar[0].SetActive(false);
            star[0].SetActive(true);
            emptyStar[1].SetActive(false);
            star[1].SetActive(true);
        }
        else if (nbStarGained == 3)
        {
            emptyStar[0].SetActive(false);
            star[0].SetActive(true);
            emptyStar[1].SetActive(false);
            star[1].SetActive(true);
            emptyStar[2].SetActive(false);
            star[2].SetActive(true);
        }
    }
}
