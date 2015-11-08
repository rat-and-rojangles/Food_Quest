using UnityEngine;
using System.Collections;

public interface IPowerup {

	void applyPower();
	void addToInventory();
	void removeFromInventory();

	void disappear();
	void respawn();

	bool inWorld();
}
