using System;


namespace Unit04.Game.Casting
{
        /// <summary>
        /// <para>A falling object.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a score.
        /// </para>
        /// </summary>
    class Artifact : Actor
    {
        private string _artifact;
        private int _points = 0;
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Artifact()
        {
            _artifact = "artifact";
        }
        
        /// <summary>
        /// Gets the point value for an artifact, 1 for gems -3 for rocks
        /// </summary>
        public int GetPoints()
        {
            string text = GetText();
            if (text == "O")
            {
                _points = -3;
            }
            else if (text == "x")
            {
                _points = 1;
            }
            return _points;
        }
    }
}
