using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LossWindow lossWindow;
    public static GameManager instance;

    public void Start()
    {
        instance = this;
    }
    public void Lose()
    {
        lossWindow.gameObject.SetActive(true);
        lossWindow.PlayerLoss();
        Time.timeScale = 0;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
