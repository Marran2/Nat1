using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        GenerateMap();
    }

    public GameObject HexPrefab;
    public int side;

    public void GenerateMap() {

        int size = side - 1;
        int start = 0;
        int end = 0;

        for (int q = -size; q <= size; q++) {

            if (q < 0) {
                start = -size - q;
                end = size;
            } else {
                start = -size;
                end = size - q;
            }

            for (int r = start; r <= end; r++) {

                Hex h = new Hex(q, r);

                Instantiate(HexPrefab, h.Position(), Quaternion.identity, this.transform);
            }

        }
    }
}
