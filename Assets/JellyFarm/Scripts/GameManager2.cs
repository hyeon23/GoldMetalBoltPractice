using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public Vector3[] pointList;

    public RuntimeAnimatorController[] levelAc;//Level¿¡ µû¸¥ Animation Controller

    public int[] jellyGoldList;
    public int[] jellyjelatinList;
    public int[] numGoldList;
    public int[] ClickGoldList;
    public string[] jellyNameList;
    public Sprite[] jellySpriteList;


    public void ChangeAc(Animator anime, int level)
    {
        anime.runtimeAnimatorController = levelAc[level-1];
    }
}
