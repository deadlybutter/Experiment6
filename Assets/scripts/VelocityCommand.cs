using UnityEngine;
using System.Collections;

public class VelocityCommand : Command {

	public const float range = 100;
	Vector3 velocity;

	public VelocityCommand() : base("VELOCITY") {
		generate();
	}

	public override void generate(){
		velocity = new Vector3(Random.Range(-range, range), Random.Range(-range, range), Random.Range(-range, range));
	}

	public override void execute(NodeScript script){
		rigidbody.AddForce(velocity);
		script.next();
	}

}
