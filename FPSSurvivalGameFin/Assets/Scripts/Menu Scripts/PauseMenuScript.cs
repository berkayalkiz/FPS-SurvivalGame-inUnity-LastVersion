using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;

    public GameObject upgradeMenu;

    public bool isPaused;

    public static bool pauseMenuIsActive;

    public static bool upgradeMenuIsActive;

    private PlayerStats player_Stats;

    public GameObject player;
    void Start()
    {
        pauseMenu.SetActive(false);
        upgradeMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused && !upgradeMenuIsActive && pauseMenuIsActive)
            {
                ResumeGame();
                
            }

            if(!isPaused && !upgradeMenuIsActive && !pauseMenuIsActive)
            {
                PauseGame();
                
            }
        }
    }

    public void PauseGame()
    {
        PauseMenuActive();
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ResumeGame()
    {
        PauseMenuDeactive();
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        player.GetComponent<PlayerStats>().Display_HealthStats(player.GetComponent<HealthScript>().health, player.GetComponent<HealthScript>().totalHealth);

    }

    public void PauseMenuActive()
    {
        pauseMenu.SetActive(true);
        pauseMenuIsActive = true;
    } 

    public void PauseMenuDeactive()
    {
        pauseMenu.SetActive(false);
        pauseMenuIsActive = false;
    }
    public void UpgradeMenuActive()
    {
        PauseMenuDeactive();
        upgradeMenu.SetActive(true);
        pauseMenuIsActive = false;
        upgradeMenuIsActive = true;

    }

    public void AddCoin()
    {
        PlayerCoinHandler.coin += 1000;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
