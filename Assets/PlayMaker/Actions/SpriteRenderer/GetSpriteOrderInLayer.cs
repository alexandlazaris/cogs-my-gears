﻿// (c) Copyright HutongGames, LLC 2010-2019. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.SpriteRenderer)]
    [Tooltip("Get the Order in Layer of a SpriteRenderer component.")]
    public class GetSpriteOrderInLayer : ComponentAction<SpriteRenderer>
    {
        [RequiredField]
        [CheckForComponent(typeof(SpriteRenderer))]
        [Tooltip("The GameObject with the SpriteRenderer component.")]
        public FsmOwnerDefault gameObject;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("The Order In Layer Value")]
        public FsmInt orderInLayer;

        public override void Reset()
        {
            gameObject = null;
            orderInLayer = null;
        }

        public override void OnEnter()
        {
            if (!UpdateCache(Fsm.GetOwnerDefaultTarget(gameObject)))
            {
                return;
            }

            orderInLayer.Value = cachedComponent.sortingOrder;

            Finish();
        }
    }
}
