﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("得分介面")]
    public Text textScore;
    [Header("分數")]
    public static int score;
    [Header("射進的分數")]
    public int scoreIn = 50;

    public static ScoreManager instance;

    private void Start()
    {
        instance = this;
    }

    /// <summary>
    /// 加音效
    /// </summary>
    [Header("射板音效")]
    public AudioClip soundIn;
    private AudioSource aud;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    /// <summary>
    /// 額外加分區
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "飛鏢" && other.transform.position.y > 2.4f)                               //如果碰撞物件標籤為飛鏢，且高度>2.4
        //{
        //    AddScore();
        //    other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;           //把飛鏢黏在面板上
        //}
        if (other.transform.root.name =="Player")
        {
            scoreIn = 500;

        }
    }
    /// <summary>
    /// 走出加分區，分數回復
    /// </summary>
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name =="Player")
        {
            score = 50;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    /// <summary>
    /// 加分
    /// </summary>
    public void AddScore(int add = 1)
    {
        score += (scoreIn * add);
        textScore.text = "分數：" + score;
        aud.PlayOneShot(soundIn, Random.Range(0.5f, 1f));
    }
}
