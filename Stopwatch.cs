using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Stopwatch
    {
        // Initialising the stopwatch start and stop time.
        private TimeSpan _startTime;
        private TimeSpan _stopTime;

        public void Start(string startButton) // Method to 'start' the stopwatch.
        {
            this._startTime = DateTime.Now.TimeOfDay;
        }

        public void Stop(string stopButton) // Method to 'stop' the stopwatch.
        {
            if (stopButton == "s")
            {
                // If the user attempts to start the stopwatch when it is already running, program throws an exception.
                throw new InvalidOperationException("Cannot start stopwatch after it has already been started.");
            }

            this._stopTime = DateTime.Now.TimeOfDay;

        }

        public TimeSpan Duration() // Calculating the duration.
        {
            return this._stopTime - this._startTime;
        }
    }
}
