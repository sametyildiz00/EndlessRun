using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Transform playerTransform;
    public TMP_Text scoreText;
    private float score;

    private void Update()
    {
        score = GameManager.inst.coinScore;
        scoreText.text = score.ToString("Score: " + score);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
