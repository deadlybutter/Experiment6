using UnityEngine;
using System.Collections;

public class Command : MonoBehaviour {

	public string KEY;

	public Command(string key){
		this.KEY = key;
	}

	public virtual void generate(){

	}

	public virtual void execute(NodeScript script){

	}

}
