﻿// Darknet - Massively Multiplayer Online Role-Plaing Game (MMORPG) - CS Capstone 2015
// Simon Ayzman, Cammie Storey, Slavisa Djukic, Raymond Liang, Christian Diaz

// Slavisa Djukic

using UnityEngine;
using System.Collections;

public class BowUpgraded : MonoBehaviour {
	private Item current;
	
	// Use this for initialization
	void Start () {
		current = this.GetComponent<Item>();
		if (current != null) {
			current.setConsumable( false );
			current.setDescription( "bow upgraded" );
			current.item_properties = new Hashtable();
			current.item_properties["attack"] = 21;
			current.item_properties["range"] = 4.3;
			current.item_sprite = this.GetComponent<SpriteRenderer>().sprite;
		} else {
			Debug.Log ("No such item, Bro.");
		}
	}
}
