using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Levels[] Levels;
    public int Currentlevelindex = 0;
    public const string CurrentlevelSTR = "Currentlevel";
    public Ball ball;
    private void SetLevel()
    {
        Currentlevelindex = PlayerPrefs.GetInt(CurrentlevelSTR);
        Instantiate(Levels[Currentlevelindex], new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
    private void Awake()
    {
        SetLevel();
    }
    public void GetLevel()
    {
        if (ball.nextLevel == true)
        {
            Currentlevelindex += 1;
            PlayerPrefs.SetInt(CurrentlevelSTR, Currentlevelindex);
            SceneManager.LoadScene("SampleScence");
        }
    }

}
