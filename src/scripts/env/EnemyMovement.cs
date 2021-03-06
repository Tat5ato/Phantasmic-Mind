using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
// Made by Sebastian Carbonero and Adrien Cao
	//Referenced Game Objects
	public Transform Player;
	public Transform NavPointA;
	public Transform NavPointB;

	//Parameters
	bool _moveToA = true;
	float _moveSpeed = 0.1f;
	float _activateFollowRadius = 5.0f;
	bool _followActive = false;
	private float EnemyRadius = 20.0f;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		//Checks if player is in radius
		if (IsPlayerWithinFollowRadius())
		{
			_followActive = true;
		}
		//Checks if the enemy is far enough away from its origin point 
		if (CheckDistanceToOrigin ()) 
		{
			_followActive = false;
		}
		//Causes enemy to move towards the player
		if (_followActive)
		{
			MoveTowardsPlayer();
		}

		else
		{
			//Moves player back and fowarth

			if (_moveToA == true)
			{
				var move = CalculateMove(NavPointA);
				this.transform.Translate(move);
			}
			else
			{
				var move = CalculateMove(NavPointB);
				this.transform.Translate(move);
			}
		}
	}
	//Makes the enemy moves back and forth
	Vector2 CalculateMove(Transform targetNavPoint)
	{
		Vector2 direction = (targetNavPoint.position - this.transform.position);
		float magnitude = direction.magnitude;
		Vector2 normal = direction.normalized;
		float offSetScale = 0.1f;
		Vector2 vectorDeOffset = normal * offSetScale;
		if (magnitude <= 0.1f)
		{
			_moveToA = !_moveToA;
		}
		return vectorDeOffset;
	}
	//Creates the radius of the enemy that the player will move into (activates follow)
	bool IsPlayerWithinFollowRadius()
	{
		var distanceToPlayer = (Player.transform.position - this.transform.position).magnitude;
		if (distanceToPlayer <= _activateFollowRadius)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
  
	void MoveTowardsPlayer()
	{
		//Causes the enemy to move towards player
		var moveVector = ((Player.transform.position - this.transform.position).normalized) * _moveSpeed;
		this.transform.position = this.transform.position + moveVector;
	}
	bool CheckDistanceToOrigin()
	{
		//Makes the enemy stop at a certain distance from its origin point
		var DistanceToOrigin = Player.transform.position.magnitude;
		if (EnemyRadius <= DistanceToOrigin) 
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

/*The enemy is a 3d game object with a cube mesh filter, Box collider, Mesh renderer(Default settings that come with the
3d objects), also has a movement script with three public transforms, which are the player, NavPointA and NavPointB. NavPointA
and B both are empty objects with the Sine Movement code(optional, it makes the nav points move up and down causing a patrol
movement for enemy) Contact me if you want the sine movement in the game. The Nav Points are supposed make the enemy to move
back and forth between the two nav points. The Player is attached to a public transform in the code, so you can just attach 
the payer asset into the public transform "player".*/



