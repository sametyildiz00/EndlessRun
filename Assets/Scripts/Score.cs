using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public TMP_Text scoreText;
    public float score;
    // Update is called once per frame
    void Update()
    {
        score = GameManager.inst.coinScore;
        scoreText.text = score.ToString("0");
    }

}
