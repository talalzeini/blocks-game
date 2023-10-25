using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public float slow = 10f;
    public GameObject GameOver;

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }
    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slow;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slow;
        yield return new WaitForSeconds(4f / slow);
        Time.fixedDeltaTime = Time.fixedDeltaTime * slow;
        TryAgain();
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
