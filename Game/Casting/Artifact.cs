namespace Unit04.Game.Casting{
        /// <summary>
        /// <para>An item of cultural or historical interest.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>
    class Artifact : Actor
    {
        private string _artifact;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {
            _artifact = "artifact";
        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public string GetMessage()
        {
            // Keep track of value; rocks are -1 and gems are 1
            return _artifact;
        }
        
        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetMessage(string message)
        {
            _artifact = message;
        }
        
    }
}
