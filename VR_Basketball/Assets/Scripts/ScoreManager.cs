
using UnityEngine;
using UnityEngine.UI;  //引用 介面API

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }
}
