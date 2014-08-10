using UnityEngine;
using System.Collections;

public class PauseCommand : Command {

	public const float range = 10;
	public float waitTime;

	private NodeScript script;

	public PauseCommand() : base("PAUSE") {

	}

	public override void generate(){
		waitTime = Random.Range(1, range);
	}
	
	public override void execute(NodeScript script){
		generate();
		this.script = script;
		Invoke("endDelay", waitTime);
	}

	public void endDelay(){
		script.next();
	}

}
