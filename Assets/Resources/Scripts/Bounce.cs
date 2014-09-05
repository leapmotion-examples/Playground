﻿/******************************************************************************\
* Copyright (C) Leap Motion, Inc. 2011-2014.                                   *
* Leap Motion proprietary. Licensed under Apache 2.0                           *
* Available at http://www.apache.org/licenses/LICENSE-2.0.html                 *
\******************************************************************************/

using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour {

  public Vector3 bounceMagnitude;
  public float bouncesPerSecond;
  public Vector3 startPosition;

  private float bounces = 0.0f;

  void Start() {
    startPosition = transform.position;
  }

  void Update () {
    bounces += Time.deltaTime * bouncesPerSecond;
  }
}
