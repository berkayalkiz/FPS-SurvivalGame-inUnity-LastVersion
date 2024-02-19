using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeMenuScript : MonoBehaviour
{
    public GameObject upgradeMenu;
    public GameObject pauseMenu;

    public GameObject notice;

    public GameObject player;

    public TextMeshProUGUI healthTextbox, staminaTextbox, speedTextbox, sprintTextbox, damageTextbox;

    public TextMeshProUGUI coinCounter;

    public int healthLv, staminaLv, speedLv, sprintLv, damageLv;



    void Awake()
    {
        healthLv =1; staminaLv =1; speedLv =1; sprintLv =1; damageLv =1;
        healthTextbox.text = healthLv.ToString();
        staminaTextbox.text = staminaLv.ToString(); 
        speedTextbox.text = speedLv.ToString();
        sprintTextbox.text = sprintLv.ToString();
        damageTextbox.text = damageLv.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseMenuScript.upgradeMenuIsActive)
            {
                BackToPauseMenu();
            }
        }
    }

    public void BackToPauseMenu()
    {
        upgradeMenu.SetActive(false);
        pauseMenu.SetActive(true);
        PauseMenuScript.upgradeMenuIsActive = false;
        PauseMenuScript.pauseMenuIsActive = true;
    }

    public void UpgradeHealthLevel()
    {
        if(PlayerCoinHandler.coin >= 15)
        {
            notice.SetActive(false);
            healthLv ++;
            healthTextbox.text = healthLv.ToString();
            player.GetComponent<HealthScript>().health += 5;
            PlayerCoinHandler.coin -= 15;
            coinCounter.text = PlayerCoinHandler.coin.ToString();
        }
        else
        {
            notice.SetActive(true);
        }

    }

    public void UpgradeStaminaLevel()
    {
        if (PlayerCoinHandler.coin >= 15)
        {
            notice.SetActive(false);
            staminaLv ++;
            staminaTextbox.text = staminaLv.ToString();
            player.GetComponent<PlayerSprintAndCrouch>().sprint_Treshold_Coef++;
            PlayerCoinHandler.coin -= 15;
            coinCounter.text = PlayerCoinHandler.coin.ToString();
        }
        else
        {
            notice.SetActive(true);
        }
        
    }

    public void UpgradeSpeedLv()
    {
        if (PlayerCoinHandler.coin >= 15)
        {
            notice.SetActive(false);
            speedLv++;
            speedTextbox.text = speedLv.ToString();
            player.GetComponent<PlayerSprintAndCrouch>().move_Speed ++;
            PlayerCoinHandler.coin -= 15;
            coinCounter.text = PlayerCoinHandler.coin.ToString();
        }
        else
        {
            notice.SetActive(true);
        }
    }

    public void UpgradeSprintLv()
    {
        if (PlayerCoinHandler.coin >= 15)
        {
            notice.SetActive(false);
            sprintLv++;
            sprintTextbox.text = sprintLv.ToString();
            player.GetComponent<PlayerSprintAndCrouch>().sprint_Speed++;
            PlayerCoinHandler.coin -= 15;
            coinCounter.text = PlayerCoinHandler.coin.ToString();
        }
        else
        {
            notice.SetActive(true);
        }
    }

    public void UpgradeDamageLv()
    {
        if (PlayerCoinHandler.coin >= 15)
        {
            notice.SetActive(false);
            damageLv++;
            damageTextbox.text = damageLv.ToString();
            player.GetComponent<PlayerAttack>().damage +=5;
            PlayerCoinHandler.coin -= 15;
            coinCounter.text = PlayerCoinHandler.coin.ToString();
        }
        else
        {
            notice.SetActive(true);
        }
    }
}
