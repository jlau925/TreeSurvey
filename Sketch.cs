using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;
	// Use this for initialization
	void Start () {
        var myPrefab = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
        newCube.GetComponent<CubeScript>()RotateSpeed = Random.value;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
