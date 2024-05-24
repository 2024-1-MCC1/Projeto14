using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject voltar;
    public GameObject manual;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (voltar.activeSelf)
            {
                voltar.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                voltar.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void ResumeGame()
    {
        voltar.SetActive(false);
        Time.timeScale = 1;
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(1);
    }
    public void MostrarManual()
    {
        manual.SetActive(true);
    }

    public void EsconderManual()
    {
        manual.SetActive(false);
    }
}