using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EntityNode : Node {

	protected override void Awake(){
		base.Awake();
		generate();
	}

	// Use this for initialization
	protected override void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}

	public override void generate (){
		List<Command> commands = new List<Command>();
		//commands.Add((Command) gameObject.AddComponent<PauseCommand>());
		commands.Add((Command) gameObject.AddComponent<JumpCommand>());
		commands.Add((Command) gameObject.AddComponent<VelocityCommand>());
		NodeScript nodeScript = new NodeScript(TRIGGERS.START, commands);
		AddScript(nodeScript);
	}

	public override float getFitness(){
		return 1;
	}

	public override Node makeChild (Node parentB){
		throw new System.NotImplementedException ();
	}
}
