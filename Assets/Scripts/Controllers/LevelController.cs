using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    public TextMeshProUGUI chapterNumber;
    public TextMeshProUGUI chapterName;

    private Animator animator;
    public GameController gameController;
    public bool isHidden = false;
    public LevelScene levelScene;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Hide()
    {
        if (!isHidden)
        {
            animator.SetTrigger("Hide");
            isHidden = true;
        }
    }

    public void Show()
    {
        animator.SetTrigger("Show");
        isHidden = false;
    }
    
   public void Text(LevelScene text)
    {
        chapterNumber.text = text.chapterNumber;
        chapterName.text = text.text;
    }
}
