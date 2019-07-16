using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenu_1 : MonoBehaviour {

    [SerializeField]
    GameObject[] emptyStar = new GameObject[3];

    [SerializeField]
    GameObject[] star = new GameObject[3];

    public static int nbStarGained;

    // Use this for initialization
    void Start() {

    }
	
	// Update is called once per frame
	void Update () {

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

        /*switch (counterLevel)
        {
            case 0:
                break;
            case 1:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 2:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 3:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 4:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 5:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 6:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 7:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 8:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 9:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
            case 10:
                if (nbStars == 1)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                }
                else if (nbStars == 2)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                }
                else if (nbStars == 3)
                {
                    emptyStar[0].SetActive(false);
                    star[0].SetActive(true);
                    emptyStar[1].SetActive(false);
                    star[1].SetActive(true);
                    emptyStar[2].SetActive(false);
                    star[2].SetActive(true);
                }
                break;
        }*/
    }
}
