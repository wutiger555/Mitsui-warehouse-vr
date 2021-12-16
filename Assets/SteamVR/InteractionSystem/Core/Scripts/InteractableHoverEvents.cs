//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Sends UnityEvents for basic hand interactions
//
//=============================================================================

using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	[RequireComponent( typeof( Interactable ) )]
	public class InteractableHoverEvents : MonoBehaviour
	{
		public UnityEvent onHandHoverBegin;
		public UnityEvent onHandHoverEnd;
		public UnityEvent onAttachedToHand;
		public UnityEvent onDetachedFromHand;

		//-------------------------------------------------
		private void OnHandHoverBegin()
		{
			onHandHoverBegin.Invoke();
		}


		//-------------------------------------------------
		private void OnHandHoverEnd()
		{
			onHandHoverEnd.Invoke();
		}


		//-------------------------------------------------
		public Canvas menu;
		public GameObject quad;
		
		private void OnAttachedToHand( Hand hand )
		{
			onAttachedToHand.Invoke();
			//menu.enabled = false;
		}


		//-------------------------------------------------
		
		private void OnDetachedFromHand( Hand hand )
		{
			onDetachedFromHand.Invoke();
			//menu.enabled = true;
		}
	}
}
