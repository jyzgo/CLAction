using UnityEngine;
using System.Collections;

public class MoveBy : ActionInterval {

	Vector3 _speed;
	Vector3 _deltaPos;
	public MoveBy(float duration,Vector3 deltaPos)
	{
		_deltaPos = deltaPos;

		Debug.Assert(duration != 0f);
		_speed = deltaPos/duration;

	}

	public override void excute()
	{

		updatePos();

	}


	void updatePos()
	{
		target.transform.Translate(_speed * Time.deltaTime);
	}
}
