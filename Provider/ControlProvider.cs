using UnityEngine;
using UnityEditor;
using System.Collections;

namespace UnityTableViewer.Provider {
	
	public class ControlProvider : IControlProvider {
		
		public void drawControl (ControlType type, string data) {
			switch(type) {
			case ControlType.TEXT:
				GUILayout.TextField (data);
				break;
			default:
				break;
			}
		}
	}
}
