using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

/// <summary>
/// Draggable buildings are always snapped to grid, and can be dragged by mouse.
/// </summary>
public class DraggableSprite : MonoBehaviour {
	public SpriteRenderer sprite;
	public bool canDrag = true;

	private bool mouseDown = false;
	private Vector3 dragOffset;
	private bool restrictX;
	private bool restrictY;
	private float fakeX;
	private float fakeY;
	private float myWidth;
	private float myHeight;

	void Start()
	{
		if (sprite == null) {
			sprite = GetComponent<SpriteRenderer> ();
		}
		if (sprite == null) {
			Debug.LogError ("sprite not assigned in DraggableSprite", this);
			return;
		}
		SnapToGrid ();
	}


	void OnMouseDown() 
	{
		if (canDrag) {
			mouseDown = true;
			var mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			dragOffset = (transform.position - sprite.bounds.min);
			GetComponent<Rigidbody2D> ().gravityScale = 0;
		}
	}

	void OnMouseUp() 
	{
		if (mouseDown) {
			mouseDown = false;
			GetComponent<Rigidbody2D> ().gravityScale = 1;
		}
	}

	void SnapToGrid() {
	}


	void Update () 
	{
		if (mouseDown) {
			var mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			transform.position = mousePos + dragOffset;
			SnapToGrid ();
		}
	}
}