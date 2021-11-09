using System;

namespace BuildAndRun.CustomException {
    public class StateChangedEventArgs : EventArgs {
        public string Name { get; private set; }
        public DateTime? ExecutedAt { get; private set; }
        public State State { get; private set; }

        public StateChangedEventArgs(string name, DateTime? executedAt, State state) {
            Name = name;
            ExecutedAt = executedAt;
            State = state;
        }
    }
}
