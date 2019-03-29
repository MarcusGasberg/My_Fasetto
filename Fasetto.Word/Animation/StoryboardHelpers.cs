using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// Animation helpers for <see cref="Storyboard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        #region Left Slides

        /// <summary>
        /// Add a slide from left animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the left to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            //Create the margin animate from the left
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add a slide to left animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the left to end at</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            //Create the margin animate from the left
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                DecelerationRatio = decelerationRatio
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        }
        #endregion

        #region Right Slides

        /// <summary>
        /// Add a slide to right animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to end at</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            //Create the margin animate from the right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        }
        /// <summary>
        /// Add a slide from right animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            //Create the margin animate from the right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        }
        #endregion

        #region Bottom Slides

        /// <summary>
        /// Add a slide from Bottom animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the Bottom to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="keepMargin">Whether to keep the element at the same height during animation</param>
        public static void AddSlideFromBottom(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            //Create the margin animate from the bottom
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0, keepMargin ? offset : 0, 0, -offset),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add a slide to Bottom animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="offset">The distance to the Bottom to end at</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        /// <param name="keepMargin">Wheter to keep the element at the same height during animation</param>
        public static void AddSlideToBottom(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            //Create the margin animate from the bottom
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(0, keepMargin ? offset : 0, 0, -offset),
                DecelerationRatio = decelerationRatio
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        }
        #endregion

        #region Fades
        /// <summary>
        /// Add fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            //Create the margin animate from the right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Add fade out animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take</param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            //Create the margin animate from the right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            //add this to the storyboard
            storyboard.Children.Add(animation);
        } 
        #endregion
    }
}
