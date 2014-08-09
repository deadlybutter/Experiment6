using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NodeScript {

	public Node.TRIGGERS trigger;
	public List<Command> commands;
	public int index = 0;

	public NodeScript(Node.TRIGGERS trigger, List<Command> commands){
		this.trigger = trigger;
		this.commands = commands;
	}

	public void execute(){
		commands[0].execute(this);
	}

	public void next(){
		index++;
		if(index >= commands.Count){
			return;
		}
		commands[index].execute(this);
	}

}
