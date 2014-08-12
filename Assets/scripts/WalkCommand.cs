using UnityEngine;
using System.Collections;

public class WalkCommand : Command {
	
	public const float multiplier = 50;
	public float multiplied;
	public float doubleMultiplied;
	public bool walk;

	public WalkCommand() : base("WALK") {
		
	}
	
	public override void execute(NodeScript script){
		multiplied = rigidbody.mass * multiplier;
		doubleMultiplied = multiplied * 2;
		walk = true;
		script.next();
	}

	protected override void FixedUpdate(){
		if(!walk){
			return;
		}
		Vector3 velocity = new Vector3(Random.Range(Random.Range(-multiplied, -doubleMultiplied), Random.Range(multiplied, doubleMultiplied)), 0, Random.Range(Random.Range(-multiplied, -doubleMultiplied), Random.Range(multiplied, doubleMultiplied)));
		rigidbody.AddForce(velocity);
	}
	
}
