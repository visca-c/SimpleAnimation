namespace visca_c.Utilities.Extensions
{
    using UnityEngine;

    public static class SimpleAnimationExtensions
    {
        /// <summary>
        /// Try to play clip by name. If state doesn't exist, add it to SimpleAnimation and play it. 
        /// </summary>
        public static void PlayClip(this SimpleAnimation simpleAnimation, AnimationClip clip)
        {
            if (simpleAnimation.GetState(clip.name) == null)
            {
                simpleAnimation.AddClip(clip, clip.name);
            }
            simpleAnimation.clip = clip;
            simpleAnimation.Play(clip.name);
        }
        
        public static bool IsCurrentClipFinished(this SimpleAnimation simpleAnimation)
        {
            return simpleAnimation.GetState(simpleAnimation.clip.name).normalizedTime >= 1;
        }
    }
}
