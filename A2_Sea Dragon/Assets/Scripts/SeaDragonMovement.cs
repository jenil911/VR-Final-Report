using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SeaDragonMovement : MonoBehaviourPunCallbacks
{
    Animator dragonAnimator;

    void Start()
    {
        if (!photonView.IsMine)
        {
            enabled = false;
        }
        dragonAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (!photonView.IsMine)
            return;
        JumpUpdates();
        MovementUpdates();
        AttackUpdates();
        PowerUpUpdated();
        FlyUpdates();
        WinOrLose();
    }

    void WinOrLose()
    {
        dragonAnimator.SetBool("isDancing", SeaDragonMain.isDancing);
        dragonAnimator.SetBool("isDead", SeaDragonMain.isDead);
    }

    void PowerUpUpdated()
    {
        dragonAnimator.SetBool("isEating", SeaDragonMain.isEating);
    }

    void FlyUpdates()
    {
    }

    void MovementUpdates()
    {
        if (!photonView.IsMine)
            return;
        dragonAnimator.SetBool("isWalkingVerticalForward", SeaDragonMain.verticalInput > 0);
        dragonAnimator.SetBool("isWalkingVerticalBack", SeaDragonMain.verticalInput < 0);
        dragonAnimator.SetBool("isWalkingHorizontalLeft", SeaDragonMain.horizontalInput < 0);
        dragonAnimator.SetBool("isWalkingHorizontalRight", SeaDragonMain.horizontalInput > 0);
        dragonAnimator.SetBool("isShiftPressed", SeaDragonMain.shiftPressed);
    }

    void JumpUpdates()
    {
        if (!photonView.IsMine)
            return;
        dragonAnimator.SetBool("isJumpPressed", SeaDragonMain.isJumpKeyPressed);
    }

    void AttackUpdates()
    {
        if (!photonView.IsMine)
            return;
        dragonAnimator.SetBool("isAttack1Pressed", SeaDragonMain.isFire1Pressed);
        dragonAnimator.SetBool("isQPressed", SeaDragonMain.isQPressed);
        dragonAnimator.SetBool("isEPressed", SeaDragonMain.isEPressed);
    }
}