using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cat : MonoBehaviour, IPointerClickHandler
{

    protected float _petTime = 1f, _petTimer;
    protected bool _petActive = false;
    Animator myAnimator;
    Transform catVocalizationParent;
    [SerializeField] GameObject catVocalizationPrefab;

    private void Awake()
    {
        myAnimator = GetComponent<Animator>();
        catVocalizationParent = GameObject.Find("CatVocalizationCanvas").transform;
    }


    private void Update()
    {
        UpdatePetTimer();
    }

    private void UpdatePetTimer()
    {
        if (_petActive)
        {
            if (_petTimer <= 0)
            {
                _petActive = false;
                myAnimator.SetBool("isBeingPet", false);
            }
            else
            {
                _petTimer -= Time.deltaTime;
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        Instantiate(catVocalizationPrefab, transform.position + 0.5f * Vector3.one, Quaternion.identity).transform.SetParent(catVocalizationParent);
        _petActive = true;
        _petTimer = _petTime;
        myAnimator.SetBool("isBeingPet", true);
    }
}


