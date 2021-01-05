using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重新開始
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene("VR_End_107050006");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame() 
    {
        Application.Quit();
    }
}

