using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public bool PlayerWinbool;

    [SerializeField]
    private Animator playerChoiceHanlderAnimation, choiceAnimation, PlayerWinAnimation, PlayerLoseAnimation;

    public void ResetAnimations()
    {
        playerChoiceHanlderAnimation.Play("ShowHandler");
        choiceAnimation.Play("RemoveChoices");
    }
    public void PlayerMadeChoice()
    {
        playerChoiceHanlderAnimation.Play("RemoveHandler");
        choiceAnimation.Play("ShowChoices");
        /*
        if(!PlayerWinbool)
        {
            PlayerLose.Play("PlayerLose");
        }
        else if(PlayerWinbool)
        {
            PlayerWin.Play("PlayerWin");
        }*/
    }

    public void PlayerWin()
    {
        PlayerWinAnimation.Play("AngriffWin");
    }
    public void PlayerLose()
    {
        PlayerLoseAnimation.Play("AngriffLose");
    }
}

