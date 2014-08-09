using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Node : MonoBehaviour {

	public enum TRIGGERS {
		START, COLLIDE, UPDATE
	};

	public List<NodeScript> scripts;

	protected virtual void Awake(){
		scripts = new List<NodeScript>();
	}

	// Use this for initialization
	protected virtual void Start () {
		checkScripts(TRIGGERS.START);
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		checkScripts(TRIGGERS.UPDATE);
	}

	public void AddScript(NodeScript script){
		scripts.Add(script);
	}

	public void checkScripts(TRIGGERS trigger){
		foreach(NodeScript ns in scripts){
			if(ns.trigger.Equals(trigger)){
				ns.execute();
			}
		}
	}

	//Genetics functions

	public virtual void generate(){

	}

	public virtual float getFitness(){
		return 0;
	}

	public virtual Node makeChild(Node parentB){
		return new Node();
	}

	//Triggers - Can be overridden if needed

}
