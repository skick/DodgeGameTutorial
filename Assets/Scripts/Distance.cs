using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour {

    public Transform player;
    public Text distanceText;

	// Update is called once per frame
	void Update () {

        distanceText.text = player.position.z.ToString("0");

	}
}
