using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    private Animator anim;
    private bool spellKeyPressed = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        if (Input.GetKey(KeyCode.T))
        {
            anim.SetBool("dance", true);
        }
        else
        {
            anim.SetBool("dance", false);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("Crouch", true);
        }
        else
        {
            anim.SetBool("Crouch", false);
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.W))
        {
            anim.SetBool("CrouchWalk", true);
        }
        else
        {
            anim.SetBool("CrouchWalk", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("BackWalk", true);
        }
        else
        {
            anim.SetBool("BackWalk", false);
        }


        if (Input.GetKeyDown(KeyCode.Mouse0) && !spellKeyPressed)
        {
            anim.SetTrigger("Spell");
            spellKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            spellKeyPressed = false;
        }
      
       if (Input.GetKeyDown(KeyCode.Alpha1) && !spellKeyPressed)
        {
            anim.SetTrigger("1SpellSwitch");
            spellKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            spellKeyPressed = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && !spellKeyPressed)
        {
            anim.SetTrigger("1SpellSwitch");
            spellKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            spellKeyPressed = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && !spellKeyPressed)
        {
            anim.SetTrigger("1SpellSwitch");
            spellKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            spellKeyPressed = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && !spellKeyPressed)
        {
            anim.SetTrigger("1SpellSwitch");
            spellKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            spellKeyPressed = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && !spellKeyPressed)
        {
            anim.SetTrigger("1SpellSwitch");
            spellKeyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            spellKeyPressed = false;
        }


    }
}
