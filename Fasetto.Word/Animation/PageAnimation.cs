namespace Fasetto.Word
{
    /// <summary>
    /// Style of page animations for appearing/disappearing
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// No animation
        /// </summary>
        None = 0,
        /// <summary>
        /// The page slides in and fades in from the right
        /// </summary>
        SlideAndFadeInFromRight = 1,
        /// <summary>
        /// The page slides out and fades out to the left
        /// </summary>
        SlideAndFadeOutToLeft = 2,
    }
}
