using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameChoices
{
    NONE,
    ROCK,
    PAPER,
    SCISSORS,
    FIRE,
    WATER,
    AIR,
    SPONGE
}

public class GameplayController : MonoBehaviour
{
    [SerializeField]
    private Sprite rock_Sprite, paper_Sprite, scissors_Sprite, fire_Sprite, water_Sprite, air_Sprite, sponge_Sprite;
    [SerializeField]
    private Image player_Choice_Img, opponent_Choice_Img;

    [SerializeField]
    private Text infoText;

    private GameChoices player_Choice = GameChoices.NONE, opponent_Choice = GameChoices.NONE;

    private AnimationController animationController;
    
    void Awake()
    {
        animationController = GetComponent<AnimationController>();

    }
    public void SetChoices(GameChoices gameChoices)
    {
        switch (gameChoices)
        {
            case GameChoices.ROCK:
                player_Choice_Img.sprite = rock_Sprite;
                player_Choice = GameChoices.ROCK;
                break;

            case GameChoices.PAPER:
                player_Choice_Img.sprite = paper_Sprite;
                player_Choice = GameChoices.PAPER;
                break;

            case GameChoices.SCISSORS:
                player_Choice_Img.sprite = scissors_Sprite;
                player_Choice = GameChoices.SCISSORS;
                break;

            case GameChoices.FIRE:
                player_Choice_Img.sprite = fire_Sprite;
                player_Choice = GameChoices.FIRE;
                break;
                
            case GameChoices.WATER:
                player_Choice_Img.sprite = water_Sprite;
                player_Choice = GameChoices.WATER;
                break;
                
            case GameChoices.AIR:
                player_Choice_Img.sprite = air_Sprite;
                player_Choice = GameChoices.AIR;
                break;

            case GameChoices.SPONGE:
                player_Choice_Img.sprite = sponge_Sprite;
                player_Choice = GameChoices.SPONGE;
                break;
        }

        SetOpponentChoice();
        DetermineWinner();

    }

    void SetOpponentChoice()
    {
        int rnd = Random.Range(0, 7);

        switch (rnd)
        {
            case 0:
                opponent_Choice = GameChoices.ROCK;
                opponent_Choice_Img.sprite = rock_Sprite;
                
                break;
            case 1:
                opponent_Choice = GameChoices.PAPER;
                opponent_Choice_Img.sprite = paper_Sprite;
                break;
            case 3:
                opponent_Choice = GameChoices.SCISSORS;
                opponent_Choice_Img.sprite = scissors_Sprite;
                break;
            case 4:
                opponent_Choice = GameChoices.FIRE;
                opponent_Choice_Img.sprite = fire_Sprite;
                break;
            case 5:
                opponent_Choice = GameChoices.WATER;
                opponent_Choice_Img.sprite = water_Sprite;
                break;
            case 6:
                opponent_Choice = GameChoices.AIR;
                opponent_Choice_Img.sprite = air_Sprite;
                break;
            case 7:
                opponent_Choice = GameChoices.SPONGE;
                opponent_Choice_Img.sprite = sponge_Sprite;
                break;
        }
    }
    void DetermineWinner()
    {
        if(player_Choice == opponent_Choice)
        {
            //draw
            infoText.text = "Its a Draw";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #region Win

        #region RockWin
             
        if(player_Choice == GameChoices.ROCK && opponent_Choice == GameChoices.PAPER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.ROCK && opponent_Choice == GameChoices.SPONGE)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.ROCK && opponent_Choice == GameChoices.FIRE)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        #endregion

        #region FireWin

        if(player_Choice == GameChoices.FIRE && opponent_Choice == GameChoices.SCISSORS)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.FIRE && opponent_Choice == GameChoices.SPONGE)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.FIRE && opponent_Choice == GameChoices.PAPER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region ScissorsWin
        if(player_Choice == GameChoices.SCISSORS && opponent_Choice == GameChoices.SPONGE)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.SCISSORS && opponent_Choice == GameChoices.PAPER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.SCISSORS && opponent_Choice == GameChoices.AIR)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region SpongeWin
        if(player_Choice == GameChoices.SPONGE && opponent_Choice == GameChoices.PAPER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.SPONGE && opponent_Choice == GameChoices.AIR)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.SPONGE && opponent_Choice == GameChoices.WATER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion
        
        #region PaperWin
        if(player_Choice == GameChoices.PAPER && opponent_Choice == GameChoices.AIR)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.PAPER && opponent_Choice == GameChoices.WATER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.PAPER && opponent_Choice == GameChoices.ROCK)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region AirWin
        if(player_Choice == GameChoices.AIR && opponent_Choice == GameChoices.WATER)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.AIR && opponent_Choice == GameChoices.ROCK)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.AIR && opponent_Choice == GameChoices.FIRE)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        #endregion

        #region WaterWin
        if(player_Choice == GameChoices.WATER && opponent_Choice == GameChoices.ROCK)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.WATER && opponent_Choice == GameChoices.FIRE)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.WATER && opponent_Choice == GameChoices.SCISSORS)
        {
            infoText.text = "You Win!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #endregion
        
        #region Lose
             
        #region RockLose
        if(player_Choice == GameChoices.ROCK && opponent_Choice == GameChoices.WATER)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.ROCK && opponent_Choice == GameChoices.AIR)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if(player_Choice == GameChoices.ROCK && opponent_Choice == GameChoices.PAPER)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region FireLose
        if(player_Choice == GameChoices.FIRE && opponent_Choice == GameChoices.ROCK)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.FIRE && opponent_Choice == GameChoices.WATER)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.FIRE && opponent_Choice == GameChoices.AIR)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region Scissors
        if(player_Choice == GameChoices.SCISSORS && opponent_Choice == GameChoices.FIRE)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.SCISSORS && opponent_Choice == GameChoices.ROCK)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.SCISSORS && opponent_Choice == GameChoices.WATER)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region SpongeLose
        if(player_Choice == GameChoices.SPONGE && opponent_Choice == GameChoices.SCISSORS)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.SPONGE && opponent_Choice == GameChoices.FIRE)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.SPONGE && opponent_Choice == GameChoices.ROCK)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region PaperLose
        if(player_Choice == GameChoices.PAPER && opponent_Choice == GameChoices.SPONGE)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.PAPER && opponent_Choice == GameChoices.SCISSORS)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.PAPER && opponent_Choice == GameChoices.FIRE)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region AirLose
        if(player_Choice == GameChoices.AIR && opponent_Choice == GameChoices.PAPER)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.AIR && opponent_Choice == GameChoices.SPONGE)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.AIR && opponent_Choice == GameChoices.SCISSORS)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #region WaterLose
        if(player_Choice == GameChoices.WATER && opponent_Choice == GameChoices.AIR)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.WATER && opponent_Choice == GameChoices.PAPER)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        if(player_Choice == GameChoices.WATER && opponent_Choice == GameChoices.SPONGE)
        {
            infoText.text = "You Lose!";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }
        #endregion

        #endregion
    }
    IEnumerator DisplayWinnerAndRestart()
    {
        yield return new WaitForSeconds(2f);
        infoText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);
        infoText.gameObject.SetActive(false);

        animationController.ResetAnimations();
    }
}
