using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {

    // Menu's buttons
    public void Play()  // Ingame's button too
    {
        SceneManager.LoadScene("chooseLevel");
    }

    public void Options()
    {
        SceneManager.LoadScene("options");
    }

    public void Quit()
    {
        Application.Quit();
    }

    // ChooseLevel's buttons
    public void BackToMenu()    // Options' button too
    {
        SceneManager.LoadScene("menu");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Level2()
    {
        if (LevelMenu_1.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_2");
        }
    }

    public void Level3()
    {
        if (LevelMenu_2.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_3");
        }
    }

    public void Level4()
    {
        if (LevelMenu_3.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_4");
        }
    }

    public void Level5()
    {
        if (LevelMenu_4.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_5");
        }
    }

    public void Level6()
    {
        if (LevelMenu_5.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_6");
        }
    }

    public void Level7()
    {
        if (LevelMenu_6.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_7");
        }
    }

    public void Level8()
    {
        if (LevelMenu_7.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_8");
        }
    }

    public void Level9()
    {
        if (LevelMenu_8.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_9");
        }
    }

    public void Level10()
    {
        if (LevelMenu_9.nbStarGained != 0)
        {
            SceneManager.LoadScene("Level_10");
        }
    }

    // Ingame's buttons
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Candy.nbStar = 0;
    }
}
