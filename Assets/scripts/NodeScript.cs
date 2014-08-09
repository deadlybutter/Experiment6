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

	public void execute(Node node){
		commands[0].execute(node, this);
	}

	public void next(Node node){
		index++;
		if(index >= commands.Count){
			return;
		}
		commands[index].execute(node, this);
	}

}
