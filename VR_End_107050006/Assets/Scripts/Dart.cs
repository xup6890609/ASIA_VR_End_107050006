using UnityEngine;

public class Dart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "三倍區")
        {
            ScoreManager.instance.AddScore(3);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;           //把飛鏢黏在面板上
        }

        if (other.name == "兩倍區")
        {
            ScoreManager.instance.AddScore(2);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;           //把飛鏢黏在面板上
        }
    }
}
