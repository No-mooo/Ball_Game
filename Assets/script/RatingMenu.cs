using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatingMenu : MonoBehaviour
{
    public Transform scoreItem;
    public static List<string[]> listScore = new List<string[]>();
    void Start()
    {
        listScore.Sort((a, b) => Int32.Parse(b[1]) - Int32.Parse(a[1]));

        foreach (string[] item in listScore)
        {
            printListScore(item[0], item[1]);
        }
    }

    public void printListScore(string name, string score)
    {
        scoreItem.transform.GetChild(0).GetComponent<Text>().text = name;
        scoreItem.transform.GetChild(1).GetComponent<Text>().text = score;
        Instantiate(scoreItem, this.transform);
    }

    public static void addScore(string name, string score)
    {
        if (listScore.Count < 10)
        {
            listScore.Add(new string[] { name, score });

        }
        else
        {
            renameScore(name, score);
        }
    }

    public static Boolean checkListScore(int score)
    {
        Boolean resul = false;
        
        if (listScore.Count < 10)
        {
            resul = true;
        }

        if (!resul && Int32.Parse(listScore[9][1]) > score)
        {
            resul = true;
        }

        return resul;
    }

    public static void renameScore(string name, string score)
    {
        for (int i = 0; i < listScore.Count; i++)
        {
            if (Int32.Parse(listScore[i][1]) < Int32.Parse(score))
            {
                listScore[i][0] = name;
                listScore[i][1] = score;
                break;
            }
        }
    }
}
