﻿using UnityEngine;
using System;
using System.Collections;

namespace Fungus
{
	public enum VariableType
	{
		Boolean,
		Integer,
		Float,
		String
	}

	public enum VariableScope
	{
		Private,
		Public
	}

	[RequireComponent(typeof(FungusScript))]
	public class Variable : MonoBehaviour
	{
		public VariableScope scope;
		public string key = "";

		public virtual void OnReset()
		{}
	}
}
