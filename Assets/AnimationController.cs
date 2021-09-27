using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    [SerializeField]
    private Animator playerChoiceHanlderAnimation, choiceAnimation;

    public void ResetAnimations()
    {
        playerChoiceHanlderAnimation.Play("ShowHandler");
        choiceAnimation.Play("RemoveChoices");
    }
    public void PlayerMadeChoice()
    {
        playerChoiceHanlderAnimation.Play("RemoveHandler");
        choiceAnimation.Play("ShowChoices");
    }
}
