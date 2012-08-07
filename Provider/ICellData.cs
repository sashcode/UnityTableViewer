using System;
using UnityEngine;
using System.Collections;

namespace UnityTableViewer.Provider {
	public interface ICellData {
		string Name { get; }
		System.Object GetData(string name);
		void SetData(System.Object obj, string name);
	}
}