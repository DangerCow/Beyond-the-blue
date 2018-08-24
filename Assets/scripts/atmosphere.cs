using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atmosphere : MonoBehaviour {

    private Transform atmo_sprite;
    public float planet_rad;
    public Color atmo_colr;

    private GameObject haze;
    public GameObject atmofab;
    public Transform planet;

	// Use this for initialization
	void Start () {

        planet_rad *= 16.9045f;

        GameObject atmos = Instantiate(atmofab, planet.position, planet.rotation);
        atmos.transform.parent = gameObject.transform;

        haze = atmofab.transform.GetChild (0).gameObject;
        atmo_sprite = atmofab.transform.GetChild(0);

        atmofab.transform.localScale = new Vector3(planet_rad,  planet_rad, planet_rad);

        Renderer rend = atmofab.GetComponent<Renderer>();
        Renderer c_rend = haze.GetComponent<Renderer>();

        rend.sharedMaterial.SetColor("_Color", atmo_colr);
        atmo_colr.a += 1;
        c_rend.sharedMaterial.SetColor("_Color", atmo_colr);
    }
}
