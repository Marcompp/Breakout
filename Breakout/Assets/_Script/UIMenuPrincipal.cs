using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuPrincipal : MonoBehaviour
{

    GameManager gm;

    private void OnEnable()
    {
        gm = GameManager.GetInstance();
    }

    public void Comecar()
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }
}
