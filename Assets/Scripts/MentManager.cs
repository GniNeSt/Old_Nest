using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    public GameObject mentTMP;
    private void Awake() {
        animator = GetComponent<Animator>();
    }

    public void SetMent(string newment){
        if (mentTMP.activeSelf == true)
            mentTMP.GetComponent<TMPro.TextMeshProUGUI>().text = newment;
        else
            Debug.Log("Why?");
    }
    // Update is called once per frame
    private void OnMouseUp() {
        if(animator.GetBool("isMent") == true){
            animator.SetTrigger("TriRead");
            animator.SetBool("isMent",false);
            Debug.Log("Anim");
        }
    }
}
