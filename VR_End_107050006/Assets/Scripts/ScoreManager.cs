using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("得分介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    [Header("射進的分數")]
    public int scoreIn = 50;

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
        if (other.tag == "飛鏢")
        {
            AddScore();
        }
        if (other.transform.root.name =="Player")
        {
            scoreIn = 500;

        }
    }
    /// <summary>
    /// 走出加分區
    /// </summary>
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name =="Player")
        {
            score = 50;
        }
    }
    /// <summary>
    /// 加分
    /// </summary>
    private void AddScore()
    {
        score += scoreIn;
        textScore.text = "分數：" + score;
        aud.PlayOneShot(soundIn, Random.Range(0.5f, 1f));
    }
}
