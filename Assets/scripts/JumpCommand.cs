using UnityEngine;
using System.Collections;

public class JumpCommand : Command {
	
	public const float multiplier = 300;
	public Vector3 velocity;
	
	public JumpCommand() : base("JUMP") {

	}
	
	public override void generate(){
		velocity = new Vector3(0, Random.Range(rigidbody.mass * multiplier, (rigidbody.mass * multiplier) * 2), 0);
	}
	
	public override void execute(NodeScript script){
		generate();
		rigidbody.AddForce(velocity);
		script.next();
	}
	
}
