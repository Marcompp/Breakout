using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaSpawner : MonoBehaviour
{
    public GameObject Bola;

    GameManager gm;
    private int lpontos = 1;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        GameManager.changeStateDelegate += Construir;
        Construir();
    }

    void Construir()
    {


        if (gm.gameState == GameManager.GameState.GAME)
        {
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            Vector3 posicao = playerPosition + new Vector3(0, 0.5f, 0);
            Instantiate(Bola, posicao, Quaternion.identity, transform);
        }
    }

            // Update is called once per frame
    void Update()
    {
        if ((gm.pontos == 12 || gm.pontos == 24 || gm.pontos == 36) && gm.pontos != lpontos)
        {
            Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
            Vector3 posicao = playerPosition + new Vector3(0, 0.5f, 0);
            Instantiate(Bola, posicao, Quaternion.identity, transform);
        }
        lpontos = gm.pontos;
    }


}
