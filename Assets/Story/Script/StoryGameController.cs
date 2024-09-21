using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryGameController : MonoBehaviour
{
    public bool hiroppeClear = false;
    public bool sibaClear = false;
    public bool keichanClear = false;
    public bool tukkunClear = false;
    public bool wattaClear = false;

    public GameObject nextStageWall1;
    public GameObject nextStageWall2;
    public GameObject nextStageWall3;
    public GameObject nextStageWall4;
    public GameObject nextStageWall5;
    // Start is called before the first frame update
    void Start()
    {
        nextStageWall1.SetActive(true);
        nextStageWall2.SetActive(true);
        nextStageWall3.SetActive(true);
        nextStageWall4.SetActive(true);
        nextStageWall5.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (hiroppeClear)
        {
            nextStageWall1.SetActive(false);
        }
        if (sibaClear)
        {
            nextStageWall2.SetActive(false);
        }
        if(keichanClear)
        {
            nextStageWall3.SetActive(false);
        }
        if (wattaClear)
        {
            nextStageWall4.SetActive(false);
        }
        if (tukkunClear)
        {
            nextStageWall5.SetActive(false);
        }
    }
}
