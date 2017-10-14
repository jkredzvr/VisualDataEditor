using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDraggable {

	bool isDragging { get; set; }
    void toggleIsDragging();
}
