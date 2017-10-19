using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	//Referenced Game Objects
	public Transform Player;
	public Transform NavPointA;
	public Transform NavPointB;

	//Parameters
	bool _moveToA = true;
	float _moveSpeed = 0.05f;
	float _activateFollowRadius = 5.0f;
	bool _followActive = false;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (IsPlayerWithinFollowRadius())
		{
			_followActive = true;
		}
		if (_followActive)
		{
			MoveTowardsPlayer();
		}
		else
		{
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
		var moveVector = ((Player.transform.position - this.transform.position).normalized) * _moveSpeed;
		this.transform.position = this.transform.position + moveVector;
	}
	bool CheckDistanceToOrigin()
	{
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

	

