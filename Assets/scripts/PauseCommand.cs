using UnityEngine;
using System.Collections;

public class PauseCommand : Command {

	public const float range = 10;
	public float waitTime;

	private NodeScript script;

	public PauseCommand() : base("PAUSE") {
		generate();
	}
	
	public override void generate(){
		waitTime = Random.Range(1, range);
		Debug.Log(waitTime);
	}
	
	public override void execute(NodeScript script){
		this.node = node;
		this.script = script;
		Invoke("endDelay", waitTime);
	}

	public void endDelay(){
		script.next();
	}

}
