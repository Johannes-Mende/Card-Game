using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    private AnimationController animationController;    //youtube.com/watch?v=BMAkGJ1vfY0 27:31
    private GameplayController gameplayController;

    private string playersChoice;

    void Awake()
    {
        animationController = GetComponent<AnimationController>();
        gameplayController = GetComponent<GameplayController>();
    }

    public void GetChoice()
    {
        string choiceName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        GameChoices selectedChoice = GameChoices.NONE;

        switch (choiceName)
        {
           case "Rock":
                selectedChoice = GameChoices.ROCK;
                break;

            case "Paper":
                selectedChoice = GameChoices.PAPER;
                break;

            case "Scissors":
                selectedChoice = GameChoices.SCISSORS;
                break;

            case "FIRE":
                selectedChoice = GameChoices.FIRE;
                break;
      
            case "WATER":
                selectedChoice = GameChoices.WATER;
                break;

            case "AIR":
                selectedChoice = GameChoices.AIR;
                break;
            
            case "SPONGE":
                selectedChoice = GameChoices.SPONGE;
                break;
        }
        gameplayController.SelectedChoice(selectedChoice);
        animationController.PlayerMadeChoice();
    }

}
