using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractionSystem : MonoBehaviour
{
    [Header("상호 작용 설정")]
    public float interactionRange = 2.0f;
    public LayerMask interactionLayerMask = 1;
    public KeyCode interactionKey = KeyCode.E;

    [Header("UI 설정")]
    public Text interactionText;
    public GameObject interactionUl;


    private Transform playerTransform;
    private Interactableobject currentInteractiable;

    void HandleinteractionInput()
    {
        if (currentInteractiabie != null && Input.GetKeyDown(interactionKey))
        {
            currentInteractiable.Interact();
        }
    }

    void ShowinteractionUI(string text)
    {
        if (interactionUI != null)
        {
            interactionUl.SetActive(true);
        }

        if (interactionText != null)
        {
            interactionText.text = text;
        }


    }

    void HideInteractionUI()
    {
        if (interactionUI != null)
        {
            interactionUl.SetActive(false);
        }

    }





}
