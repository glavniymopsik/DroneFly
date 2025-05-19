using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("���� �������"); // �������� ������ � �����
    }

    public void LoadShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
