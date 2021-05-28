using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterScript : MonoBehaviour
{

    public static GameMasterScript instance;

    private GameObject activePiece;
    private ChessPiece activeReference;

    private GameObject boardSelection;

    // Start is called before the first frame update
    void Start()
    {
        instance = GetComponent<GameMasterScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setActivePiece(GameObject chessPiece, ChessPiece pieceReference)
    {
        if(activePiece == null)
        {
            activePiece = chessPiece;
            activeReference = pieceReference;
            pieceReference.showSelected();
            Debug.Log("Gameobject set as selected from manager.");
        }
        else
        {
            activePiece = null;
            activeReference.hideSelected();
            activeReference = null;
            Debug.Log("Gameobject set to null from manager");
        }
    }

    public void moveDestination(GameObject tileDestination)
    {
        if(activePiece != null)
        {
            activePiece.transform.position = new Vector3(tileDestination.transform.position.x, 1.23f, tileDestination.transform.position.z);
            activePiece = null;
            activeReference.hideSelected();
            activeReference = null;
            Debug.Log("Piece moved from manager complete");
        }
    }
}