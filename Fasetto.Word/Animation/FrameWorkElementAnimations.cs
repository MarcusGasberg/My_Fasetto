using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// Helpers to animate the framework elements in specific ways
    /// </summary>
    public static class FrameWorkElementAnimations
    {
        #region Slide Right

        /// <summary>
        /// Slide and fade in an element from the right
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="width">The animation width to animate to. If not specified element width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideFromRight(seconds, (width == 0 ? element.ActualWidth : width), keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slide and fade out an element to the right
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="width">The animation width to animate to. If not specified element width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideToRight(seconds, (width == 0 ? element.ActualWidth : width), keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            //Make element invisible
            element.Visibility = Visibility.Hidden;
        } 
        #endregion

        #region Slide Left

        /// <summary>
        /// Slide and fade in an element from the left
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="width">The animation width to animate to. If not specified element width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from left animation
            sb.AddSlideFromLeft(seconds, (width == 0 ? element.ActualWidth : width), keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slide and fade out an element to the left
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="width">The animation width to animate to. If not specified element width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide to left animation
            sb.AddSlideToLeft(seconds, (width == 0 ? element.ActualWidth : width), keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            //Make element invisible
            element.Visibility = Visibility.Hidden;
        }

        #endregion

        #region Slide Bottom

        /// <summary>
        /// Slide and fade in an element from the bottom
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="keepMargin">Whether to keep the element at the same height during animation</param>
        /// <param name="height">The animation height to animate to. If not specified element height is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromBottomAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int height = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from bottom animation
            sb.AddSlideFromBottom(seconds, (height == 0 ? element.ActualHeight : height), keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slide and fade out an element to the bottom
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="keepMargin">Whether to keep the element at the same height during animation</param>
        /// <param name="height">The animation height to animate to. If not specified element height is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToBottomAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int height = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideToBottom(seconds, (height == 0 ? element.ActualHeight : height), keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));


            //Make element invisible
            element.Visibility = Visibility.Hidden;
        }

        #endregion


        #region Fade In Out

        /// <summary>
        /// Slide and fade in an element from the bottom
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <returns></returns>
        public static async Task FadeInAsync(this FrameworkElement element, float seconds = 0.3f)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Fades out an element to the bottom
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <returns></returns>
        public static async Task FadeOutAsync(this FrameworkElement element, float seconds = 0.3f)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            //Make element invisible
            element.Visibility = Visibility.Hidden;
        }

        #endregion
    }
}
