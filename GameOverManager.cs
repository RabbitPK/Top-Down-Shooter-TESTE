using UnityEngine;
using UnityEngine.UI;  // Para manipular UI
using UnityEngine.SceneManagement;  // Para carregar cenas

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;  // A tela de Game Over
    public string mainMenuScene = "MainMenu";  // Cena do menu principal, se tiver

    void Start()
    {
        gameOverPanel.SetActive(false);  // Inicialmente, a tela de Game Over está oculta
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);  // Exibe a tela de Game Over
        Time.timeScale = 0f;  // Pausa o jogo
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;  // Reinicia o tempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reinicia a cena atual
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;  // Reinicia o tempo
        SceneManager.LoadScene(mainMenuScene);  // Carrega o menu principal
    }
}
