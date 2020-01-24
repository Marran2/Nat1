using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex
{
    public Hex(int q, int r) {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    public int Q;
    public int R;
    public int S;

    static readonly float WIDTH_MODIFIER = Mathf.Sqrt(3) / 2;

    public Vector3 Position() {
        float radius = 1f;
        float height = 2f;
        float width = WIDTH_MODIFIER * height;

        float vert = height * 0.75f; 
        float horiz = width;

        return new Vector3(horiz * (this.Q + this.R/2f), 0, vert * this.R);
    }
}
