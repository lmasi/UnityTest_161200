﻿using System;
using UnityEngine;

namespace ObjectHierachy
{
	public class Obtacle : MapObject
	{
		public Obtacle (Transform obj)
		{
			this.obj = obj;
		}

		public Obtacle createObtacle()
		{
			Transform _tmp = MonoBehaviour.Instantiate (this.obj);
			return new Obtacle (_tmp);
		}
	}
}

