using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Candy : MonoBehaviour {

    [SerializeField]
    GameObject candy;

    [SerializeField]
    GameObject bubble;

    [SerializeField]
    GameObject rope;

    [SerializeField]
    GameObject cursor;

    [SerializeField]
    GameObject OmNom;

    [SerializeField]
    Sprite sprite1;

    [SerializeField]
    Sprite sprite2;

    [SerializeField]
    LayerMask mask;

    [SerializeField]
    GameObject PrefabCreatedRope;

    [SerializeField]
    GameObject PrefabLink;

    public static int nbStar;
    public bool bubbled;
    public static int whichLevel;
    public int starsAlreadyGot;

    // Use this for initialization
    void Start()
    {
        nbStar = 0;
        bubbled = false;

        switch (SceneManager.GetActiveScene().name)
        {
            case "Level_1":
                whichLevel = 1;
                break;
            case "Level_2":
                whichLevel = 2;
                break;
            case "Level_3":
                whichLevel = 3;
                break;
            case "Level_4":
                whichLevel = 4;
                break;
            case "Level_5":
                whichLevel = 5;
                break;
            case "Level_6":
                whichLevel = 6;
                break;
            case "Level_7":
                whichLevel = 7;
                break;
            case "Level_8":
                whichLevel = 8;
                break;
            case "Level_9":
                whichLevel = 9;
                break;
            case "Level_10":
                whichLevel = 10;
                break;

            default:
                whichLevel = 0;
                break;
        }
        Debug.Log("Level n°:" + whichLevel);
    }

    // Update is called once per frame
    void Update()
    {
        if (bubbled == true)
        {
            foreach (Rigidbody2D r in rope.GetComponentsInChildren<Rigidbody2D>())
            {
                r.mass = 0.0f;
            }

            candy.GetComponent<Rigidbody2D>().gravityScale = -2.0f;
            candy.GetComponent<Rigidbody2D>().drag = 10.0f;

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 1.0f, mask);
                if (hit.collider != null)
                {
                    if (hit.collider.tag == "Bubble")
                    {
                        Destroy(hit.collider.gameObject);
                        bubbled = false;
                    }
                }
            }
        }
        else
        {
            foreach (Rigidbody2D r in rope.GetComponentsInChildren<Rigidbody2D>())
            {
                r.mass = 0.0005f;
            }

            candy.GetComponent<Rigidbody2D>().gravityScale = 1.0f;
            candy.GetComponent<Rigidbody2D>().drag = 0.0f;
        }

        Vector2 distance = candy.transform.position - OmNom.transform.position;
        if (Mathf.Abs(distance.y) <= 2.0f)
        {
            OmNom.GetComponent<SpriteRenderer>().sprite = sprite2;
        }
        else
        {
            OmNom.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bubble")
        {
            bubble.transform.position = candy.transform.position;
            bubble.transform.parent = candy.transform;
            bubbled = true;
        }
        else if (collision.tag == "DeathZone")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            nbStar = 0;
        }
        else if (collision.tag == "AnchorZone")
        {
            Debug.Log("AAAAA");
            GameObject CreatedRope = Instantiate(PrefabCreatedRope, collision.transform.position, Quaternion.identity);
            Vector3 temp = CreatedRope.transform.position;
            temp.z = -5f;
            CreatedRope.transform.position = temp;
            Rigidbody2D previousLink = null;

            for (int i = 1; i < 7; i++)
            {
                GameObject link = Instantiate(PrefabLink, collision.transform.position, Quaternion.identity, CreatedRope.transform);

                link.transform.position = Vector2.Lerp(collision.transform.position, transform.position, (float)i / 7.0f - 0.5f / 7.0f);
                link.transform.localEulerAngles = new Vector3(0, 0, Vector2.SignedAngle(Vector2.down, link.transform.position - collision.transform.position));
                HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
                joint.connectedBody = previousLink;

                if (i < 7 - 1)
                {
                    previousLink = link.GetComponent<Rigidbody2D>();
                }
                else
                {
                    gameObject.AddComponent<HingeJoint2D>();
                    //GetComponent<HingeJoint2D>().connectedBody = link.GetComponent<Rigidbody2D>();

                    HingeJoint2D[] joints = GetComponents<HingeJoint2D>();
                    foreach (HingeJoint2D join in joints)
                    {
                        if (!join.connectedBody)
                            join.connectedBody = link.GetComponent<Rigidbody2D>();
                    }
                }
            }
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Star")
        {
            Destroy(collision.gameObject);
            nbStar++;
        }
        else if (collision.tag == "OmNom")
        {
            Destroy(gameObject);
            OmNom.GetComponent<SpriteRenderer>().sprite = sprite1;

            switch(whichLevel)
            {
                case 1:
                    if (nbStar > LevelMenu_1.nbStarGained)
                    {
                        LevelMenu_1.nbStarGained = nbStar;
                    }
                    break;
                case 2:
                    if (nbStar > LevelMenu_2.nbStarGained)
                    {
                        LevelMenu_2.nbStarGained = nbStar;
                    }
                    break;
                case 3:
                    if (nbStar > LevelMenu_3.nbStarGained)
                    {
                        LevelMenu_3.nbStarGained = nbStar;
                    }
                    break;
                case 4:
                    if (nbStar > LevelMenu_4.nbStarGained)
                    {
                        LevelMenu_4.nbStarGained = nbStar;
                    }
                    break;
                case 5:
                    if (nbStar > LevelMenu_5.nbStarGained)
                    {
                        LevelMenu_5.nbStarGained = nbStar;
                    }
                    break;
                case 6:
                    if (nbStar > LevelMenu_6.nbStarGained)
                    {
                        LevelMenu_6.nbStarGained = nbStar;
                    }
                    break;
                case 7:
                    if (nbStar > LevelMenu_7.nbStarGained)
                    {
                        LevelMenu_7.nbStarGained = nbStar;
                    }
                    break;
                case 8:
                    if (nbStar > LevelMenu_8.nbStarGained)
                    {
                        LevelMenu_8.nbStarGained = nbStar;
                    }
                    break;
                case 9:
                    if (nbStar > LevelMenu_9.nbStarGained)
                    {
                        LevelMenu_9.nbStarGained = nbStar;
                    }
                    break;
                case 10:
                    if (nbStar > LevelMenu_10.nbStarGained)
                    {
                        LevelMenu_10.nbStarGained = nbStar;
                    }
                    break;
            }

            SceneManager.LoadScene("chooseLevel");
        }
    }
}
