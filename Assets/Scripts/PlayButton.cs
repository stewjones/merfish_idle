using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]private SpriteRenderer text;

    //Mouseover effects
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = Color.grey;
        Debug.Log("Hovered over!");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = Color.white;
        Debug.Log("Stopped hovering.");
    }

    //Load game on click
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Play button clicked!");
        SceneManager.LoadScene("Pond");
       
    }

}
