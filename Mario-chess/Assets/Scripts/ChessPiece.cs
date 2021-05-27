using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{

    private GameObject chessPieceGO;

    // Start is called before the first frame update
    void Start()
    {
        chessPieceGO = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameMasterScript.instance.setActivePiece(gameObject, this);
    }

    public void showSelected()
    {
        Behaviour halo = (Behaviour)GetComponent("Halo");
        halo.enabled = true;
    }

    public void hideSelected()
    {
        Behaviour halo = (Behaviour)GetComponent("Halo");
        halo.enabled = false;
    }

}
