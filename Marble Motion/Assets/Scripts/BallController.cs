﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class BallController
{
    public float speed = 10;
    public float scoreModifier = 100;

    private IMovementController movementController;
    private IScoreController scoreController;

    public void Move(float moveHorizontal, float moveVertical)
    {
        movementController.Move(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
    }

    public void SetScore()
    {
        scoreController.Set(scoreModifier * speed);
    }

    public void SetMovementController(IMovementController movementController)
    {
        this.movementController = movementController;
    }

    public void SetScoreController(IScoreController scoreController)
    {
        this.scoreController = scoreController;
    }
}
