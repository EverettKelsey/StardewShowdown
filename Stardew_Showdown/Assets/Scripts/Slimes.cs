using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Slimes : MonoBehaviour
{
    [SerializeField] Sprite _deadSprite;
    [SerializeField] ParticleSystem _particleSystem;

    bool _hasDied;

    //void OnMouseDown()
    //{
    //    GetComponent<AudioSource>().Play();
    //}

    // IEnumerator Start()
    // {
    //     while (_hasDied == false)
    //     {
    //         float delay = UnityEngine.Random.Range(5, 30);
    //         yield return new WaitForSeconds(delay);
    //         if (_hasDied == false)
    //         {
    //             GetComponent<AudioSource>().Play();
    //         }
    //     }
    // }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (ShouldDieFromCollision(collision))
        {
            StartCoroutine(Die());
        }
        
    }

    IEnumerator Die()
    {
        _hasDied = true;
        GetComponent<SpriteRenderer>().sprite = _deadSprite;
        _particleSystem.Play();
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }

    bool ShouldDieFromCollision(Collision2D collision)
    {
        if (_hasDied)
            return false;
        
        Krobus krobus = collision.gameObject.GetComponent<Krobus>();
        if (krobus != null)
            return true;
        
        if(collision.contacts[0].normal.y < -0.5)
            return true;

        return false;
    }
}
