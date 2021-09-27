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
    private Image playerChoice_Img, opponentChoice_Img;

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

    }
}
