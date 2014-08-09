using UnityEngine;
using System.Collections;

public class Command {

	public string KEY;

	public virtual void generate(){

	}

	public virtual void execute(Node node, NodeScript script){

	}

	public virtual float getFloat(){
		return 0;
	}

	public virtual int getInt(){
		return 0;
	}

	public virtual bool getBoolean(){
		return false;
	}

	public virtual Vector3 getVector3(){
		return new Vector3(0, 0, 0);
	}

	public virtual Node getNode(){
		return new Node();
	}

}
