using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIGameOver : MonoBehaviour
{
    public Text message;

    GameManager gm;
    private void OnEnable()
    {
        gm = GameManager.GetInstance();

        if (gm.vidas > 0)
        {
            message.text = "Voc? Ganhou!!!";
        }
        else
        {
            message.text = "Voc? Perdeu!!";
        }
    }


    public void Voltar()
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }
}

