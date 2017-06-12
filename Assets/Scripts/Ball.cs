using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 Position;
    private bool turn;

	// Use this for initialization
	void Start ()
	{
	    Position = transform.position;
	    turn = true;
		Events.CupH.AddListener(DestroyBall);
	}

    void DestroyBall()
    {
        if (turn)
        {
            transform.position = Position;
            turn = !turn;
        }
        else
        {
            transform.position = new Vector3(Position.x + 4, Position.y, Position.z - 1.4f);
            turn = !turn;
        }
    }
	
	
}
