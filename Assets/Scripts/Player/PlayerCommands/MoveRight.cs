﻿using UnityEngine;
using System.Collections;


class MoveRight : BaseCommand
{
    public override void Execute(Transform tr)
    {
        tr.Translate(new Vector3(2f, 0, 0));
        Debug.Log("Moving right");
    }
}

