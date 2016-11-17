using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColour;
    public Vector3 positionOffset;

    private GameObject turret;

    private Renderer rend;
    private Color startColour;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColour = rend.material.color;
    }

    void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Cant Build here: TODO: Display on screen");
            return;
        }

        // Build a Turret
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }

	void OnMouseEnter()
    {
        rend.material.color = hoverColour;
    }

    void OnMouseExit()
    {
        rend.material.color = startColour;
    }

}
